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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDeliveryChannel operation.
    /// Deletes the delivery channel.
    /// 
    ///  
    /// <para>
    /// Before you can delete the delivery channel, you must stop the customer managed configuration
    /// recorder. You can use the <a>StopConfigurationRecorder</a> operation to stop the customer
    /// managed configuration recorder.
    /// </para>
    /// </summary>
    public partial class DeleteDeliveryChannelRequest : AmazonConfigServiceRequest
    {
        private string _deliveryChannelName;

        /// <summary>
        /// Gets and sets the property DeliveryChannelName. 
        /// <para>
        /// The name of the delivery channel that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeliveryChannelName
        {
            get { return this._deliveryChannelName; }
            set { this._deliveryChannelName = value; }
        }

        // Check to see if DeliveryChannelName property is set
        internal bool IsSetDeliveryChannelName()
        {
            return this._deliveryChannelName != null;
        }

    }
}