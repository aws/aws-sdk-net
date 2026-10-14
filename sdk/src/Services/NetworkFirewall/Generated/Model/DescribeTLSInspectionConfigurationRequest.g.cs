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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTLSInspectionConfiguration operation.
    /// Returns the data objects for the specified TLS inspection configuration.
    /// </summary>
    public partial class DescribeTLSInspectionConfigurationRequest : AmazonNetworkFirewallRequest
    {
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
        [AWSProperty(Min = 1, Max = 256)]
        public string TLSInspectionConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationArn property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationArn() => this.TLSInspectionConfigurationArn != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string TLSInspectionConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationName property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationName() => this.TLSInspectionConfigurationName != null;
    }
}
