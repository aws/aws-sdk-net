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
    /// Container for the parameters to the PutDeliveryChannel operation.
    /// Creates or updates a delivery channel to deliver configuration information and other
    /// compliance information.
    /// 
    ///  
    /// <para>
    /// You can use this operation to create a new delivery channel or to update the Amazon
    /// S3 bucket and the Amazon SNS topic of an existing delivery channel.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/manage-delivery-channel.html">
    /// <b>Working with the Delivery Channel</b> </a> in the <i>Config Developer Guide.</i>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>One delivery channel per account per Region</b> 
    /// </para>
    ///  
    /// <para>
    /// You can have only one delivery channel for each account for each Amazon Web Services
    /// Region.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutDeliveryChannelRequest : AmazonConfigServiceRequest
    {
        private DeliveryChannel _deliveryChannel;

        /// <summary>
        /// Gets and sets the property DeliveryChannel. 
        /// <para>
        /// An object for the delivery channel. A delivery channel sends notifications and updated
        /// configuration states. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeliveryChannel DeliveryChannel
        {
            get { return this._deliveryChannel; }
            set { this._deliveryChannel = value; }
        }

        // Check to see if DeliveryChannel property is set
        internal bool IsSetDeliveryChannel()
        {
            return this._deliveryChannel != null;
        }

    }
}