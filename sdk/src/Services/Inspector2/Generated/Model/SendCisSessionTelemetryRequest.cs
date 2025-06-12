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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the SendCisSessionTelemetry operation.
    /// Sends a CIS session telemetry. This API is used by the Amazon Inspector SSM plugin
    /// to communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin
    /// calls this API to start a CIS scan session for the scan ID supplied by the service.
    /// </summary>
    public partial class SendCisSessionTelemetryRequest : AmazonInspector2Request
    {
        private List<CisSessionMessage> _messages = AWSConfigs.InitializeCollections ? new List<CisSessionMessage>() : null;
        private string _scanJobId;
        private string _sessionToken;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The CIS session telemetry messages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public List<CisSessionMessage> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanJobId. 
        /// <para>
        /// A unique identifier for the scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanJobId
        {
            get { return this._scanJobId; }
            set { this._scanJobId = value; }
        }

        // Check to see if ScanJobId property is set
        internal bool IsSetScanJobId()
        {
            return this._scanJobId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// The unique token that identifies the CIS session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionToken
        {
            get { return this._sessionToken; }
            set { this._sessionToken = value; }
        }

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this._sessionToken != null;
        }

    }
}