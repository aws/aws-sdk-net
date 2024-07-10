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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private FlowConditionalConnectionConfiguration _conditional;
        private FlowDataConnectionConfiguration _data;

        /// <summary>
        /// Gets and sets the property Conditional. 
        /// <para>
        /// The configuration of a connection originating from a Condition node.
        /// </para>
        /// </summary>
        public FlowConditionalConnectionConfiguration Conditional
        {
            get { return this._conditional; }
            set { this._conditional = value; }
        }

        // Check to see if Conditional property is set
        internal bool IsSetConditional()
        {
            return this._conditional != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The configuration of a connection originating from a node that isn't a Condition node.
        /// </para>
        /// </summary>
        public FlowDataConnectionConfiguration Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}