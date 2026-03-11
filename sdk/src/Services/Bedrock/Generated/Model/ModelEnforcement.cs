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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Model-specific information for the enforced guardrail configuration.
    /// </summary>
    public partial class ModelEnforcement
    {
        private List<string> _excludedModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includedModels = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ExcludedModels. 
        /// <para>
        /// Models to exclude from enforcement of the guardrail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<string> ExcludedModels
        {
            get { return this._excludedModels; }
            set { this._excludedModels = value; }
        }

        // Check to see if ExcludedModels property is set
        internal bool IsSetExcludedModels()
        {
            return this._excludedModels != null && (this._excludedModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludedModels. 
        /// <para>
        /// Models to enforce the guardrail on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> IncludedModels
        {
            get { return this._includedModels; }
            set { this._includedModels = value; }
        }

        // Check to see if IncludedModels property is set
        internal bool IsSetIncludedModels()
        {
            return this._includedModels != null && (this._includedModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}