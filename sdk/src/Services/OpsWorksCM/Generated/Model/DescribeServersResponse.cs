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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// This is the response object from the DescribeServers operation.
    /// </summary>
    public partial class DescribeServersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<CMServer> _servers = AWSConfigs.InitializeCollections ? new List<CMServer>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// This is not currently implemented for <c>DescribeServers</c> requests. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// Contains the response to a <c>DescribeServers</c> request.
        /// </para>
        ///  
        /// <para>
        ///  <i>For Chef Automate servers:</i> If <c>DescribeServersResponse$Servers$EngineAttributes</c>
        /// includes CHEF_MAJOR_UPGRADE_AVAILABLE, you can upgrade the Chef Automate server to
        /// Chef Automate 2. To be eligible for upgrade, a server running Chef Automate 1 must
        /// have had at least one successful maintenance run after November 1, 2019.
        /// </para>
        ///  
        /// <para>
        ///  <i>For Puppet servers:</i> <c>DescribeServersResponse$Servers$EngineAttributes</c>
        /// contains the following two responses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PUPPET_API_CA_CERT</c>, the PEM-encoded CA certificate that is used by the Puppet
        /// API over TCP port number 8140. The CA certificate is also used to sign node certificates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUPPET_API_CRL</c>, a certificate revocation list. The certificate revocation
        /// list is for internal maintenance purposes only. For more information about the Puppet
        /// certificate revocation list, see <a href="https://puppet.com/docs/puppet/5.5/man/certificate_revocation_list.html">Man
        /// Page: puppet certificate_revocation_list</a> in the Puppet documentation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<CMServer> Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers != null && (this._servers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}