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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The information about a processor in a channel flow.
    /// </summary>
    public partial class Processor
    {
        private ProcessorConfiguration _configuration;
        private int? _executionOrder;
        private FallbackAction _fallbackAction;
        private string _name;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The information about the type of processor and its identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionOrder. 
        /// <para>
        /// The sequence in which processors run. If you have multiple processors in a channel
        /// flow, message processing goes through each processor in the sequence. The value determines
        /// the sequence. At this point, we support only 1 processor within a flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public int ExecutionOrder
        {
            get { return this._executionOrder.GetValueOrDefault(); }
            set { this._executionOrder = value; }
        }

        // Check to see if ExecutionOrder property is set
        internal bool IsSetExecutionOrder()
        {
            return this._executionOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FallbackAction. 
        /// <para>
        /// Determines whether to continue with message processing or stop it in cases where communication
        /// with a processor fails. If a processor has a fallback action of <code>ABORT</code>
        /// and communication with it fails, the processor sets the message status to <code>FAILED</code>
        /// and does not send the message to any recipients. Note that if the last processor in
        /// the channel flow sequence has a fallback action of <code>CONTINUE</code> and communication
        /// with the processor fails, then the message is considered processed and sent to recipients
        /// of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FallbackAction FallbackAction
        {
            get { return this._fallbackAction; }
            set { this._fallbackAction = value; }
        }

        // Check to see if FallbackAction property is set
        internal bool IsSetFallbackAction()
        {
            return this._fallbackAction != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}