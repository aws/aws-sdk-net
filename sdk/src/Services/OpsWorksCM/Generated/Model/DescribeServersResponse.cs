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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// This is the response object from the DescribeServers operation.
    /// </summary>
    public partial class DescribeServersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<CMServer> _servers = new List<CMServer>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// This is not currently implemented for <code>DescribeServers</code> requests. 
        /// </para>
        /// </summary>
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
        /// Contains the response to a <code>DescribeServers</code> request.
        /// </para>
        ///  
        /// <para>
        ///  <i>For Puppet Server:</i> <code>DescribeServersResponse$Servers$EngineAttributes</code>
        /// contains PUPPET_API_CA_CERT. This is the PEM-encoded CA certificate that is used by
        /// the Puppet API over TCP port number 8140. The CA certificate is also used to sign
        /// node certificates.
        /// </para>
        /// </summary>
        public List<CMServer> Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers != null && this._servers.Count > 0; 
        }

    }
}