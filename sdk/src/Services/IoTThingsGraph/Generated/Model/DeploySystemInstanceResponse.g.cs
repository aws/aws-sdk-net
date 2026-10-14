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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// This is the response object from the DeploySystemInstance operation.
    /// </summary>
    public partial class DeploySystemInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GreengrassDeploymentId. 
        /// <para>
        /// The ID of the Greengrass deployment used to deploy the system instance.
        /// </para>
        /// </summary>
        public string GreengrassDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the GreengrassDeploymentId property is set.
        /// </summary>
        internal bool IsSetGreengrassDeploymentId() => this.GreengrassDeploymentId != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// An object that contains summary information about a system instance that was deployed.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SystemInstanceSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;
    }
}
