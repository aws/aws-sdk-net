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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the PushDomain operation.
    /// Moves a domain from Amazon Web Services to another registrar. 
    /// 
    ///  
    /// <para>
    /// Supported actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Changes the IPS tags of a .uk domain, and pushes it to transit. Transit means that
    /// the domain is ready to be transferred to another registrar.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PushDomainRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private string _target;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  Name of the domain. 
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

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        ///  New IPS tag for the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}