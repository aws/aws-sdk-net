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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AuthSecretArn. 
        /// <para>
        /// The ARN for the Secrets Manager secret with the credentials for the user that's a
        /// member of the domain.
        /// </para>
        /// </summary>
        public string AuthSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthSecretArn property is set.
        /// </summary>
        internal bool IsSetAuthSecretArn() => this.AuthSecretArn != null;

        /// <summary>
        /// Gets and sets the property DnsIps. 
        /// <para>
        /// The IPv4 DNS IP addresses of the primary and secondary Active Directory domain controllers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIps property is set.
        /// </summary>
        internal bool IsSetDnsIps() => this.DnsIps != null && (this.DnsIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The identifier of the Active Directory Domain.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property FQDN. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the Active Directory Domain.
        /// </para>
        /// </summary>
        public string FQDN { get; set; }

        /// <summary>
        /// Checks to see if the FQDN property is set.
        /// </summary>
        internal bool IsSetFQDN() => this.FQDN != null;

        /// <summary>
        /// Gets and sets the property IAMRoleName. 
        /// <para>
        /// The name of the IAM role used when making API calls to the Directory Service.
        /// </para>
        /// </summary>
        public string IAMRoleName { get; set; }

        /// <summary>
        /// Checks to see if the IAMRoleName property is set.
        /// </summary>
        internal bool IsSetIAMRoleName() => this.IAMRoleName != null;

        /// <summary>
        /// Gets and sets the property OU. 
        /// <para>
        /// The Active Directory organizational unit for the DB instance or cluster.
        /// </para>
        /// </summary>
        public string OU { get; set; }

        /// <summary>
        /// Checks to see if the OU property is set.
        /// </summary>
        internal bool IsSetOU() => this.OU != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Active Directory Domain membership for the DB instance or cluster.
        /// Values include <c>joined</c>, <c>pending-join</c>, <c>failed</c>, and so on.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
