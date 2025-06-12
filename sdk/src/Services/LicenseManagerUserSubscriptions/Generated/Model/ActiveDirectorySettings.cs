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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Contains network access and credential details that are needed for user administration
    /// in the Active Directory.
    /// </summary>
    public partial class ActiveDirectorySettings
    {
        private CredentialsProvider _domainCredentialsProvider;
        private List<string> _domainIpv4List = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainName;
        private DomainNetworkSettings _domainNetworkSettings;

        /// <summary>
        /// Gets and sets the property DomainCredentialsProvider. 
        /// <para>
        /// Points to the <c>CredentialsProvider</c> resource that contains information about
        /// the credential provider for user administration.
        /// </para>
        /// </summary>
        public CredentialsProvider DomainCredentialsProvider
        {
            get { return this._domainCredentialsProvider; }
            set { this._domainCredentialsProvider = value; }
        }

        // Check to see if DomainCredentialsProvider property is set
        internal bool IsSetDomainCredentialsProvider()
        {
            return this._domainCredentialsProvider != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIpv4List. 
        /// <para>
        /// A list of domain IPv4 addresses that are used for the Active Directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> DomainIpv4List
        {
            get { return this._domainIpv4List; }
            set { this._domainIpv4List = value; }
        }

        // Check to see if DomainIpv4List property is set
        internal bool IsSetDomainIpv4List()
        {
            return this._domainIpv4List != null && (this._domainIpv4List.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for the Active Directory.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNetworkSettings. 
        /// <para>
        /// The <c>DomainNetworkSettings</c> resource contains an array of subnets that apply
        /// for the Active Directory.
        /// </para>
        /// </summary>
        public DomainNetworkSettings DomainNetworkSettings
        {
            get { return this._domainNetworkSettings; }
            set { this._domainNetworkSettings = value; }
        }

        // Check to see if DomainNetworkSettings property is set
        internal bool IsSetDomainNetworkSettings()
        {
            return this._domainNetworkSettings != null;
        }

    }
}