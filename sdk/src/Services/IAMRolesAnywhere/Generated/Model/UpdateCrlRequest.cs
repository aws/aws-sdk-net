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
    /// Container for the parameters to the UpdateCrl operation.
    /// Updates the certificate revocation list (CRL). A CRL is a list of certificates that
    /// have been revoked by the issuing certificate authority (CA). IAM Roles Anywhere validates
    /// against the CRL before issuing credentials.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateCrl</c>. 
    /// </para>
    /// </summary>
    public partial class UpdateCrlRequest : AmazonIAMRolesAnywhereRequest
    {
        private MemoryStream _crlData;
        private string _crlId;
        private string _name;

        /// <summary>
        /// Gets and sets the property CrlData. 
        /// <para>
        /// The x509 v3 specified certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300000)]
        public MemoryStream CrlData
        {
            get { return this._crlData; }
            set { this._crlData = value; }
        }

        // Check to see if CrlData property is set
        internal bool IsSetCrlData()
        {
            return this._crlData != null;
        }

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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Crl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}