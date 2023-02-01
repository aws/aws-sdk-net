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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrust operation.
    /// Directory Service for Microsoft Active Directory allows you to configure trust relationships.
    /// For example, you can establish a trust between your Managed Microsoft AD directory,
    /// and your existing self-managed Microsoft Active Directory. This would allow you to
    /// provide users and groups access to resources in either domain, with a single set of
    /// credentials.
    /// 
    ///  
    /// <para>
    /// This action initiates the creation of the Amazon Web Services side of a trust relationship
    /// between an Managed Microsoft AD directory and an external domain. You can create either
    /// a forest trust or an external trust.
    /// </para>
    /// </summary>
    public partial class CreateTrustRequest : AmazonDirectoryServiceRequest
    {
        private List<string> _conditionalForwarderIpAddrs = new List<string>();
        private string _directoryId;
        private string _remoteDomainName;
        private SelectiveAuth _selectiveAuth;
        private TrustDirection _trustDirection;
        private string _trustPassword;
        private TrustType _trustType;

        /// <summary>
        /// Gets and sets the property ConditionalForwarderIpAddrs. 
        /// <para>
        /// The IP addresses of the remote DNS server associated with RemoteDomainName.
        /// </para>
        /// </summary>
        public List<string> ConditionalForwarderIpAddrs
        {
            get { return this._conditionalForwarderIpAddrs; }
            set { this._conditionalForwarderIpAddrs = value; }
        }

        // Check to see if ConditionalForwarderIpAddrs property is set
        internal bool IsSetConditionalForwarderIpAddrs()
        {
            return this._conditionalForwarderIpAddrs != null && this._conditionalForwarderIpAddrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of the Managed Microsoft AD directory for which to establish the
        /// trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The Fully Qualified Domain Name (FQDN) of the external domain for which to create
        /// the trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RemoteDomainName
        {
            get { return this._remoteDomainName; }
            set { this._remoteDomainName = value; }
        }

        // Check to see if RemoteDomainName property is set
        internal bool IsSetRemoteDomainName()
        {
            return this._remoteDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property SelectiveAuth. 
        /// <para>
        /// Optional parameter to enable selective authentication for the trust.
        /// </para>
        /// </summary>
        public SelectiveAuth SelectiveAuth
        {
            get { return this._selectiveAuth; }
            set { this._selectiveAuth = value; }
        }

        // Check to see if SelectiveAuth property is set
        internal bool IsSetSelectiveAuth()
        {
            return this._selectiveAuth != null;
        }

        /// <summary>
        /// Gets and sets the property TrustDirection. 
        /// <para>
        /// The direction of the trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrustDirection TrustDirection
        {
            get { return this._trustDirection; }
            set { this._trustDirection = value; }
        }

        // Check to see if TrustDirection property is set
        internal bool IsSetTrustDirection()
        {
            return this._trustDirection != null;
        }

        /// <summary>
        /// Gets and sets the property TrustPassword. 
        /// <para>
        /// The trust password. The must be the same password that was used when creating the
        /// trust relationship on the external domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string TrustPassword
        {
            get { return this._trustPassword; }
            set { this._trustPassword = value; }
        }

        // Check to see if TrustPassword property is set
        internal bool IsSetTrustPassword()
        {
            return this._trustPassword != null;
        }

        /// <summary>
        /// Gets and sets the property TrustType. 
        /// <para>
        /// The trust relationship type. <code>Forest</code> is the default.
        /// </para>
        /// </summary>
        public TrustType TrustType
        {
            get { return this._trustType; }
            set { this._trustType = value; }
        }

        // Check to see if TrustType property is set
        internal bool IsSetTrustType()
        {
            return this._trustType != null;
        }

    }
}