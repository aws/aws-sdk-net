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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DeactivateType operation.
    /// Deactivates a public extension that was previously activated in this account and region.
    /// 
    ///  
    /// <para>
    /// Once deactivated, an extension can't be used in any CloudFormation operation. This
    /// includes stack update operations where the stack template includes the extension,
    /// even if no updates are being made to the extension. In addition, deactivated extensions
    /// aren't automatically updated if a new version of the extension is released.
    /// </para>
    /// </summary>
    public partial class DeactivateTypeRequest : AmazonCloudFormationRequest
    {
        private string _arn;
        private ThirdPartyType _type;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the extension, in this account and region.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>Arn</code>, or <code>TypeName</code> and
        /// <code>Type</code>.
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
        /// The extension type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>Arn</code>, or <code>TypeName</code> and
        /// <code>Type</code>.
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The type name of the extension, in this account and region. If you specified a type
        /// name alias when enabling the extension, use the type name alias.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>Arn</code>, or <code>TypeName</code> and
        /// <code>Type</code>.
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