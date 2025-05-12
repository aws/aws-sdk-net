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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the TestConnection operation.
    /// </summary>
    public partial class TestConnectionResponse : AmazonWebServiceResponse
    {
        private string _connectorId;
        private SftpConnectorConnectionDetails _sftpConnectionDetails;
        private string _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// Returns the identifier of the connector object that you are testing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property SftpConnectionDetails. 
        /// <para>
        /// Structure that contains the SFTP connector host key.
        /// </para>
        /// </summary>
        public SftpConnectorConnectionDetails SftpConnectionDetails
        {
            get { return this._sftpConnectionDetails; }
            set { this._sftpConnectionDetails = value; }
        }

        // Check to see if SftpConnectionDetails property is set
        internal bool IsSetSftpConnectionDetails()
        {
            return this._sftpConnectionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Returns <c>OK</c> for successful test, or <c>ERROR</c> if the test fails.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Returns <c>Connection succeeded</c> if the test is successful. Or, returns a descriptive
        /// error message if the test fails. The following list provides troubleshooting details,
        /// depending on the error message that you receive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Verify that your secret name aligns with the one in Transfer Role permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Verify the server URL in the connector configuration , and verify that the login credentials
        /// work successfully outside of the connector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Verify that the secret exists and is formatted correctly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Verify that the trusted host key in the connector configuration matches the <c>ssh-keyscan</c>
        /// output.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}