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
    /// Sensitive data to mask in generated examples. Nothing is redacted unless you specify
    /// at least one identifier. Each character of a match is replaced with <c>*</c>, so a
    /// masked value keeps its length. If detection fails, the generation fails and no examples
    /// are written.
    /// </summary>
    public partial class RedactionConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomDataIdentifiers. 
        /// <para>
        /// Custom data identifiers to apply, up to 10. You can use custom identifiers without
        /// any managed identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<CustomDataIdentifier> CustomDataIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomDataIdentifier>() : null;

        /// <summary>
        /// Checks to see if the CustomDataIdentifiers property is set.
        /// </summary>
        internal bool IsSetCustomDataIdentifiers() => this.CustomDataIdentifiers != null && (this.CustomDataIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// The managed data identifiers to apply. These match the CloudWatch Logs managed data
        /// identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> Identifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Identifiers property is set.
        /// </summary>
        internal bool IsSetIdentifiers() => this.Identifiers != null && (this.Identifiers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
