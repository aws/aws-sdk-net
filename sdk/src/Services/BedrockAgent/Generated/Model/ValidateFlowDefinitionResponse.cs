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
    /// This is the response object from the ValidateFlowDefinition operation.
    /// </summary>
    public partial class ValidateFlowDefinitionResponse : AmazonWebServiceResponse
    {
        private List<FlowValidation> _validations = AWSConfigs.InitializeCollections ? new List<FlowValidation>() : null;

        /// <summary>
        /// Gets and sets the property Validations. 
        /// <para>
        /// Contains an array of objects, each of which contains an error identified by validation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<FlowValidation> Validations
        {
            get { return this._validations; }
            set { this._validations = value; }
        }

        // Check to see if Validations property is set
        internal bool IsSetValidations()
        {
            return this._validations != null && (this._validations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}