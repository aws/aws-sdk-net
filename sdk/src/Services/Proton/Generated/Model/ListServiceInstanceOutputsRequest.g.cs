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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceInstanceOutputs operation. Get a list
    /// service of instance Infrastructure as Code (IaC) outputs.
    /// </summary>
    public partial class ListServiceInstanceOutputsRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment whose outputs you want.
        /// </para>
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next output in the array of outputs, after
        /// the list of outputs that was previously requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 0)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance whose outputs you want.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstanceName property is set.
        /// </summary>
        internal bool IsSetServiceInstanceName() => this.ServiceInstanceName != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <c>serviceInstanceName</c> is associated to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
