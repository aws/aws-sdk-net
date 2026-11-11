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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// An Active Directory Domain membership record associated with a DB instance.
    /// </summary>
    public partial class DomainMembership
    {
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
        /// The fully qualified domain name of the Active Directory Domain.
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
        /// The name of the IAM role to be used when making API calls to the Directory Service.
        /// </para>
        /// </summary>
        public string IAMRoleName { get; set; }

        /// <summary>
        /// Checks to see if the IAMRoleName property is set.
        /// </summary>
        internal bool IsSetIAMRoleName() => this.IAMRoleName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB instance's Active Directory Domain membership, such as joined,
        /// pending-join, failed etc).
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
