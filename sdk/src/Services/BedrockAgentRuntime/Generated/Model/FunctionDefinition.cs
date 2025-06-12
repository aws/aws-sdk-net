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
    /// Defines parameters that the agent needs to invoke from the user to complete the function.
    /// Corresponds to an action in an action group.
    /// </summary>
    public partial class FunctionDefinition
    {
        private string _description;
        private string _name;
        private Dictionary<string, ParameterDetail> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, ParameterDetail>() : null;
        private RequireConfirmation _requireConfirmation;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the function and its purpose. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1200)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  A name for the function. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  The parameters that the agent elicits from the user to fulfill the function. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ParameterDetail> Parameters
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
        /// Gets and sets the property RequireConfirmation. 
        /// <para>
        ///  Contains information if user confirmation is required to invoke the function. 
        /// </para>
        /// </summary>
        public RequireConfirmation RequireConfirmation
        {
            get { return this._requireConfirmation; }
            set { this._requireConfirmation = value; }
        }

        // Check to see if RequireConfirmation property is set
        internal bool IsSetRequireConfirmation()
        {
            return this._requireConfirmation != null;
        }

    }
}