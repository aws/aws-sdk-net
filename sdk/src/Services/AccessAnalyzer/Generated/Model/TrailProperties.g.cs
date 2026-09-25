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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains details about the CloudTrail trail being analyzed to generate a policy.
    /// </summary>
    public partial class TrailProperties
    {
        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        /// Possible values are <c>true</c> or <c>false</c>. If set to <c>true</c>, IAM Access
        /// Analyzer retrieves CloudTrail data from all regions to analyze and generate a policy.
        /// </para>
        /// </summary>
        public bool? AllRegions { get; set; }

        /// <summary>
        /// Checks to see if the AllRegions property is set.
        /// </summary>
        internal bool IsSetAllRegions() => this.AllRegions.HasValue;

        /// <summary>
        /// Gets and sets the property CloudTrailArn. 
        /// <para>
        /// Specifies the ARN of the trail. The format of a trail ARN is <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CloudTrailArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudTrailArn property is set.
        /// </summary>
        internal bool IsSetCloudTrailArn() => this.CloudTrailArn != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A list of regions to get CloudTrail data from and analyze to generate a policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
