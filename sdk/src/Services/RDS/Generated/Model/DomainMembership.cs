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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// An Active Directory Domain membership record associated with the DB instance or cluster.
    /// </summary>
    public partial class DomainMembership
    {
        private string _authSecretArn;
        private List<string> _dnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domain;
        private string _fqdn;
        private string _iamRoleName;
        private string _ou;
        private string _status;

        /// <summary>
        /// Gets and sets the property AuthSecretArn. 
        /// <para>
        /// The ARN for the Secrets Manager secret with the credentials for the user that's a
        /// member of the domain.
        /// </para>
        /// </summary>
        public string AuthSecretArn
        {
            get { return this._authSecretArn; }
            set { this._authSecretArn = value; }
        }

        // Check to see if AuthSecretArn property is set
        internal bool IsSetAuthSecretArn()
        {
            return this._authSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIps. 
        /// <para>
        /// The IPv4 DNS IP addresses of the primary and secondary Active Directory domain controllers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIps
        {
            get { return this._dnsIps; }
            set { this._dnsIps = value; }
        }

        // Check to see if DnsIps property is set
        internal bool IsSetDnsIps()
        {
            return this._dnsIps != null && (this._dnsIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// The fully qualified domain name (FQDN) of the Active Directory Domain.
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
        /// The name of the IAM role used when making API calls to the Directory Service.
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
        /// Gets and sets the property OU. 
        /// <para>
        /// The Active Directory organizational unit for the DB instance or cluster.
        /// </para>
        /// </summary>
        public string OU
        {
            get { return this._ou; }
            set { this._ou = value; }
        }

        // Check to see if OU property is set
        internal bool IsSetOU()
        {
            return this._ou != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Active Directory Domain membership for the DB instance or cluster.
        /// Values include <c>joined</c>, <c>pending-join</c>, <c>failed</c>, and so on.
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