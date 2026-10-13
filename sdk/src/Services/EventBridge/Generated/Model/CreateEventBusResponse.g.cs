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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the CreateEventBus operation.
    /// </summary>
    public partial class CreateEventBusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeadLetterConfig.
        /// </summary>
        public DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfig property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfig() => this.DeadLetterConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The event bus description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The ARN of the new event bus.
        /// </para>
        /// </summary>
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use to encrypt events
        /// on this event bus, if one has been specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-encryption.html">Data
        /// encryption in EventBridge</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The logging configuration settings for the event bus.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-bus-logs.html">Configuring
        /// logs for event buses</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;
    }
}
