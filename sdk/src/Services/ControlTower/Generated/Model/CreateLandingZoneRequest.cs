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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLandingZone operation.
    /// Creates a new landing zone. This API call starts an asynchronous operation that creates
    /// and configures a landing zone, based on the parameters specified in the manifest JSON
    /// file.
    /// </summary>
    public partial class CreateLandingZoneRequest : AmazonControlTowerRequest
    {
        private Amazon.Runtime.Documents.Document _manifest;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _version;

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The manifest.yaml file is a text file that describes your Amazon Web Services resources.
        /// For examples, review <a href="https://docs.aws.amazon.com/controltower/latest/userguide/the-manifest-file">The
        /// manifest file</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return !this._manifest.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be applied to the landing zone. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The landing zone version, for example, 3.0.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=10)]
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