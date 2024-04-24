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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Archive Output Settings
    /// </summary>
    public partial class ArchiveOutputSettings
    {
        private ArchiveContainerSettings _containerSettings;
        private string _extension;
        private string _nameModifier;

        /// <summary>
        /// Gets and sets the property ContainerSettings. Settings specific to the container type
        /// of the file.
        /// </summary>
        [AWSProperty(Required=true)]
        public ArchiveContainerSettings ContainerSettings
        {
            get { return this._containerSettings; }
            set { this._containerSettings = value; }
        }

        // Check to see if ContainerSettings property is set
        internal bool IsSetContainerSettings()
        {
            return this._containerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Extension. Output file extension. If excluded, this will
        /// be auto-selected from the container type.
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        // Check to see if Extension property is set
        internal bool IsSetExtension()
        {
            return this._extension != null;
        }

        /// <summary>
        /// Gets and sets the property NameModifier. String concatenated to the end of the destination
        /// filename.  Required for multiple outputs of the same type.
        /// </summary>
        public string NameModifier
        {
            get { return this._nameModifier; }
            set { this._nameModifier = value; }
        }

        // Check to see if NameModifier property is set
        internal bool IsSetNameModifier()
        {
            return this._nameModifier != null;
        }

    }
}