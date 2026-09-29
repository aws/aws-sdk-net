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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The result of a tool description recommendation, containing optimized descriptions.
    /// </summary>
    public partial class ToolDescriptionRecommendationResult
    {
        /// <summary>
        /// Gets and sets the property ConfigurationBundle. 
        /// <para>
        /// The configuration bundle containing the recommended tool descriptions, if the input
        /// was sourced from a configuration bundle.
        /// </para>
        /// </summary>
        public RecommendationResultConfigurationBundle ConfigurationBundle { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationBundle property is set.
        /// </summary>
        internal bool IsSetConfigurationBundle() => this.ConfigurationBundle != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code if the recommendation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message if the recommendation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The list of tools with their recommended descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ToolDescriptionOutput> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolDescriptionOutput>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
