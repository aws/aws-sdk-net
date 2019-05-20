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
    /// The endpoint URL used to access an Asset using one PackagingConfiguration.
    /// </summary>
    public partial class EgressEndpoint
    {
        private string _packagingConfigurationId;
        private string _url;

        /// <summary>
        /// Gets and sets the property PackagingConfigurationId. The ID of the PackagingConfiguration
        /// being applied to the Asset.
        /// </summary>
        public string PackagingConfigurationId
        {
            get { return this._packagingConfigurationId; }
            set { this._packagingConfigurationId = value; }
        }

        // Check to see if PackagingConfigurationId property is set
        internal bool IsSetPackagingConfigurationId()
        {
            return this._packagingConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. The URL of the parent manifest for the repackaged
        /// Asset.
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}