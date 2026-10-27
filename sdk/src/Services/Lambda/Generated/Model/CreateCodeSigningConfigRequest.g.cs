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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeSigningConfig operation. Creates a code
    /// signing configuration. A <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">code
    /// signing configuration</a> defines a list of allowed signing profiles and defines the
    /// code-signing validation policy (action to be taken if deployment validation checks
    /// fail).
    /// </summary>
    public partial class CreateCodeSigningConfigRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedPublishers. 
        /// <para>
        /// Signing profiles for this code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllowedPublishers AllowedPublishers { get; set; }

        /// <summary>
        /// Checks to see if the AllowedPublishers property is set.
        /// </summary>
        internal bool IsSetAllowedPublishers() => this.AllowedPublishers != null;

        /// <summary>
        /// Gets and sets the property CodeSigningPolicies. 
        /// <para>
        /// The code signing policies define the actions to take if the validation checks fail.
        /// 
        /// </para>
        /// </summary>
        public CodeSigningPolicies CodeSigningPolicies { get; set; }

        /// <summary>
        /// Checks to see if the CodeSigningPolicies property is set.
        /// </summary>
        internal bool IsSetCodeSigningPolicies() => this.CodeSigningPolicies != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive name for this code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to add to the code signing configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
