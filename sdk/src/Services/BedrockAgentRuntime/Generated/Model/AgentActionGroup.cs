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
    /// Contains details of the inline agent's action group.
    /// </summary>
    public partial class AgentActionGroup
    {
        private ActionGroupExecutor _actionGroupExecutor;
        private string _actionGroupName;
        private APISchema _apiSchema;
        private string _description;
        private FunctionSchema _functionSchema;
        private ActionGroupSignature _parentActionGroupSignature;

        /// <summary>
        /// Gets and sets the property ActionGroupExecutor. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lambda function containing the business logic
        /// that is carried out upon invoking the action or the custom control method for handling
        /// the information elicited from the user. 
        /// </para>
        /// </summary>
        public ActionGroupExecutor ActionGroupExecutor
        {
            get { return this._actionGroupExecutor; }
            set { this._actionGroupExecutor = value; }
        }

        // Check to see if ActionGroupExecutor property is set
        internal bool IsSetActionGroupExecutor()
        {
            return this._actionGroupExecutor != null;
        }

        /// <summary>
        /// Gets and sets the property ActionGroupName. 
        /// <para>
        ///  The name of the action group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property ApiSchema. 
        /// <para>
        ///  Contains either details about the S3 object containing the OpenAPI schema for the
        /// action group or the JSON or YAML-formatted payload defining the schema. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-api-schema.html">Action
        /// group OpenAPI schemas</a>. 
        /// </para>
        /// </summary>
        public APISchema ApiSchema
        {
            get { return this._apiSchema; }
            set { this._apiSchema = value; }
        }

        // Check to see if ApiSchema property is set
        internal bool IsSetApiSchema()
        {
            return this._apiSchema != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the action group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionSchema. 
        /// <para>
        ///  Contains details about the function schema for the action group or the JSON or YAML-formatted
        /// payload defining the schema. 
        /// </para>
        /// </summary>
        public FunctionSchema FunctionSchema
        {
            get { return this._functionSchema; }
            set { this._functionSchema = value; }
        }

        // Check to see if FunctionSchema property is set
        internal bool IsSetFunctionSchema()
        {
            return this._functionSchema != null;
        }

        /// <summary>
        /// Gets and sets the property ParentActionGroupSignature. 
        /// <para>
        ///  To allow your agent to request the user for additional information when trying to
        /// complete a task, set this field to <c>AMAZON.UserInput</c>. You must leave the <c>description</c>,
        /// <c>apiSchema</c>, and <c>actionGroupExecutor</c> fields blank for this action group.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To allow your agent to generate, run, and troubleshoot code when trying to complete
        /// a task, set this field to <c>AMAZON.CodeInterpreter</c>. You must leave the <c>description</c>,
        /// <c>apiSchema</c>, and <c>actionGroupExecutor</c> fields blank for this action group.
        /// </para>
        ///  
        /// <para>
        /// During orchestration, if your agent determines that it needs to invoke an API in an
        /// action group, but doesn't have enough information to complete the API request, it
        /// will invoke this action group instead and return an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Observation.html">Observation</a>
        /// reprompting the user for more information.
        /// </para>
        /// </summary>
        public ActionGroupSignature ParentActionGroupSignature
        {
            get { return this._parentActionGroupSignature; }
            set { this._parentActionGroupSignature = value; }
        }

        // Check to see if ParentActionGroupSignature property is set
        internal bool IsSetParentActionGroupSignature()
        {
            return this._parentActionGroupSignature != null;
        }

    }
}