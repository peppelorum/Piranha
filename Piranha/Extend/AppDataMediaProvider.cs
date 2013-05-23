﻿using System;
using System.IO;
using System.Web;

namespace Piranha.Extend
{
	/// <summary>
	/// Media provider for storing data on the local disc in the App_Data folder.
	/// </summary>
	public sealed class AppDataMediaProvider : IMediaProvider
	{
		#region Members
		/// <summary>
		/// The local base path for all media files.
		/// </summary>
		private readonly string BasePath = HttpContext.Current.Server.MapPath("~/App_Data/Content") ;

		/// <summary>
		/// The local base path for all media files.
		/// </summary>
		private readonly string UploadPath = HttpContext.Current.Server.MapPath("~/App_Data/Uploads") ;
		#endregion

		/// <summary>
		/// Default constructor, creates a new local media provider.
		/// </summary>
		public AppDataMediaProvider() {
			if (!Directory.Exists(BasePath))
				Directory.CreateDirectory(BasePath) ;
			if (!Directory.Exists(UploadPath))
				Directory.CreateDirectory(UploadPath) ;
		}

		/// <summary>
		/// Gets the data for the media entity with the given id.
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="type">The media type</param>
		/// <returns>The media data, null if the data wasn't found</returns>
		public byte[] Get(Guid id, MediaType type = MediaType.Media) {
			var path = GetPath(id, false, type) ;

			if (File.Exists(path))
				return File.ReadAllBytes(path) ;
			return null ;
		}

		/// <summary>
		/// Gets the draft data for the media entity with the given id.
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="type">The media type</param>
		/// <returns>The draft media data, null if the data wasn't found</returns>
		public byte[] GetDraft(Guid id, MediaType type = MediaType.Media) {
			var path = GetPath(id, true, type) ;

			if (File.Exists(path))
				return File.ReadAllBytes(path) ;
			return null ;
		}

		/// <summary>
		/// Stores the given data for the media entity with the given id.
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="data">The media data</param>
		/// <param name="type">The media type</param>
		public void Put(Guid id, byte[] data, MediaType type = MediaType.Media) {
			var path = GetPath(id, false, type) ;
			File.WriteAllBytes(path, data) ;
		}

		/// <summary>
		/// Stores the given data as a draft for the media entity with the given id.
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="data">The media data</param>
		/// <param name="type">The media type</param>
		public void PutDraft(Guid id, byte[] data, MediaType type = MediaType.Media) {
			var path = GetPath(id, true, type) ;
			File.WriteAllBytes(path, data) ;
		}

		/// <summary>
		/// Deletes the data for the media entity with given id.
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="type">The media type</param>
		public void Delete(Guid id, MediaType type = MediaType.Media) {
			var path = GetPath(id, false, type) ;
			if (File.Exists(path))
				File.Delete(path) ;
		}

		/// <summary>
		/// Deletes the draft for the media entity with the given id.
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="type">The media type</param>
		public void DeleteDraft(Guid id, MediaType type = MediaType.Media) {
			var path = GetPath(id, true, type) ;
			if (File.Exists(path))
				File.Delete(path) ;
		}

		/// <summary>
		/// Publishes the current draft for the media entity with the given id. This means
		/// making the draft data the published data
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="type">The media type</param>
		public void Publish(Guid id, MediaType type = MediaType.Media) {
			var path = GetPath(id, false, type) ;
			var draft = GetPath(id, true, type) ;
			
			if (File.Exists(draft))
				File.Move(draft, path) ;
		}

		/// <summary>
		/// Unpublishes the current draft for the media entity with the given id. This means
		/// making the published data the draft data
		/// </summary>
		/// <param name="id">The id</param>
		/// <param name="type">The media type</param>
		public void Unpublish(Guid id, MediaType type = MediaType.Media) {
			var path = GetPath(id, false, type) ;
			var draft = GetPath(id, true, type) ;

			if (File.Exists(path))
				File.Move(path, draft) ;
		}

		#region Private methods
		/// <summary>
		/// Gets the local path from the given parameters.
		/// </summary>
		/// <param name="id">The media id</param>
		/// <param name="draft">Whether or not this is a draft</param>
		/// <param name="type">The media type</param>
		/// <returns>The local path</returns>
		private string GetPath(Guid id, bool draft, MediaType type = MediaType.Media) {
			return (type == MediaType.Media ? BasePath : UploadPath) + "/" + id.ToString() + (draft ? "-draft" : "") ;
		}
		#endregion
	}
}