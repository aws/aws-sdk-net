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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains the text for the generated policy and its details.
    /// </summary>
    public partial class GeneratedPolicyResult
    {
        /// <summary>
        /// Gets and sets the property GeneratedPolicies. 
        /// <para>
        /// The text to use as the content for the new policy. The policy is created using the
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">CreatePolicy</a>
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GeneratedPolicy> GeneratedPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<GeneratedPolicy>() : null;

        /// <summary>
        /// Checks to see if the GeneratedPolicies property is set.
        /// </summary>
        internal bool IsSetGeneratedPolicies() => this.GeneratedPolicies != null && (this.GeneratedPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A <c>GeneratedPolicyProperties</c> object that contains properties of the generated
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeneratedPolicyProperties Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;
    }
}
