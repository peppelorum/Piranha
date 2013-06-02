﻿using System;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

using Piranha.Models;

namespace Piranha.Security
{
	/// <summary>
	/// User provider that uses the internal membership system in Piranha CMS.
	/// </summary>
	internal sealed class LocalUserProvider : IUserProvider
	{
		#region Properties
		/// <summary>
		/// Gets if the current user is authenticated.
		/// </summary>
		public bool IsAuthenticated {
			get { return HttpContext.Current.User.Identity.IsAuthenticated ; }
		}

		/// <summary>
		/// Gets the user id of the current user.
		/// </summary>
		public Guid UserId {
			get { return new Guid(HttpContext.Current.User.Identity.Name) ; }
		}
		#endregion

		/// <summary>
		/// Authenticates the user.
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="password">The password</param>
		/// <returns>If the username and passwords matches</returns>
		public bool Authenticate(string username, string password) {
			using (var db = new DataContext()) {
				var user = db.Users
					.Where(u => u.Login == username && u.Password == Encrypt(password) && (!u.IsLocked || u.LockedUntil <= DateTime.Now))
					.SingleOrDefault() ;
				if (user != null)
					return true ;
			}
			return false ;
		}

		#region Private methods
		/// <summary>
		/// Maps a Piranha CMS user to a membership user.
		/// </summary>
		/// <param name="user">The user</param>
		/// <returns>The membership user</returns>
		private MembershipUser MapUser(SysUser user) {
			return new MembershipUser("Piranha.Security.InternalUserProvider", user.Login, user.Id, user.Email, "", "", true, 
				user.IsLocked, user.Created, user.LastLogin, user.LastLogin, user.Created, user.Created) ;
		}

		/// <summary>
		/// Encrypts the given string with SHA256.
		/// </summary>
		/// <param name="str">The string</param>
		/// <returns>The encrypted</returns>
		private string Encrypt(string str) {
			UTF8Encoding encoder = new UTF8Encoding() ;
			SHA256CryptoServiceProvider crypto = new SHA256CryptoServiceProvider() ;

			byte[] bytes = crypto.ComputeHash(encoder.GetBytes(str)) ;
			return Convert.ToBase64String(bytes) ;
		}
		#endregion
	}
}