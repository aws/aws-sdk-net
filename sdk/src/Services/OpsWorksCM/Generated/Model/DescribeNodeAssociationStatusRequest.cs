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
    /// Container for the parameters to the DescribeNodeAssociationStatus operation.
    /// Returns the current status of an existing association or disassociation request.
    /// 
    /// 
    ///  
    /// <para>
    ///  A <code>ResourceNotFoundException</code> is thrown when no recent association or
    /// disassociation request with the specified token is found, or when the server does
    /// not exist. A <code>ValidationException</code> is raised when parameters of the request
    /// are not valid. 
    /// </para>
    /// </summary>
    public partial class DescribeNodeAssociationStatusRequest : AmazonOpsWorksCMRequest
    {
        private string _nodeAssociationStatusToken;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property NodeAssociationStatusToken.
        /// </summary>
        public string NodeAssociationStatusToken
        {
            get { return this._nodeAssociationStatusToken; }
            set { this._nodeAssociationStatusToken = value; }
        }

        // Check to see if NodeAssociationStatusToken property is set
        internal bool IsSetNodeAssociationStatusToken()
        {
            return this._nodeAssociationStatusToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server from which to disassociate the node. 
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}