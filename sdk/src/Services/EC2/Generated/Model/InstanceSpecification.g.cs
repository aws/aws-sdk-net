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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The instance details to specify which volumes should be snapshotted.
    /// </summary>
    public partial class InstanceSpecification
    {
        /// <summary>
        /// Gets and sets the property ExcludeBootVolume. 
        /// <para>
        /// Excludes the root volume from being snapshotted.
        /// </para>
        /// </summary>
        public bool? ExcludeBootVolume { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeBootVolume property is set.
        /// </summary>
        internal bool IsSetExcludeBootVolume() => this.ExcludeBootVolume.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludeDataVolumeIds. 
        /// <para>
        /// The IDs of the data (non-root) volumes to exclude from the multi-volume snapshot set.
        /// If you specify the ID of the root volume, the request fails. To exclude the root volume,
        /// use <b>ExcludeBootVolume</b>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 40 volume IDs per request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludeDataVolumeIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeDataVolumeIds property is set.
        /// </summary>
        internal bool IsSetExcludeDataVolumeIds() => this.ExcludeDataVolumeIds != null && (this.ExcludeDataVolumeIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance to specify which volumes should be snapshotted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
