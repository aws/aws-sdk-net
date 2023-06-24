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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the delegation state of an Amazon Route 53 registered domain to Amazon Lightsail.
    /// 
    ///  
    /// <para>
    /// When you delegate an Amazon Route 53 registered domain to Lightsail, you can manage
    /// the DNS of the domain using a Lightsail DNS zone. You no longer use the Route 53 hosted
    /// zone to manage the DNS of the domain. To delegate the domain, Lightsail automatically
    /// updates the domain's name servers in Route 53 to the name servers of the Lightsail
    /// DNS zone. Then, Lightsail automatically deletes the Route 53 hosted zone for the domain.
    /// </para>
    ///  
    /// <para>
    /// All of the following conditions must be true for automatic domain delegation to be
    /// successful:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The registered domain must be in the same Amazon Web Services account as the Lightsail
    /// account making the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user or entity making the request must have permission to manage domains in Route 53.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Route 53 hosted zone for the domain must be empty. It cannot contain DNS records
    /// other than start of authority (SOA) and name server records.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If automatic domain delegation fails, or if you manage the DNS of your domain using
    /// a service other than Route 53, then you must manually add the Lightsail DNS zone name
    /// servers to your domain in order to delegate management of its DNS to Lightsail. For
    /// more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/lightsail-how-to-create-dns-entry">Creating
    /// a DNS zone to manage your domain’s records in Amazon Lightsail</a> in the <i>Amazon
    /// Lightsail Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisteredDomainDelegationInfo
    {
        private NameServersUpdateState _nameServersUpdateState;
        private R53HostedZoneDeletionState _r53HostedZoneDeletionState;

        /// <summary>
        /// Gets and sets the property NameServersUpdateState. 
        /// <para>
        /// An object that describes the state of the name server records that are automatically
        /// added to the Route 53 domain by Lightsail.
        /// </para>
        /// </summary>
        public NameServersUpdateState NameServersUpdateState
        {
            get { return this._nameServersUpdateState; }
            set { this._nameServersUpdateState = value; }
        }

        // Check to see if NameServersUpdateState property is set
        internal bool IsSetNameServersUpdateState()
        {
            return this._nameServersUpdateState != null;
        }

        /// <summary>
        /// Gets and sets the property R53HostedZoneDeletionState. 
        /// <para>
        /// Describes the deletion state of an Amazon Route 53 hosted zone for a domain that is
        /// being automatically delegated to an Amazon Lightsail DNS zone.
        /// </para>
        /// </summary>
        public R53HostedZoneDeletionState R53HostedZoneDeletionState
        {
            get { return this._r53HostedZoneDeletionState; }
            set { this._r53HostedZoneDeletionState = value; }
        }

        // Check to see if R53HostedZoneDeletionState property is set
        internal bool IsSetR53HostedZoneDeletionState()
        {
            return this._r53HostedZoneDeletionState != null;
        }

    }
}