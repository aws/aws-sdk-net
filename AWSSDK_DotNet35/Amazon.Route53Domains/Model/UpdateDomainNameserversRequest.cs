/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainNameservers operation.
    /// This operation replaces the current set of name servers for the domain with the specified
    /// set of name servers. If you use Amazon Route 53 as your DNS service, specify the four
    /// name servers in the delegation set for the hosted zone for the domain. 
    /// 
    ///  
    /// <para>
    /// If successful, this operation returns an operation ID that you can use to track the
    /// progress and completion of the action. If the request is not completed successfully,
    /// the domain registrant will be notified by email.
    /// </para>
    /// </summary>
    public partial class UpdateDomainNameserversRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private string _fiAuthKey;
        private List<Nameserver> _nameservers = new List<Nameserver>();

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of a domain.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Constraints: The domain name can contain only the letters a through z, the numbers
        /// 0 through 9, and hyphen (-). Internationalized Domain Names are not supported.
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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
        /// Gets and sets the property FIAuthKey. 
        /// <para>
        /// The authorization key for .fi domains
        /// </para>
        /// </summary>
        public string FIAuthKey
        {
            get { return this._fiAuthKey; }
            set { this._fiAuthKey = value; }
        }

        // Check to see if FIAuthKey property is set
        internal bool IsSetFIAuthKey()
        {
            return this._fiAuthKey != null;
        }

        /// <summary>
        /// Gets and sets the property Nameservers. 
        /// <para>
        /// A list of new name servers for the domain.
        /// </para>
        ///  
        /// <para>
        /// Type: Complex
        /// </para>
        ///  
        /// <para>
        /// Children: <code>Name</code>, <code>GlueIps</code>
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        /// </summary>
        public List<Nameserver> Nameservers
        {
            get { return this._nameservers; }
            set { this._nameservers = value; }
        }

        // Check to see if Nameservers property is set
        internal bool IsSetNameservers()
        {
            return this._nameservers != null && this._nameservers.Count > 0; 
        }

    }
}