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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Defines a custom ASN.1 X.400 <c>GeneralName</c> using an object identifier (OID) and
    /// value. The OID must satisfy the regular expression shown below. For more information,
    /// see NIST's definition of <a href="https://csrc.nist.gov/glossary/term/Object_Identifier">Object
    /// Identifier (OID)</a>.
    /// </summary>
    public partial class OtherName
    {
        private string _typeId;
        private string _value;

        /// <summary>
        /// Gets and sets the property TypeId. 
        /// <para>
        /// Specifies an OID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string TypeId
        {
            get { return this._typeId; }
            set { this._typeId = value; }
        }

        // Check to see if TypeId property is set
        internal bool IsSetTypeId()
        {
            return this._typeId != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies an OID value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}