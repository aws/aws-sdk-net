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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS target resource aggregation.
    /// </summary>
    public partial class CisTargetResourceAggregation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for the CIS target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform for the CIS target resource.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The scan ARN for the CIS target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanArn property is set.
        /// </summary>
        internal bool IsSetScanArn() => this.ScanArn != null;

        /// <summary>
        /// Gets and sets the property StatusCounts. 
        /// <para>
        /// The target resource status counts.
        /// </para>
        /// </summary>
        public StatusCounts StatusCounts { get; set; }

        /// <summary>
        /// Checks to see if the StatusCounts property is set.
        /// </summary>
        internal bool IsSetStatusCounts() => this.StatusCounts != null;

        /// <summary>
        /// Gets and sets the property TargetResourceId. 
        /// <para>
        /// The ID of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1024)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceId property is set.
        /// </summary>
        internal bool IsSetTargetResourceId() => this.TargetResourceId != null;

        /// <summary>
        /// Gets and sets the property TargetResourceTags. 
        /// <para>
        /// The tag for the target resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public Dictionary<string, List<string>> TargetResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the TargetResourceTags property is set.
        /// </summary>
        internal bool IsSetTargetResourceTags() => this.TargetResourceTags != null && (this.TargetResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetStatus. 
        /// <para>
        /// The status of the target resource.
        /// </para>
        /// </summary>
        public CisTargetStatus TargetStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetStatus property is set.
        /// </summary>
        internal bool IsSetTargetStatus() => this.TargetStatus != null;

        /// <summary>
        /// Gets and sets the property TargetStatusReason. 
        /// <para>
        /// The reason for the target resource.
        /// </para>
        /// </summary>
        public CisTargetStatusReason TargetStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the TargetStatusReason property is set.
        /// </summary>
        internal bool IsSetTargetStatusReason() => this.TargetStatusReason != null;
    }
}
