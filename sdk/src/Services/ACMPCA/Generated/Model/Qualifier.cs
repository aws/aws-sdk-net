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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Defines a <code>PolicyInformation</code> qualifier. Amazon Web Services Private CA
    /// supports the <a href="https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.4">certification
    /// practice statement (CPS) qualifier</a> defined in RFC 5280.
    /// </summary>
    public partial class Qualifier
    {
        private string _cpsUri;

        /// <summary>
        /// Gets and sets the property CpsUri. 
        /// <para>
        /// Contains a pointer to a certification practice statement (CPS) published by the CA.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string CpsUri
        {
            get { return this._cpsUri; }
            set { this._cpsUri = value; }
        }

        // Check to see if CpsUri property is set
        internal bool IsSetCpsUri()
        {
            return this._cpsUri != null;
        }

    }
}