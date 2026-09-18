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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The configuration of the connection.
    /// </summary>
    public partial class FlowConnectionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Conditional. 
        /// <para>
        /// The configuration of a connection originating from a Condition node.
        /// </para>
        /// </summary>
        public FlowConditionalConnectionConfiguration Conditional { get; set; }

        /// <summary>
        /// Checks to see if the Conditional property is set.
        /// </summary>
        internal bool IsSetConditional() => this.Conditional != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The configuration of a connection originating from a node that isn't a Condition node.
        /// </para>
        /// </summary>
        public FlowDataConnectionConfiguration Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;
    }
}
