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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServiceDeployments operation.
    /// Describes one or more of your service deployments.
    /// 
    ///  
    /// <para>
    /// A service deployment happens when you release a software update for the service. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-deployment.html">View
    /// service history using Amazon ECS service deployments</a>.
    /// </para>
    /// </summary>
    public partial class DescribeServiceDeploymentsRequest : AmazonECSRequest
    {
        private List<string> _serviceDeploymentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ServiceDeploymentArns. 
        /// <para>
        /// The ARN of the service deployment.
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of 20 ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ServiceDeploymentArns
        {
            get { return this._serviceDeploymentArns; }
            set { this._serviceDeploymentArns = value; }
        }

        // Check to see if ServiceDeploymentArns property is set
        internal bool IsSetServiceDeploymentArns()
        {
            return this._serviceDeploymentArns != null && (this._serviceDeploymentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}