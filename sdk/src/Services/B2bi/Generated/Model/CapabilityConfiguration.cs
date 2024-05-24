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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// A capability object. Currently, only EDI (electronic data interchange) capabilities
    /// are supported. A trading capability contains the information required to transform
    /// incoming EDI documents into JSON or XML outputs.
    /// </summary>
    public partial class CapabilityConfiguration
    {
        private EdiConfiguration _edi;

        /// <summary>
        /// Gets and sets the property Edi. 
        /// <para>
        /// An EDI (electronic data interchange) configuration object.
        /// </para>
        /// </summary>
        public EdiConfiguration Edi
        {
            get { return this._edi; }
            set { this._edi = value; }
        }

        // Check to see if Edi property is set
        internal bool IsSetEdi()
        {
            return this._edi != null;
        }

    }
}