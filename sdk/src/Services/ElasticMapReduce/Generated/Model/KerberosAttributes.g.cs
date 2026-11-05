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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Attributes for Kerberos configuration when Kerberos authentication is enabled using
    /// a security configuration. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-kerberos.html">Use
    /// Kerberos Authentication</a> in the <i>Amazon EMR Management Guide</i>.
    /// </summary>
    public partial class KerberosAttributes
    {
        /// <summary>
        /// Gets and sets the property ADDomainJoinPassword. 
        /// <para>
        /// The Active Directory password for <c>ADDomainJoinUser</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ADDomainJoinPassword { get; set; }

        /// <summary>
        /// Checks to see if the ADDomainJoinPassword property is set.
        /// </summary>
        internal bool IsSetADDomainJoinPassword() => this.ADDomainJoinPassword != null;

        /// <summary>
        /// Gets and sets the property ADDomainJoinUser. 
        /// <para>
        /// Required only when establishing a cross-realm trust with an Active Directory domain.
        /// A user with sufficient privileges to join resources to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ADDomainJoinUser { get; set; }

        /// <summary>
        /// Checks to see if the ADDomainJoinUser property is set.
        /// </summary>
        internal bool IsSetADDomainJoinUser() => this.ADDomainJoinUser != null;

        /// <summary>
        /// Gets and sets the property CrossRealmTrustPrincipalPassword. 
        /// <para>
        /// Required only when establishing a cross-realm trust with a KDC in a different realm.
        /// The cross-realm principal password, which must be identical across realms.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CrossRealmTrustPrincipalPassword { get; set; }

        /// <summary>
        /// Checks to see if the CrossRealmTrustPrincipalPassword property is set.
        /// </summary>
        internal bool IsSetCrossRealmTrustPrincipalPassword() => this.CrossRealmTrustPrincipalPassword != null;

        /// <summary>
        /// Gets and sets the property KdcAdminPassword. 
        /// <para>
        /// The password used within the cluster for the kadmin service on the cluster-dedicated
        /// KDC, which maintains Kerberos principals, password policies, and keytabs for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string KdcAdminPassword { get; set; }

        /// <summary>
        /// Checks to see if the KdcAdminPassword property is set.
        /// </summary>
        internal bool IsSetKdcAdminPassword() => this.KdcAdminPassword != null;

        /// <summary>
        /// Gets and sets the property Realm. 
        /// <para>
        /// The name of the Kerberos realm to which all nodes in a cluster belong. For example,
        /// <c>EC2.INTERNAL</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Realm { get; set; }

        /// <summary>
        /// Checks to see if the Realm property is set.
        /// </summary>
        internal bool IsSetRealm() => this.Realm != null;
    }
}
