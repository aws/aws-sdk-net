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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationSetDeliveryOptions operation.
    /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
    /// to create groups of dedicated IP addresses for sending specific types of email.
    /// </summary>
    public partial class PutConfigurationSetDeliveryOptionsRequest : AmazonPinpointEmailRequest
    {
        private string _configurationSetName;
        private string _sendingPoolName;
        private TlsPolicy _tlsPolicy;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that you want to associate with a dedicated IP pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property SendingPoolName. 
        /// <para>
        /// The name of the dedicated IP pool that you want to associate with the configuration
        /// set.
        /// </para>
        /// </summary>
        public string SendingPoolName
        {
            get { return this._sendingPoolName; }
            set { this._sendingPoolName = value; }
        }

        // Check to see if SendingPoolName property is set
        internal bool IsSetSendingPoolName()
        {
            return this._sendingPoolName != null;
        }

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// Specifies whether messages that use the configuration set are required to use Transport
        /// Layer Security (TLS). If the value is <code>Require</code>, messages are only delivered
        /// if a TLS connection can be established. If the value is <code>Optional</code>, messages
        /// can be delivered in plain text if a TLS connection can't be established.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy
        {
            get { return this._tlsPolicy; }
            set { this._tlsPolicy = value; }
        }

        // Check to see if TlsPolicy property is set
        internal bool IsSetTlsPolicy()
        {
            return this._tlsPolicy != null;
        }

    }
}