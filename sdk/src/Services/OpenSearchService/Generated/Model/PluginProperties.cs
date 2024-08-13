/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Basic information about the plugin.
    /// </summary>
    public partial class PluginProperties
    {
        private string _className;
        private string _description;
        private string _name;
        private long? _uncompressedSizeInBytes;
        private string _version;

        /// <summary>
        /// Gets and sets the property ClassName. 
        /// <para>
        /// The name of the class to load.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ClassName
        {
            get { return this._className; }
            set { this._className = value; }
        }

        // Check to see if ClassName property is set
        internal bool IsSetClassName()
        {
            return this._className != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UncompressedSizeInBytes. 
        /// <para>
        /// The uncompressed size of the plugin.
        /// </para>
        /// </summary>
        public long? UncompressedSizeInBytes
        {
            get { return this._uncompressedSizeInBytes; }
            set { this._uncompressedSizeInBytes = value; }
        }

        // Check to see if UncompressedSizeInBytes property is set
        internal bool IsSetUncompressedSizeInBytes()
        {
            return this._uncompressedSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}