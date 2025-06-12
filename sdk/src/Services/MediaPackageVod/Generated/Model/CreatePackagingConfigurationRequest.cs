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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
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
namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePackagingConfiguration operation.
    /// Creates a new MediaPackage VOD PackagingConfiguration resource.
    /// </summary>
    public partial class CreatePackagingConfigurationRequest : AmazonMediaPackageVodRequest
    {
        private CmafPackage _cmafPackage;
        private DashPackage _dashPackage;
        private HlsPackage _hlsPackage;
        private string _id;
        private MssPackage _mssPackage;
        private string _packagingGroupId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CmafPackage.
        /// </summary>
        public CmafPackage CmafPackage
        {
            get { return this._cmafPackage; }
            set { this._cmafPackage = value; }
        }

        // Check to see if CmafPackage property is set
        internal bool IsSetCmafPackage()
        {
            return this._cmafPackage != null;
        }

        /// <summary>
        /// Gets and sets the property DashPackage.
        /// </summary>
        public DashPackage DashPackage
        {
            get { return this._dashPackage; }
            set { this._dashPackage = value; }
        }

        // Check to see if DashPackage property is set
        internal bool IsSetDashPackage()
        {
            return this._dashPackage != null;
        }

        /// <summary>
        /// Gets and sets the property HlsPackage.
        /// </summary>
        public HlsPackage HlsPackage
        {
            get { return this._hlsPackage; }
            set { this._hlsPackage = value; }
        }

        // Check to see if HlsPackage property is set
        internal bool IsSetHlsPackage()
        {
            return this._hlsPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the PackagingConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MssPackage.
        /// </summary>
        public MssPackage MssPackage
        {
            get { return this._mssPackage; }
            set { this._mssPackage = value; }
        }

        // Check to see if MssPackage property is set
        internal bool IsSetMssPackage()
        {
            return this._mssPackage != null;
        }

        /// <summary>
        /// Gets and sets the property PackagingGroupId. The ID of a PackagingGroup.
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackagingGroupId
        {
            get { return this._packagingGroupId; }
            set { this._packagingGroupId = value; }
        }

        // Check to see if PackagingGroupId property is set
        internal bool IsSetPackagingGroupId()
        {
            return this._packagingGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

    }
}