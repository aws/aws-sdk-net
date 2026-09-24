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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationSetDeliveryOptions operation.
    /// Associate a configuration set with a dedicated IP pool. You can use dedicated IP pools
    /// to create groups of dedicated IP addresses for sending specific types of email.
    /// </summary>
    public partial class PutConfigurationSetDeliveryOptionsRequest : AmazonPinpointEmailRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that you want to associate with a dedicated IP pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property SendingPoolName. 
        /// <para>
        /// The name of the dedicated IP pool that you want to associate with the configuration
        /// set.
        /// </para>
        /// </summary>
        public string SendingPoolName { get; set; }

        /// <summary>
        /// Checks to see if the SendingPoolName property is set.
        /// </summary>
        internal bool IsSetSendingPoolName() => this.SendingPoolName != null;

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// Specifies whether messages that use the configuration set are required to use Transport
        /// Layer Security (TLS). If the value is <c>Require</c>, messages are only delivered
        /// if a TLS connection can be established. If the value is <c>Optional</c>, messages
        /// can be delivered in plain text if a TLS connection can't be established.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TlsPolicy property is set.
        /// </summary>
        internal bool IsSetTlsPolicy() => this.TlsPolicy != null;
    }
}
