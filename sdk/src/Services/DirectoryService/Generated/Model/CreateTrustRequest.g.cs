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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrust operation. Directory Service for Microsoft
    /// Active Directory allows you to configure trust relationships. For example, you can
    /// establish a trust between your Managed Microsoft AD directory, and your existing self-managed
    /// Microsoft Active Directory. This would allow you to provide users and groups access
    /// to resources in either domain, with a single set of credentials. <para> This action
    /// initiates the creation of the Amazon Web Services side of a trust relationship between
    /// an Managed Microsoft AD directory and an external domain. You can create either a
    /// forest trust or an external trust. </para>
    /// </summary>
    public partial class CreateTrustRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConditionalForwarderIpAddrs. 
        /// <para>
        /// The IP addresses of the remote DNS server associated with RemoteDomainName.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConditionalForwarderIpAddrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConditionalForwarderIpAddrs property is set.
        /// </summary>
        internal bool IsSetConditionalForwarderIpAddrs() => this.ConditionalForwarderIpAddrs != null && (this.ConditionalForwarderIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConditionalForwarderIpv6Addrs. 
        /// <para>
        /// The IPv6 addresses of the remote DNS server associated with RemoteDomainName.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConditionalForwarderIpv6Addrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConditionalForwarderIpv6Addrs property is set.
        /// </summary>
        internal bool IsSetConditionalForwarderIpv6Addrs() => this.ConditionalForwarderIpv6Addrs != null && (this.ConditionalForwarderIpv6Addrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of the Managed Microsoft AD directory for which to establish the
        /// trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The Fully Qualified Domain Name (FQDN) of the external domain for which to create
        /// the trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string RemoteDomainName { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDomainName property is set.
        /// </summary>
        internal bool IsSetRemoteDomainName() => this.RemoteDomainName != null;

        /// <summary>
        /// Gets and sets the property SelectiveAuth. 
        /// <para>
        /// Optional parameter to enable selective authentication for the trust.
        /// </para>
        /// </summary>
        public SelectiveAuth SelectiveAuth { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveAuth property is set.
        /// </summary>
        internal bool IsSetSelectiveAuth() => this.SelectiveAuth != null;

        /// <summary>
        /// Gets and sets the property TrustDirection. 
        /// <para>
        /// The direction of the trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustDirection TrustDirection { get; set; }

        /// <summary>
        /// Checks to see if the TrustDirection property is set.
        /// </summary>
        internal bool IsSetTrustDirection() => this.TrustDirection != null;

        /// <summary>
        /// Gets and sets the property TrustPassword. 
        /// <para>
        /// The trust password. The trust password must be the same password that was used when
        /// creating the trust relationship on the external domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string TrustPassword { get; set; }

        /// <summary>
        /// Checks to see if the TrustPassword property is set.
        /// </summary>
        internal bool IsSetTrustPassword() => this.TrustPassword != null;

        /// <summary>
        /// Gets and sets the property TrustType. 
        /// <para>
        /// The trust relationship type. <c>Forest</c> is the default.
        /// </para>
        /// </summary>
        public TrustType TrustType { get; set; }

        /// <summary>
        /// Checks to see if the TrustType property is set.
        /// </summary>
        internal bool IsSetTrustType() => this.TrustType != null;
    }
}
