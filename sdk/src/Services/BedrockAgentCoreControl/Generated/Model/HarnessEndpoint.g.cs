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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Representation of a harness endpoint. An endpoint is a named, stable reference to
    /// a specific version of a harness that callers invoke, allowing the underlying version
    /// to be updated without changing how the agent is invoked.
    /// </summary>
    public partial class HarnessEndpoint
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the endpoint was created.
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
        /// The description of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the endpoint's last create or update operation failed.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness that the endpoint belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessId { get; set; }

        /// <summary>
        /// Checks to see if the HarnessId property is set.
        /// </summary>
        internal bool IsSetHarnessId() => this.HarnessId != null;

        /// <summary>
        /// Gets and sets the property HarnessName. 
        /// <para>
        /// The name of the harness that the endpoint belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessName { get; set; }

        /// <summary>
        /// Checks to see if the HarnessName property is set.
        /// </summary>
        internal bool IsSetHarnessName() => this.HarnessName != null;

        /// <summary>
        /// Gets and sets the property LiveVersion. 
        /// <para>
        /// The harness version that the endpoint is currently serving.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string LiveVersion { get; set; }

        /// <summary>
        /// Checks to see if the LiveVersion property is set.
        /// </summary>
        internal bool IsSetLiveVersion() => this.LiveVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarnessEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// The harness version that the endpoint points to. While an update is in progress, this
        /// can differ from the live version until the endpoint finishes transitioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the endpoint was last updated.
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
