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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// This is the response object from the RunMicrovm operation.
    /// </summary>
    public partial class RunMicrovmResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EgressNetworkConnectors. 
        /// <para>
        /// The list of egress network connectors configured for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> EgressNetworkConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EgressNetworkConnectors property is set.
        /// </summary>
        internal bool IsSetEgressNetworkConnectors() => this.EgressNetworkConnectors != null && (this.EgressNetworkConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The HTTPS endpoint URL for communicating with the MicroVM. Include a valid authentication
        /// token in the X-aws-proxy-auth header when sending requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM execution role assumed by the MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property IdlePolicy. 
        /// <para>
        /// The idle policy configuration of the MicroVM.
        /// </para>
        /// </summary>
        public IdlePolicy IdlePolicy { get; set; }

        /// <summary>
        /// Checks to see if the IdlePolicy property is set.
        /// </summary>
        internal bool IsSetIdlePolicy() => this.IdlePolicy != null;

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image used to run this MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image used to run this MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersion property is set.
        /// </summary>
        internal bool IsSetImageVersion() => this.ImageVersion != null;

        /// <summary>
        /// Gets and sets the property IngressNetworkConnectors. 
        /// <para>
        /// The list of ingress network connectors configured for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> IngressNetworkConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IngressNetworkConnectors property is set.
        /// </summary>
        internal bool IsSetIngressNetworkConnectors() => this.IngressNetworkConnectors != null && (this.IngressNetworkConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaximumDurationInSeconds. 
        /// <para>
        /// The maximum duration in seconds that the MicroVM can exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaximumDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetMaximumDurationInSeconds() => this.MaximumDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MicrovmId. 
        /// <para>
        /// The unique identifier of the MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MicrovmId { get; set; }

        /// <summary>
        /// Checks to see if the MicrovmId property is set.
        /// </summary>
        internal bool IsSetMicrovmId() => this.MicrovmId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the MicroVM first started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current lifecycle state of the MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MicrovmState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for why the MicroVM is in the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property TerminatedAt. 
        /// <para>
        /// The timestamp when the MicroVM terminated.
        /// </para>
        /// </summary>
        public DateTime? TerminatedAt { get; set; }

        /// <summary>
        /// Checks to see if the TerminatedAt property is set.
        /// </summary>
        internal bool IsSetTerminatedAt() => this.TerminatedAt.HasValue;
    }
}
