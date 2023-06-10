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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required when using Salesforce.
    /// </summary>
    public partial class SalesforceConnectorProfileProperties
    {
        private string _instanceUrl;
        private bool? _isSandboxEnvironment;
        private bool? _usePrivateLinkForMetadataAndAuthorization;

        /// <summary>
        /// Gets and sets the property InstanceUrl. 
        /// <para>
        ///  The location of the Salesforce resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string InstanceUrl
        {
            get { return this._instanceUrl; }
            set { this._instanceUrl = value; }
        }

        // Check to see if InstanceUrl property is set
        internal bool IsSetInstanceUrl()
        {
            return this._instanceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IsSandboxEnvironment. 
        /// <para>
        ///  Indicates whether the connector profile applies to a sandbox or production environment.
        /// 
        /// </para>
        /// </summary>
        public bool IsSandboxEnvironment
        {
            get { return this._isSandboxEnvironment.GetValueOrDefault(); }
            set { this._isSandboxEnvironment = value; }
        }

        // Check to see if IsSandboxEnvironment property is set
        internal bool IsSetIsSandboxEnvironment()
        {
            return this._isSandboxEnvironment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsePrivateLinkForMetadataAndAuthorization. 
        /// <para>
        /// If the connection mode for the connector profile is private, this parameter sets whether
        /// Amazon AppFlow uses the private network to send metadata and authorization calls to
        /// Salesforce. Amazon AppFlow sends private calls through Amazon Web Services PrivateLink.
        /// These calls travel through Amazon Web Services infrastructure without being exposed
        /// to the public internet.
        /// </para>
        ///  
        /// <para>
        /// Set either of the following values:
        /// </para>
        ///  <dl> <dt>true</dt> <dd> 
        /// <para>
        /// Amazon AppFlow sends all calls to Salesforce over the private network.
        /// </para>
        ///  
        /// <para>
        /// These private calls are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Calls to get metadata about your Salesforce records. This metadata describes your
        /// Salesforce objects and their fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls to get or refresh access tokens that allow Amazon AppFlow to access your Salesforce
        /// records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls to transfer your Salesforce records as part of a flow run.
        /// </para>
        ///  </li> </ul> </dd> <dt>false</dt> <dd> 
        /// <para>
        /// The default value. Amazon AppFlow sends some calls to Salesforce privately and other
        /// calls over the public internet.
        /// </para>
        ///  
        /// <para>
        /// The public calls are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Calls to get metadata about your Salesforce records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calls to get or refresh access tokens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The private calls are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Calls to transfer your Salesforce records as part of a flow run.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        public bool UsePrivateLinkForMetadataAndAuthorization
        {
            get { return this._usePrivateLinkForMetadataAndAuthorization.GetValueOrDefault(); }
            set { this._usePrivateLinkForMetadataAndAuthorization = value; }
        }

        // Check to see if UsePrivateLinkForMetadataAndAuthorization property is set
        internal bool IsSetUsePrivateLinkForMetadataAndAuthorization()
        {
            return this._usePrivateLinkForMetadataAndAuthorization.HasValue; 
        }

    }
}