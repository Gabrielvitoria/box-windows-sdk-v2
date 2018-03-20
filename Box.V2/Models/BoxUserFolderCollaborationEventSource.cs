﻿using Newtonsoft.Json;

namespace Box.V2.Models
{
    /// <summary>
    /// There is an inconsistency in the events API where file sources have slightly different field names.
    /// </summary>
    class BoxUserFolderCollaborationEventSource : BoxEntity
    {
        public const string FieldFolderId = "folder_id";
        public const string FieldFolderName = "folder_name";
        public const string FieldUserId = "user_id";
        public const string FieldUserName = "user_name";
        public const string FieldParent = "parent";

        /// <summary>
        /// The Id of the folder.
        /// </summary>
        [JsonProperty(PropertyName = FieldFolderId)]
        new public string FolderId { get; private set; }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonProperty(PropertyName = FieldFolderName)]
        new public string FolderName { get; private set; }

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [JsonProperty(PropertyName = FieldUserId)]
        new public string UserId { get; private set; }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonProperty(PropertyName = FieldUserName)]
        new public string UserName { get; private set; }

        /// <summary>
        /// The parent folder.
        /// </summary>
        [JsonProperty(PropertyName = FieldParent)]
        public BoxFolder Parent { get; private set; }
    }
}