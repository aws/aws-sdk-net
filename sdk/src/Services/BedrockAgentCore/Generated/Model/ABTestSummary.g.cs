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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Summary information about an A/B test.
    /// </summary>
    public partial class ABTestSummary
    {
        /// <summary>
        /// Gets and sets the property AbTestArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AbTestArn { get; set; }

        /// <summary>
        /// Checks to see if the AbTestArn property is set.
        /// </summary>
        internal bool IsSetAbTestArn() => this.AbTestArn != null;

        /// <summary>
        /// Gets and sets the property AbTestId. 
        /// <para>
        /// The unique identifier of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AbTestId { get; set; }

        /// <summary>
        /// Checks to see if the AbTestId property is set.
        /// </summary>
        internal bool IsSetAbTestId() => this.AbTestId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the A/B test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The execution status of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ABTestExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway used for traffic splitting.
        /// </para>
        /// </summary>
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ABTestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the A/B test was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
