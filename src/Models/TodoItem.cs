﻿namespace todo.Models
{
    using Newtonsoft.Json;

    public class TodoItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "isComplete")]
        public bool Completed { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }
}