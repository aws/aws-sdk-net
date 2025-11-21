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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
    /// Container for the parameters to the DeregisterType operation.
    /// Marks an extension or extension version as <c>DEPRECATED</c> in the CloudFormation
    /// registry, removing it from active use. Deprecated extensions or extension versions
    /// cannot be used in CloudFormation operations.
    /// 
    ///  
    /// <para>
    /// To deregister an entire extension, you must individually deregister all active versions
    /// of that extension. If an extension has only a single active version, deregistering
    /// that version results in the extension itself being deregistered and marked as deprecated
    /// in the registry.
    /// </para>
    ///  
    /// <para>
    /// You can't deregister the default version of an extension if there are other active
    /// version of that extension. If you do deregister the default version of an extension,
    /// the extension type itself is deregistered as well and marked as deprecated.
    /// </para>
    ///  
    /// <para>
    /// To view the deprecation status of an extension or extension version, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private-deregister-extension.html">Remove
    /// third-party private extensions from your account</a> in the <i>CloudFormation User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeregisterTypeRequest : AmazonCloudFormationRequest
    {
        private string _arn;
        private RegistryType _type;
        private string _typeName;
        private string _versionId;

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
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

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
        public RegistryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

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
        [AWSProperty(Min=10, Max=204)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of a specific version of the extension. The version ID is the value at the
        /// end of the Amazon Resource Name (ARN) assigned to the extension version when it is
        /// registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}