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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the PublishType operation. Publishes the specified
    /// extension to the CloudFormation registry as a public extension in this Region. Public
    /// extensions are available for use by all CloudFormation users. For more information
    /// about publishing extensions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
    /// extensions to make them available for public use</a> in the <i>CloudFormation Command
    /// Line Interface (CLI) User Guide</i>. <para> To publish an extension, you must be registered
    /// as a publisher with CloudFormation. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>.
    /// </para>
    /// </summary>
    public partial class PublishTypeRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>Arn</c>, or <c>TypeName</c> and <c>Type</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property PublicVersionNumber. 
        /// <para>
        /// The version number to assign to this version of the extension.
        /// </para>
        ///  
        /// <para>
        /// Use the following format, and adhere to semantic versioning when assigning a version
        /// number to your extension:
        /// </para>
        ///  
        /// <para>
        ///  <c>MAJOR.MINOR.PATCH</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://semver.org/">Semantic Versioning 2.0.0</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a version number, CloudFormation increments the version number
        /// by one minor version release.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify a version number the first time you publish a type. CloudFormation
        /// automatically sets the first version number to be <c>1.0.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5)]
        public string PublicVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PublicVersionNumber property is set.
        /// </summary>
        internal bool IsSetPublicVersionNumber() => this.PublicVersionNumber != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>Arn</c>, or <c>TypeName</c> and <c>Type</c>.
        /// </para>
        /// </summary>
        public ThirdPartyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>Arn</c>, or <c>TypeName</c> and <c>Type</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
