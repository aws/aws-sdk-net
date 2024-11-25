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
    /// Container for the parameters to the SetTypeConfiguration operation.
    /// Specifies the configuration data for a registered CloudFormation extension, in the
    /// given account and Region.
    /// 
    ///  
    /// <para>
    /// To view the current configuration data for an extension, refer to the <c>ConfigurationSchema</c>
    /// element of <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
    /// configuration data for extensions in your account</a> in the <i>CloudFormation User
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// It's strongly recommended that you use dynamic references to restrict sensitive configuration
    /// definitions, such as third-party credentials. For more details on dynamic references,
    /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/dynamic-references.html">Specify
    /// values stored in other services using dynamic references</a> in the <i>CloudFormation
    /// User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SetTypeConfigurationRequest : AmazonCloudFormationRequest
    {
        private string _configuration;
        private string _configurationAlias;
        private ThirdPartyType _type;
        private string _typeArn;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration data for the extension, in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// The configuration data must be formatted as JSON, and validate against the schema
        /// returned in the <c>ConfigurationSchema</c> response element of <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-model.html#resource-type-howto-configuration">Defining
        /// the account-level configuration of an extension</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=204800)]
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationAlias. 
        /// <para>
        /// An alias by which to refer to this extension configuration data.
        /// </para>
        ///  
        /// <para>
        /// Conditional: Specifying a configuration alias is required when setting a configuration
        /// for a resource type extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ConfigurationAlias
        {
            get { return this._configurationAlias; }
            set { this._configurationAlias = value; }
        }

        // Check to see if ConfigurationAlias property is set
        internal bool IsSetConfigurationAlias()
        {
            return this._configurationAlias != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>ConfigurationArn</c>, or <c>Type</c> and <c>TypeName</c>.
        /// </para>
        /// </summary>
        public ThirdPartyType Type
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
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the extension, in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// For public extensions, this will be the ARN assigned when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">ActivateType</a>
        /// API operation in this account and Region. For private extensions, this will be the
        /// ARN assigned when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>
        /// API operation in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// Do not include the extension versions suffix at the end of the ARN. You can set the
        /// configuration for an extension, but not for a specific extension version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeArn
        {
            get { return this._typeArn; }
            set { this._typeArn = value; }
        }

        // Check to see if TypeArn property is set
        internal bool IsSetTypeArn()
        {
            return this._typeArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>ConfigurationArn</c>, or <c>Type</c> and <c>TypeName</c>.
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

    }
}