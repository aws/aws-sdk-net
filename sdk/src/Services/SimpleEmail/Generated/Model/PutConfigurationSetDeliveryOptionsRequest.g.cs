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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationSetDeliveryOptions operation.
    /// Adds or updates the delivery options for a configuration set.
    /// </summary>
    public partial class PutConfigurationSetDeliveryOptionsRequest : AmazonSimpleEmailServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property DeliveryOptions. 
        /// <para>
        /// Specifies whether messages that use the configuration set are required to use Transport
        /// Layer Security (TLS).
        /// </para>
        /// </summary>
        public DeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryOptions property is set.
        /// </summary>
        internal bool IsSetDeliveryOptions() => this.DeliveryOptions != null;
    }
}
