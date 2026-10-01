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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The information about a processor in a channel flow.
    /// </summary>
    public partial class Processor
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The information about the type of processor and its identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessorConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ExecutionOrder. 
        /// <para>
        /// The sequence in which processors run. If you have multiple processors in a channel
        /// flow, message processing goes through each processor in the sequence. The value determines
        /// the sequence. At this point, we support only 1 processor within a flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3)]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionOrder property is set.
        /// </summary>
        internal bool IsSetExecutionOrder() => this.ExecutionOrder.HasValue;

        /// <summary>
        /// Gets and sets the property FallbackAction. 
        /// <para>
        /// Determines whether to continue with message processing or stop it in cases where communication
        /// with a processor fails. If a processor has a fallback action of <c>ABORT</c> and communication
        /// with it fails, the processor sets the message status to <c>FAILED</c> and does not
        /// send the message to any recipients. Note that if the last processor in the channel
        /// flow sequence has a fallback action of <c>CONTINUE</c> and communication with the
        /// processor fails, then the message is considered processed and sent to recipients of
        /// the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FallbackAction FallbackAction { get; set; }

        /// <summary>
        /// Checks to see if the FallbackAction property is set.
        /// </summary>
        internal bool IsSetFallbackAction() => this.FallbackAction != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
