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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a ServiceNow ITSM integration.
    /// </summary>
    public partial class ServiceNowDetail
    {
        private ConnectorAuthStatus _authStatus;
        private string _clientId;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property AuthStatus. 
        /// <para>
        /// The status of the authorization between Jira Cloud and the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorAuthStatus AuthStatus
        {
            get { return this._authStatus; }
            set { this._authStatus = value; }
        }

        // Check to see if AuthStatus property is set
        internal bool IsSetAuthStatus()
        {
            return this._authStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The clientId of ServiceNow ITSM.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The instanceName of ServiceNow ITSM.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}