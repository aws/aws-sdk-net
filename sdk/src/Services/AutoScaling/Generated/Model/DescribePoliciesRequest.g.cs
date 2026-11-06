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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePolicies operation. Gets information about
    /// the scaling policies in the account and Region.
    /// </summary>
    public partial class DescribePoliciesRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property IncludeManagedResources. 
        /// <para>
        ///  Specifies whether to include scaling policies for managed Auto Scaling groups in
        /// the response. When set to <c>true</c> (default), the response includes scaling policies
        /// for managed Auto Scaling groups. 
        /// </para>
        /// </summary>
        public bool? IncludeManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeManagedResources property is set.
        /// </summary>
        internal bool IsSetIncludeManagedResources() => this.IncludeManagedResources.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to be returned with each call. The default value is <c>50</c>
        /// and the maximum value is <c>100</c>.
        /// </para>
        ///  
        /// <para>
        /// A response can contain fewer items than the value specified by <c>MaxRecords</c>,
        /// even when more items are available. To retrieve the additional items, use the <c>NextToken</c>
        /// value in a subsequent call rather than relying on the number of items in the response.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// The names of one or more policies. If you omit this property, all policies are described.
        /// If a group name is provided, the results are limited to that group. If you specify
        /// an unknown policy name, it is ignored with no error.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 50 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolicyNames property is set.
        /// </summary>
        internal bool IsSetPolicyNames() => this.PolicyNames != null && (this.PolicyNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyTypes. 
        /// <para>
        /// One or more policy types. The valid values are <c>SimpleScaling</c>, <c>StepScaling</c>,
        /// <c>TargetTrackingScaling</c>, and <c>PredictiveScaling</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolicyTypes property is set.
        /// </summary>
        internal bool IsSetPolicyTypes() => this.PolicyTypes != null && (this.PolicyTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
