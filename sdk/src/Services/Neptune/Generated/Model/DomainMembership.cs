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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// An Active Directory Domain membership record associated with a DB instance.
    /// </summary>
    public partial class DomainMembership
    {
        private string _domain;
        private string _fqdn;
        private string _iamRoleName;
        private string _status;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The identifier of the Active Directory Domain.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property FQDN. 
        /// <para>
        /// The fully qualified domain name of the Active Directory Domain.
        /// </para>
        /// </summary>
        public string FQDN
        {
            get { return this._fqdn; }
            set { this._fqdn = value; }
        }

        // Check to see if FQDN property is set
        internal bool IsSetFQDN()
        {
            return this._fqdn != null;
        }

        /// <summary>
        /// Gets and sets the property IAMRoleName. 
        /// <para>
        /// The name of the IAM role to be used when making API calls to the Directory Service.
        /// </para>
        /// </summary>
        public string IAMRoleName
        {
            get { return this._iamRoleName; }
            set { this._iamRoleName = value; }
        }

        // Check to see if IAMRoleName property is set
        internal bool IsSetIAMRoleName()
        {
            return this._iamRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB instance's Active Directory Domain membership, such as joined,
        /// pending-join, failed etc).
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}