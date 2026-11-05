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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeploymentInstances operation. <note> <para>
    /// The newer <c>BatchGetDeploymentTargets</c> should be used instead because it works
    /// with all compute types. <c>ListDeploymentInstances</c> throws an exception if it is
    /// used with a compute platform other than EC2/On-premises or Lambda. </para> </note>
    /// <para> Lists the instance for a deployment associated with the user or Amazon Web
    /// Services account. </para>
    /// </summary>
    public partial class ListDeploymentInstancesRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property InstanceStatusFilter. 
        /// <para>
        /// A subset of instances to list by status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pending</c>: Include those instances with pending deployments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c>: Include those instances where deployments are still in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Succeeded</c>: Include those instances with successful deployments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: Include those instances with failed deployments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Skipped</c>: Include those instances with skipped deployments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unknown</c>: Include those instances with deployments in an unknown state.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceStatusFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceStatusFilter property is set.
        /// </summary>
        internal bool IsSetInstanceStatusFilter() => this.InstanceStatusFilter != null && (this.InstanceStatusFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceTypeFilter. 
        /// <para>
        /// The set of instances in a blue/green deployment, either those in the original environment
        /// ("BLUE") or those in the replacement environment ("GREEN"), for which you want to
        /// view instance information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypeFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeFilter property is set.
        /// </summary>
        internal bool IsSetInstanceTypeFilter() => this.InstanceTypeFilter != null && (this.InstanceTypeFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier returned from the previous list deployment instances call. It can be
        /// used to return the next set of deployment instances in the list.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
