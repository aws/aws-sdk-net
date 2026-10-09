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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceQuotaWarnings operation. Lists the
    /// service quota warnings for the plans that you can access. Region switch creates a
    /// warning when the applied quota value in one Region of a plan is lower than the value
    /// required for the matching resource in another Region or account in the plan. <para>
    /// Returns the warnings for the plans that you own and for plans that are shared with
    /// your account through AWS Resource Access Manager (AWS RAM). To return warnings for
    /// specific plans, provide a list of plan Amazon Resource Names (ARNs). Region switch
    /// ignores any plan ARN that you can't access. If you don't provide any plan ARNs, Region
    /// switch returns the warnings for all of your accessible plans. </para>
    /// </summary>
    public partial class ListServiceQuotaWarningsRequest : AmazonARCRegionswitchRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with this call. Valid values are <c>1</c>
        /// to <c>100</c>. If you don't specify a value, the operation returns up to the maximum
        /// number of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <c>nextToken</c> response in the previous request. If you did, it indicates that
        /// more output is available. Set this parameter to the value provided by the previous
        /// call's <c>nextToken</c> response to request the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PlanArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the plans to return service quota warnings for.
        /// You can specify up to 100 plan ARNs. Region switch ignores any plan ARN that you can't
        /// access. If you omit this parameter, Region switch returns the warnings for all of
        /// your accessible plans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> PlanArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PlanArns property is set.
        /// </summary>
        internal bool IsSetPlanArns() => this.PlanArns != null && (this.PlanArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
