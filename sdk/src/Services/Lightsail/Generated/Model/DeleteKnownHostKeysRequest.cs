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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteKnownHostKeys operation.
    /// Deletes the known host key or certificate used by the Amazon Lightsail browser-based
    /// SSH or RDP clients to authenticate an instance. This operation enables the Lightsail
    /// browser-based SSH or RDP clients to connect to the instance after a host key mismatch.
    /// 
    ///  <important> 
    /// <para>
    /// Perform this operation only if you were expecting the host key or certificate mismatch
    /// or if you are familiar with the new host key or certificate on the instance. For more
    /// information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-troubleshooting-browser-based-ssh-rdp-client-connection">Troubleshooting
    /// connection issues when using the Amazon Lightsail browser-based SSH or RDP client</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteKnownHostKeysRequest : AmazonLightsailRequest
    {
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance for which you want to reset the host key or certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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