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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeGlobalInferenceGateway operation.
    /// </summary>
    public partial class DescribeGlobalInferenceGatewayResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the global inference gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the global inference gateway was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointUrl. The URL that you use to invoke the global
        /// inference gateway. This value is set after the global inference gateway becomes `ACTIVE`.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the EndpointUrl property is set.
        /// </summary>
        internal bool IsSetEndpointUrl() => this.EndpointUrl != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. The Amazon Resource Name (ARN) of the
        /// IAM role that the global inference gateway assumes to access your SageMaker HyperPod
        /// clusters. You can't change the role after you create the global inference gateway.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the global inference gateway failed. SageMaker returns this value
        /// only when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the global inference gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the global inference gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Routing. 
        /// <para>
        /// The routing configuration of the global inference gateway.
        /// </para>
        /// </summary>
        public GlobalInferenceGatewayRouting Routing { get; set; }

        /// <summary>
        /// Checks to see if the Routing property is set.
        /// </summary>
        internal bool IsSetRouting() => this.Routing != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the global inference gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GlobalInferenceGatewayStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceName. The name of the VPC endpoint service
        /// to create an interface VPC endpoint (AWS PrivateLink) from, so that you can call `EndpointUrl`
        /// without going over the internet. This value is set after the global inference gateway
        /// becomes `ACTIVE`.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VpcEndpointServiceName { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointServiceName property is set.
        /// </summary>
        internal bool IsSetVpcEndpointServiceName() => this.VpcEndpointServiceName != null;
    }
}
