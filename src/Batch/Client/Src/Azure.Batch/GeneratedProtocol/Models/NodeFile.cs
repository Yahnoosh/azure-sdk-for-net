// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about a file or directory on a compute node.
    /// </summary>
    public partial class NodeFile
    {
        /// <summary>
        /// Initializes a new instance of the NodeFile class.
        /// </summary>
        public NodeFile() { }

        /// <summary>
        /// Initializes a new instance of the NodeFile class.
        /// </summary>
        /// <param name="name">The file path.</param>
        /// <param name="url">The URL of the file.</param>
        /// <param name="isDirectory">Whether the object represents a
        /// directory.</param>
        /// <param name="properties">The file properties.</param>
        public NodeFile(string name = default(string), string url = default(string), bool? isDirectory = default(bool?), FileProperties properties = default(FileProperties))
        {
            Name = name;
            Url = url;
            IsDirectory = isDirectory;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URL of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets whether the object represents a directory.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isDirectory")]
        public bool? IsDirectory { get; set; }

        /// <summary>
        /// Gets or sets the file properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public FileProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
