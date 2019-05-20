/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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

    }
}