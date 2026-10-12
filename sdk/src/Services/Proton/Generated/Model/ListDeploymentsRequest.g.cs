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
    /// Container for the parameters to the ListDeployments operation. List deployments. You
    /// can filter the result list by environment, service, or a single service instance.
    /// </summary>
    public partial class ListDeploymentsRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of a component for result list filtering. Proton returns deployments associated
        /// with that component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of an environment for result list filtering. Proton returns deployments associated
        /// with the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of deployments to list.
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
        /// A token that indicates the location of the next deployment in the array of deployment,
        /// after the list of deployment that was previously requested.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of a service instance for result list filtering. Proton returns the deployments
        /// associated with the service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstanceName property is set.
        /// </summary>
        internal bool IsSetServiceInstanceName() => this.ServiceInstanceName != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of a service for result list filtering. Proton returns deployments associated
        /// with service instances of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
