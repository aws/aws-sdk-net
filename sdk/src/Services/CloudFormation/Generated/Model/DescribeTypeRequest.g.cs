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
    /// Container for the parameters to the DescribeType operation. Returns detailed information
    /// about an extension from the CloudFormation registry in your current account and Region.
    /// <para> If you specify a <c>VersionId</c>, <c>DescribeType</c> returns information
    /// about that specific extension version. Otherwise, it returns information about the
    /// default extension version. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
    /// configuration data for extensions in your account</a> in the <i>CloudFormation User
    /// Guide</i>. </para>
    /// </summary>
    public partial class DescribeTypeRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>TypeName</c> and <c>Type</c>, or <c>Arn</c>.
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
        /// The version number of a public third-party extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5)]
        public string PublicVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PublicVersionNumber property is set.
        /// </summary>
        internal bool IsSetPublicVersionNumber() => this.PublicVersionNumber != null;

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The publisher ID of the extension publisher.
        /// </para>
        ///  
        /// <para>
        /// Extensions provided by Amazon Web Services are not assigned a publisher ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string PublisherId { get; set; }

        /// <summary>
        /// Checks to see if the PublisherId property is set.
        /// </summary>
        internal bool IsSetPublisherId() => this.PublisherId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>TypeName</c> and <c>Type</c>, or <c>Arn</c>.
        /// </para>
        /// </summary>
        public RegistryType Type { get; set; }

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
        /// Conditional: You must specify either <c>TypeName</c> and <c>Type</c>, or <c>Arn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of a specific version of the extension. The version ID is the value at the
        /// end of the Amazon Resource Name (ARN) assigned to the extension version when it is
        /// registered.
        /// </para>
        ///  
        /// <para>
        /// If you specify a <c>VersionId</c>, <c>DescribeType</c> returns information about that
        /// specific extension version. Otherwise, it returns information about the default extension
        /// version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
