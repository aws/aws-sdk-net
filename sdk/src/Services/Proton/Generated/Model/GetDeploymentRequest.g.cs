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
    /// Container for the parameters to the GetDeployment operation. Get detailed data for
    /// a deployment.
    /// </summary>
    public partial class GetDeploymentRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of a component that you want to get the detailed data for.
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
        /// The name of a environment that you want to get the detailed data for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the deployment that you want to get the detailed data for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance associated with the given deployment ID. <c>serviceName</c>
        /// must be specified to identify the service instance.
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
        /// The name of the service associated with the given deployment ID.
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
