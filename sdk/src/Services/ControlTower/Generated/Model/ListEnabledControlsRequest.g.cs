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

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the ListEnabledControls operation. Lists the controls
    /// enabled by Amazon Web Services Control Tower on the specified organizational unit
    /// and the accounts it contains. For usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
    /// <i>Controls Reference Guide</i> </a>.
    /// </summary>
    public partial class ListEnabledControlsRequest : AmazonControlTowerRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// An input filter for the <c>ListEnabledControls</c> API that lets you select the types
        /// of control operations to view.
        /// </para>
        /// </summary>
        public EnabledControlFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property IncludeChildren. 
        /// <para>
        /// Specifies whether to include enabled controls from child organizational units and
        /// child accounts in the response.
        /// </para>
        /// </summary>
        public bool? IncludeChildren { get; set; }

        /// <summary>
        /// Checks to see if the IncludeChildren property is set.
        /// </summary>
        internal bool IsSetIncludeChildren() => this.IncludeChildren.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// How many results to return per API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to continue the list from a previous API call with the same parameters.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The ARN of the target. The value depends on the target type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Organizational unit (OU) – Specify the ARN of the OU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Account – Specify the ARN of the account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information on how to find the <c>targetIdentifier</c>, see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;
    }
}
