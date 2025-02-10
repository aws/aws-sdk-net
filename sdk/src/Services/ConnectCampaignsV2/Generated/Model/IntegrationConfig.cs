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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Integration config for Connect Instance
    /// </summary>
    public partial class IntegrationConfig
    {
        private CustomerProfilesIntegrationConfig _customerProfiles;
        private QConnectIntegrationConfig _qConnect;

        /// <summary>
        /// Gets and sets the property CustomerProfiles.
        /// </summary>
        public CustomerProfilesIntegrationConfig CustomerProfiles
        {
            get { return this._customerProfiles; }
            set { this._customerProfiles = value; }
        }

        // Check to see if CustomerProfiles property is set
        internal bool IsSetCustomerProfiles()
        {
            return this._customerProfiles != null;
        }

        /// <summary>
        /// Gets and sets the property QConnect.
        /// </summary>
        public QConnectIntegrationConfig QConnect
        {
            get { return this._qConnect; }
            set { this._qConnect = value; }
        }

        // Check to see if QConnect property is set
        internal bool IsSetQConnect()
        {
            return this._qConnect != null;
        }

    }
}