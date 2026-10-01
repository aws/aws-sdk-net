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

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Container for the parameters to the ListRules operation. Lists the Recycle Bin retention
    /// rules in the Region.
    /// </summary>
    public partial class ListRulesRequest : AmazonRecycleBinRequest
    {
        /// <summary>
        /// Gets and sets the property ExcludeResourceTags. 
        /// <para>
        /// [Region-level retention rules only] Information about the exclusion tags used to identify
        /// resources that are to be excluded, or ignored, by the retention rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<ResourceTag> ExcludeResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ExcludeResourceTags property is set.
        /// </summary>
        internal bool IsSetExcludeResourceTags() => this.ExcludeResourceTags != null && (this.ExcludeResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LockState. 
        /// <para>
        /// The lock state of the retention rules to list. Only retention rules with the specified
        /// lock state are returned.
        /// </para>
        /// </summary>
        public LockState LockState { get; set; }

        /// <summary>
        /// Checks to see if the LockState property is set.
        /// </summary>
        internal bool IsSetLockState() => this.LockState != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// [Tag-level retention rules only] Information about the resource tags used to identify
        /// resources that are retained by the retention rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type retained by the retention rule. Only retention rules that retain
        /// the specified resource type are listed. Currently, only EBS volumes, EBS snapshots,
        /// and EBS-backed AMIs are supported.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To list retention rules that retain EBS volumes, specify <c>EBS_VOLUME</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list retention rules that retain EBS snapshots, specify <c>EBS_SNAPSHOT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list retention rules that retain EBS-backed AMIs, specify <c>EC2_IMAGE</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
