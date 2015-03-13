// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Hyak.Common;
using System.Collections.Generic;

namespace Microsoft.Azure.Management.Csm.Models
{
    /// <summary>
    /// Resource type managed by the resource provider.
    /// </summary>
    public partial class ProviderResourceType
    {
        private IList<string> _locations;
        
        /// <summary>
        /// Optional. Gets or sets the collection of locations where this
        /// resource type can be created in.
        /// </summary>
        public IList<string> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the resource type.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProviderResourceType class.
        /// </summary>
        public ProviderResourceType()
        {
            this.Locations = new LazyList<string>();
        }
    }
}
