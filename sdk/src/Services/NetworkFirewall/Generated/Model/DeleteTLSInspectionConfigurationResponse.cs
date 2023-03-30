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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DeleteTLSInspectionConfiguration operation.
    /// </summary>
    public partial class DeleteTLSInspectionConfigurationResponse : AmazonWebServiceResponse
    {
        private TLSInspectionConfigurationResponse _tlsInspectionConfigurationResponse;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationResponse. 
        /// <para>
        /// The high-level properties of a TLS inspection configuration. This, along with the
        /// <a>TLSInspectionConfiguration</a>, define the TLS inspection configuration. You can
        /// retrieve all objects for a TLS inspection configuration by calling <a>DescribeTLSInspectionConfiguration</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TLSInspectionConfigurationResponse TLSInspectionConfigurationResponse
        {
            get { return this._tlsInspectionConfigurationResponse; }
            set { this._tlsInspectionConfigurationResponse = value; }
        }

        // Check to see if TLSInspectionConfigurationResponse property is set
        internal bool IsSetTLSInspectionConfigurationResponse()
        {
            return this._tlsInspectionConfigurationResponse != null;
        }

    }
}