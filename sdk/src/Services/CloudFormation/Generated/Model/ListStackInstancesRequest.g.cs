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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListStackInstances operation. Returns summary
    /// information about stack instances that are associated with the specified StackSet.
    /// You can filter for stack instances that are associated with a specific Amazon Web
    /// Services account name or Region, or that have a specific status.
    /// </summary>
    public partial class ListStackInstancesRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs { get; set; }

        /// <summary>
        /// Checks to see if the CallAs property is set.
        /// </summary>
        internal bool IsSetCallAs() => this.CallAs != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filter to apply to stack instances
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<StackInstanceFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<StackInstanceFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StackInstanceAccount. 
        /// <para>
        /// The name of the Amazon Web Services account that you want to list stack instances
        /// for.
        /// </para>
        /// </summary>
        public string StackInstanceAccount { get; set; }

        /// <summary>
        /// Checks to see if the StackInstanceAccount property is set.
        /// </summary>
        internal bool IsSetStackInstanceAccount() => this.StackInstanceAccount != null;

        /// <summary>
        /// Gets and sets the property StackInstanceRegion. 
        /// <para>
        /// The name of the Region where you want to list stack instances.
        /// </para>
        /// </summary>
        public string StackInstanceRegion { get; set; }

        /// <summary>
        /// Checks to see if the StackInstanceRegion property is set.
        /// </summary>
        internal bool IsSetStackInstanceRegion() => this.StackInstanceRegion != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the StackSet that you want to list stack instances for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;
    }
}
