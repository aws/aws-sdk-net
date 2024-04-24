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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSourceServer operation.
    /// Update Source Server.
    /// </summary>
    public partial class UpdateSourceServerRequest : AmazonMgnRequest
    {
        private string _accountid;
        private SourceServerConnectorAction _connectorAction;
        private string _sourceServerID;

        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Update Source Server request account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountID
        {
            get { return this._accountid; }
            set { this._accountid = value; }
        }

        // Check to see if AccountID property is set
        internal bool IsSetAccountID()
        {
            return this._accountid != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorAction. 
        /// <para>
        /// Update Source Server request connector action.
        /// </para>
        /// </summary>
        public SourceServerConnectorAction ConnectorAction
        {
            get { return this._connectorAction; }
            set { this._connectorAction = value; }
        }

        // Check to see if ConnectorAction property is set
        internal bool IsSetConnectorAction()
        {
            return this._connectorAction != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Update Source Server request source server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

    }
}