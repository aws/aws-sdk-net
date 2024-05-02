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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the DisableCrl operation.
    /// Disables a certificate revocation list (CRL).
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:DisableCrl</c>. 
    /// </para>
    /// </summary>
    public partial class DisableCrlRequest : AmazonIAMRolesAnywhereRequest
    {
        private string _crlId;

        /// <summary>
        /// Gets and sets the property CrlId. 
        /// <para>
        /// The unique identifier of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CrlId
        {
            get { return this._crlId; }
            set { this._crlId = value; }
        }

        // Check to see if CrlId property is set
        internal bool IsSetCrlId()
        {
            return this._crlId != null;
        }

    }
}