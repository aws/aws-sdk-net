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
    /// Container for the parameters to the DeleteFlowVersion operation.
    /// Deletes a version of a flow.
    /// </summary>
    public partial class DeleteFlowVersionRequest : AmazonBedrockAgentRequest
    {
        private string _flowIdentifier;
        private string _flowVersion;
        private bool? _skipResourceInUseCheck;

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow whose version that you want to delete
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowIdentifier
        {
            get { return this._flowIdentifier; }
            set { this._flowIdentifier = value; }
        }

        // Check to see if FlowIdentifier property is set
        internal bool IsSetFlowIdentifier()
        {
            return this._flowIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FlowVersion. 
        /// <para>
        /// The version of the flow that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowVersion
        {
            get { return this._flowVersion; }
            set { this._flowVersion = value; }
        }

        // Check to see if FlowVersion property is set
        internal bool IsSetFlowVersion()
        {
            return this._flowVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// By default, this value is <c>false</c> and deletion is stopped if the resource is
        /// in use. If you set it to <c>true</c>, the resource will be deleted even if the resource
        /// is in use.
        /// </para>
        /// </summary>
        public bool? SkipResourceInUseCheck
        {
            get { return this._skipResourceInUseCheck; }
            set { this._skipResourceInUseCheck = value; }
        }

        // Check to see if SkipResourceInUseCheck property is set
        internal bool IsSetSkipResourceInUseCheck()
        {
            return this._skipResourceInUseCheck.HasValue; 
        }

    }
}