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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an Active Directory domain membership record associated with the
    /// DB instance.
    /// </summary>
    public partial class AwsRdsDbDomainMembership
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The identifier of the Active Directory domain.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Fqdn. 
        /// <para>
        /// The fully qualified domain name of the Active Directory domain.
        /// </para>
        /// </summary>
        public string Fqdn { get; set; }

        /// <summary>
        /// Checks to see if the Fqdn property is set.
        /// </summary>
        internal bool IsSetFqdn() => this.Fqdn != null;

        /// <summary>
        /// Gets and sets the property IamRoleName. 
        /// <para>
        /// The name of the IAM role to use when making API calls to the Directory Service.
        /// </para>
        /// </summary>
        public string IamRoleName { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleName property is set.
        /// </summary>
        internal bool IsSetIamRoleName() => this.IamRoleName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Active Directory Domain membership for the DB instance.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
