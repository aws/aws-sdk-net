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
    /// Container for the parameters to the DescribeTLSInspectionConfiguration operation.
    /// Returns the data objects for the specified TLS inspection configuration.
    /// </summary>
    public partial class DescribeTLSInspectionConfigurationRequest : AmazonNetworkFirewallRequest
    {
        private string _tlsInspectionConfigurationArn;
        private string _tlsInspectionConfigurationName;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TLS inspection configuration.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TLSInspectionConfigurationArn
        {
            get { return this._tlsInspectionConfigurationArn; }
            set { this._tlsInspectionConfigurationArn = value; }
        }

        // Check to see if TLSInspectionConfigurationArn property is set
        internal bool IsSetTLSInspectionConfigurationArn()
        {
            return this._tlsInspectionConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationName. 
        /// <para>
        /// The descriptive name of the TLS inspection configuration. You can't change the name
        /// of a TLS inspection configuration after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TLSInspectionConfigurationName
        {
            get { return this._tlsInspectionConfigurationName; }
            set { this._tlsInspectionConfigurationName = value; }
        }

        // Check to see if TLSInspectionConfigurationName property is set
        internal bool IsSetTLSInspectionConfigurationName()
        {
            return this._tlsInspectionConfigurationName != null;
        }

    }
}