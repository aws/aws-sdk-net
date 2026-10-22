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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// A set of filters by which to return Source Servers.
    /// </summary>
    public partial class DescribeSourceServersRequestFilters
    {
        /// <summary>
        /// Gets and sets the property HardwareId. 
        /// <para>
        /// An ID that describes the hardware of the Source Server. This is either an EC2 instance
        /// id, a VMware uuid or a mac address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string HardwareId { get; set; }

        /// <summary>
        /// Checks to see if the HardwareId property is set.
        /// </summary>
        internal bool IsSetHardwareId() => this.HardwareId != null;

        /// <summary>
        /// Gets and sets the property SourceServerIDs. 
        /// <para>
        /// An array of Source Servers IDs that should be returned. An empty array means all Source
        /// Servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> SourceServerIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceServerIDs property is set.
        /// </summary>
        internal bool IsSetSourceServerIDs() => this.SourceServerIDs != null && (this.SourceServerIDs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StagingAccountIDs. 
        /// <para>
        /// An array of staging account IDs that extended source servers belong to. An empty array
        /// means all source servers will be shown.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> StagingAccountIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StagingAccountIDs property is set.
        /// </summary>
        internal bool IsSetStagingAccountIDs() => this.StagingAccountIDs != null && (this.StagingAccountIDs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
