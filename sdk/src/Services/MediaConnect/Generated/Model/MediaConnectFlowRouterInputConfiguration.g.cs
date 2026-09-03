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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configuration settings for connecting a router input to a flow output.
    /// </summary>
    public partial class MediaConnectFlowRouterInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        /// The ARN of the flow to connect to.
        /// </para>
        /// </summary>
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property FlowOutputArn. 
        /// <para>
        /// The ARN of the flow output to connect to this router input.
        /// </para>
        /// </summary>
        public string FlowOutputArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowOutputArn property is set.
        /// </summary>
        internal bool IsSetFlowOutputArn() => this.FlowOutputArn != null;

        /// <summary>
        /// Gets and sets the property SourceTransitDecryption. 
        /// <para>
        /// The decryption configuration for the flow source when connected to this router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowTransitEncryption SourceTransitDecryption { get; set; }

        /// <summary>
        /// Checks to see if the SourceTransitDecryption property is set.
        /// </summary>
        internal bool IsSetSourceTransitDecryption() => this.SourceTransitDecryption != null;
    }
}
