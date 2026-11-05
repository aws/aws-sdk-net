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
    /// Details about a <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">Code
    /// signing configuration</a>.
    /// </summary>
    public partial class CodeSigningConfig
    {
        /// <summary>
        /// Gets and sets the property AllowedPublishers. 
        /// <para>
        /// List of allowed publishers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllowedPublishers AllowedPublishers { get; set; }

        /// <summary>
        /// Checks to see if the AllowedPublishers property is set.
        /// </summary>
        internal bool IsSetAllowedPublishers() => this.AllowedPublishers != null;

        /// <summary>
        /// Gets and sets the property CodeSigningConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string CodeSigningConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the CodeSigningConfigArn property is set.
        /// </summary>
        internal bool IsSetCodeSigningConfigArn() => this.CodeSigningConfigArn != null;

        /// <summary>
        /// Gets and sets the property CodeSigningConfigId. 
        /// <para>
        /// Unique identifer for the Code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CodeSigningConfigId { get; set; }

        /// <summary>
        /// Checks to see if the CodeSigningConfigId property is set.
        /// </summary>
        internal bool IsSetCodeSigningConfigId() => this.CodeSigningConfigId != null;

        /// <summary>
        /// Gets and sets the property CodeSigningPolicies. 
        /// <para>
        /// The code signing policy controls the validation failure action for signature mismatch
        /// or expiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodeSigningPolicies CodeSigningPolicies { get; set; }

        /// <summary>
        /// Checks to see if the CodeSigningPolicies property is set.
        /// </summary>
        internal bool IsSetCodeSigningPolicies() => this.CodeSigningPolicies != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Code signing configuration description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the Code signing configuration was last modified, in ISO-8601
        /// format (YYYY-MM-DDThh:mm:ss.sTZD). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;
    }
}
