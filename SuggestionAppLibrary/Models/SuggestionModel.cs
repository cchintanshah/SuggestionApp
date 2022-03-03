﻿

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SuggestionAppLibrary.Models
{
    public class SuggestionModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Suggestion { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public CategoryModel Category { get; set; }

        public BasicUserModel Author { get; set; }

        // we need unique user vote thats why we are taking the type hashset
        public HashSet<string> UserVotes { get; set; } = new();

        public StatusModel SuggestionStatus { get; set; }

        public string OwnersNotes { get; set; }

        public bool ApprovedForRelease { get; set; } = false;

        public bool Archived { get; set; } = false;

        public bool Rejected { get; set; } = false;

    }
}
