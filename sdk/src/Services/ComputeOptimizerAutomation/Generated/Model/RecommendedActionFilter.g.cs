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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// A filter used to narrow down recommended action results based on specific criteria.
    /// If a filter has more than one value, a recommended action matches the filter when
    /// it matches any of the values. If you specify more than one filter, a recommended action
    /// must match all of the filters.
    /// </summary>
    public partial class RecommendedActionFilter
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter field to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendedActionFilterName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The list of values to filter by for the specified filter name. Wildcards aren't supported.
        /// An asterisk (<c>*</c>) or a question mark (<c>?</c>) in a value matches only that
        /// literal character. How a value is matched depends on the filter name:
        /// </para>
        ///  <dl> <dt>ResourceType, RecommendedActionType, ResourceId, and AccountId</dt> <dd>
        /// 
        /// <para>
        /// The value that you specify must exactly match the corresponding field of the recommended
        /// action, including case. For example, specify <c>EbsVolume</c>, not <c>ebsvolume</c>.
        /// </para>
        ///  </dd> <dt>CurrentResourceDetailsEbsVolumeType</dt> <dd> 
        /// <para>
        /// Matches when the value appears anywhere in the current resource details of the recommended
        /// action, which include the volume type, size, IOPS, and throughput. Matching is case
        /// sensitive, and a partial value also matches. For example, <c>gp</c> matches both <c>gp2</c>
        /// and <c>gp3</c> volumes, and <c>100</c> matches any volume whose size, IOPS, or throughput
        /// contains 100. To filter by volume type, specify the complete volume type, such as
        /// <c>gp3</c> or <c>io2</c>.
        /// </para>
        ///  </dd> <dt>ResourceTagsKey and ResourceTagsValue</dt> <dd> 
        /// <para>
        /// Matches when the value appears anywhere in the tags of the resource. Both filter names
        /// search every tag key and tag value. Matching is case sensitive, and a partial value
        /// also matches. For example, a <c>ResourceTagsKey</c> value of <c>test</c> matches a
        /// resource that has a tag value of <c>test</c>.
        /// </para>
        ///  </dd> <dt>LookBackPeriodInDays</dt> <dd> 
        /// <para>
        /// Matches when the lookback period of the recommended action equals the value. Specify
        /// a number of days, such as <c>14</c>.
        /// </para>
        ///  </dd> <dt>RestartNeeded</dt> <dd> 
        /// <para>
        /// Matches recommended actions based on whether implementing them requires a resource
        /// restart. Specify <c>true</c> or <c>false</c>.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
