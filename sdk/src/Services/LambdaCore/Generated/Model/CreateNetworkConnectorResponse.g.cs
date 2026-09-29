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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// This is the response object from the CreateNetworkConnector operation.
    /// </summary>
    public partial class CreateNetworkConnectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The network configuration of the connector, including VPC subnets and security groups.
        /// </para>
        /// </summary>
        public NetworkConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OperatorRole. 
        /// <para>
        /// The ARN of the IAM role that Lambda uses to manage the underlying ENI resources for
        /// this connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string OperatorRole { get; set; }

        /// <summary>
        /// Checks to see if the OperatorRole property is set.
        /// </summary>
        internal bool IsSetOperatorRole() => this.OperatorRole != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the network connector.
        /// </para>
        /// </summary>
        public NetworkConnectorState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
