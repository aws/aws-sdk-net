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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the PutCaseEventConfiguration operation. Adds case
    /// event publishing configuration. For a complete list of fields you can add to the event
    /// message, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-fields.html">Create
    /// case fields</a> in the <i>Amazon Connect Administrator Guide</i>
    /// </summary>
    public partial class PutCaseEventConfigurationRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EventBridge. 
        /// <para>
        /// Configuration to enable EventBridge case event delivery and determine what data is
        /// delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventBridgeConfiguration EventBridge { get; set; }

        /// <summary>
        /// Checks to see if the EventBridge property is set.
        /// </summary>
        internal bool IsSetEventBridge() => this.EventBridge != null;
    }
}
