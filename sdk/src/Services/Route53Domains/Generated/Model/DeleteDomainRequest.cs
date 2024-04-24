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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDomain operation.
    /// This operation deletes the specified domain. This action is permanent. For more information,
    /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-delete.html">Deleting
    /// a domain name registration</a>.
    /// 
    ///  
    /// <para>
    /// To transfer the domain registration to another registrar, use the transfer process
    /// that’s provided by the registrar to which you want to transfer the registration. Otherwise,
    /// the following apply:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You can’t get a refund for the cost of a deleted domain registration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The registry for the top-level domain might hold the domain name for a brief time
    /// before releasing it for other users to register (varies by registry). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the registration has been deleted, we'll send you a confirmation to the registrant
    /// contact. The email will come from <c>noreply@domainnameverification.net</c> or <c>noreply@registrar.amazon.com</c>.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DeleteDomainRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the domain to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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

    }
}