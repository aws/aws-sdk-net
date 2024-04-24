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
    /// Describes the type and format of extension access. Only one of <c>CustomObjectIdentifier</c>
    /// or <c>AccessMethodType</c> may be provided. Providing both results in <c>InvalidArgsException</c>.
    /// </summary>
    public partial class AccessMethod
    {
        private AccessMethodType _accessMethodType;
        private string _customObjectIdentifier;

        /// <summary>
        /// Gets and sets the property AccessMethodType. 
        /// <para>
        /// Specifies the <c>AccessMethod</c>.
        /// </para>
        /// </summary>
        public AccessMethodType AccessMethodType
        {
            get { return this._accessMethodType; }
            set { this._accessMethodType = value; }
        }

        // Check to see if AccessMethodType property is set
        internal bool IsSetAccessMethodType()
        {
            return this._accessMethodType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomObjectIdentifier. 
        /// <para>
        /// An object identifier (OID) specifying the <c>AccessMethod</c>. The OID must satisfy
        /// the regular expression shown below. For more information, see NIST's definition of
        /// <a href="https://csrc.nist.gov/glossary/term/Object_Identifier">Object Identifier
        /// (OID)</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string CustomObjectIdentifier
        {
            get { return this._customObjectIdentifier; }
            set { this._customObjectIdentifier = value; }
        }

        // Check to see if CustomObjectIdentifier property is set
        internal bool IsSetCustomObjectIdentifier()
        {
            return this._customObjectIdentifier != null;
        }

    }
}