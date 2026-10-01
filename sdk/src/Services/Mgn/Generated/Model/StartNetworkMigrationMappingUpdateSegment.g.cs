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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A segment update to apply during a mapping update operation.
    /// </summary>
    public partial class StartNetworkMigrationMappingUpdateSegment
    {
        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// The updated scope tags for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 40)]
        public Dictionary<string, string> ScopeTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ScopeTags property is set.
        /// </summary>
        internal bool IsSetScopeTags() => this.ScopeTags != null && (this.ScopeTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The ID of the segment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string SegmentID { get; set; }

        /// <summary>
        /// Checks to see if the SegmentID property is set.
        /// </summary>
        internal bool IsSetSegmentID() => this.SegmentID != null;

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The updated target AWS account for the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string TargetAccount { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccount property is set.
        /// </summary>
        internal bool IsSetTargetAccount() => this.TargetAccount != null;
    }
}
