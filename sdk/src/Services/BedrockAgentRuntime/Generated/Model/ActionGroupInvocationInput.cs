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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about the action group being invoked. For more information about
    /// the possible structures, see the InvocationInput tab in <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/trace-orchestration.html">OrchestrationTrace</a>
    /// in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class ActionGroupInvocationInput
    {
        private string _actionGroupName;
        private string _apiPath;
        private string _function;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private RequestBody _requestBody;
        private string _verb;

        /// <summary>
        /// Gets and sets the property ActionGroupName. 
        /// <para>
        /// The name of the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ActionGroupName
        {
            get { return this._actionGroupName; }
            set { this._actionGroupName = value; }
        }

        // Check to see if ActionGroupName property is set
        internal bool IsSetActionGroupName()
        {
            return this._actionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ApiPath. 
        /// <para>
        /// The path to the API to call, based off the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ApiPath
        {
            get { return this._apiPath; }
            set { this._apiPath = value; }
        }

        // Check to see if ApiPath property is set
        internal bool IsSetApiPath()
        {
            return this._apiPath != null;
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function in the action group to call.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters in the Lambda input event.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// The parameters in the request body for the Lambda input event.
        /// </para>
        /// </summary>
        public RequestBody RequestBody
        {
            get { return this._requestBody; }
            set { this._requestBody = value; }
        }

        // Check to see if RequestBody property is set
        internal bool IsSetRequestBody()
        {
            return this._requestBody != null;
        }

        /// <summary>
        /// Gets and sets the property Verb. 
        /// <para>
        /// The API method being used, based off the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Verb
        {
            get { return this._verb; }
            set { this._verb = value; }
        }

        // Check to see if Verb property is set
        internal bool IsSetVerb()
        {
            return this._verb != null;
        }

    }
}