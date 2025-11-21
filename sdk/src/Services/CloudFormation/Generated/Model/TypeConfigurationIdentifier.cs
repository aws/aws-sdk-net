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
    /// Identifying information for the configuration of a CloudFormation extension.
    /// </summary>
    public partial class TypeConfigurationIdentifier
    {
        private ThirdPartyType _type;
        private string _typeArn;
        private string _typeConfigurationAlias;
        private string _typeConfigurationArn;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of extension.
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
        /// The ARN for the extension, in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// For public extensions, this will be the ARN assigned when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">ActivateType</a>
        /// API operation in this account and Region. For private extensions, this will be the
        /// ARN assigned when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>
        /// API operation in this account and Region.
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
        /// Gets and sets the property TypeConfigurationAlias. 
        /// <para>
        /// The alias specified for this configuration, if one was specified when the configuration
        /// was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TypeConfigurationAlias
        {
            get { return this._typeConfigurationAlias; }
            set { this._typeConfigurationAlias = value; }
        }

        // Check to see if TypeConfigurationAlias property is set
        internal bool IsSetTypeConfigurationAlias()
        {
            return this._typeConfigurationAlias != null;
        }

        /// <summary>
        /// Gets and sets the property TypeConfigurationArn. 
        /// <para>
        /// The ARN for the configuration, in this account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeConfigurationArn
        {
            get { return this._typeConfigurationArn; }
            set { this._typeConfigurationArn = value; }
        }

        // Check to see if TypeConfigurationArn property is set
        internal bool IsSetTypeConfigurationArn()
        {
            return this._typeConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension type to which this configuration applies.
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