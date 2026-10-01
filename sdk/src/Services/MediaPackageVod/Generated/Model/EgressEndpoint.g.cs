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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The endpoint URL used to access an Asset using one PackagingConfiguration.
    /// </summary>
    public partial class EgressEndpoint
    {
        /// <summary>
        /// Gets and sets the property PackagingConfigurationId. The ID of the PackagingConfiguration
        /// being applied to the Asset.
        /// </summary>
        public string PackagingConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the PackagingConfigurationId property is set.
        /// </summary>
        internal bool IsSetPackagingConfigurationId() => this.PackagingConfigurationId != null;

        /// <summary>
        /// Gets and sets the property Status. The current processing status of the asset used
        /// for the packaging configuration. The status can be either QUEUED, PROCESSING, PLAYABLE,
        /// or FAILED. Status information won't be available for most assets ingested before 2021-09-30.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Url. The URL of the parent manifest for the repackaged
        /// Asset.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
