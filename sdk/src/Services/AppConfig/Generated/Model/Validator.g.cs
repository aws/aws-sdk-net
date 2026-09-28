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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// A validator provides a syntactic or semantic check to ensure the configuration that
    /// you want to deploy functions as intended. To validate your application configuration
    /// data, you provide a schema or an Amazon Web Services Lambda function that runs against
    /// the configuration. The configuration deployment or update can only proceed when the
    /// configuration data is valid. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-creating-configuration-profile.html#appconfig-creating-configuration-and-profile-validators">About
    /// validators</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class Validator
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Either the JSON Schema content or the Amazon Resource Name (ARN) of an Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 32768)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// AppConfig supports validators of type <c>JSON_SCHEMA</c> and <c>LAMBDA</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ValidatorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
