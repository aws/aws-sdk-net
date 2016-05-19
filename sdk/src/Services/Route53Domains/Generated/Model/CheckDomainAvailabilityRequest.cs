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
    /// Container for the parameters to the CheckDomainAvailability operation.
    /// This operation checks the availability of one domain name. Note that if the availability
    /// status of a domain is pending, you must submit another request to determine the availability
    /// of the domain name.
    /// </summary>
    public partial class CheckDomainAvailabilityRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private string _idnLangCode;

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
        /// Gets and sets the property IdnLangCode. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string IdnLangCode
        {
            get { return this._idnLangCode; }
            set { this._idnLangCode = value; }
        }

        // Check to see if IdnLangCode property is set
        internal bool IsSetIdnLangCode()
        {
            return this._idnLangCode != null;
        }

    }
}