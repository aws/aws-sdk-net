/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutDeliveryChannel operation.
    /// Creates a delivery channel object to deliver configuration information to an Amazon
    /// S3 bucket and Amazon SNS topic.
    /// 
    ///  
    /// <para>
    /// Before you can create a delivery channel, you must create a configuration recorder.
    /// </para>
    ///  
    /// <para>
    /// You can use this action to change the Amazon S3 bucket or an Amazon SNS topic of the
    /// existing delivery channel. To change the Amazon S3 bucket or an Amazon SNS topic,
    /// call this action and specify the changed values for the S3 bucket and the SNS topic.
    /// If you specify a different value for either the S3 bucket or the SNS topic, this action
    /// will keep the existing value for the parameter that is not changed.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can have only one delivery channel per region in your account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutDeliveryChannelRequest : AmazonConfigServiceRequest
    {
        private DeliveryChannel _deliveryChannel;

        /// <summary>
        /// Gets and sets the property DeliveryChannel. 
        /// <para>
        /// The configuration delivery channel object that delivers the configuration information
        /// to an Amazon S3 bucket and to an Amazon SNS topic.
        /// </para>
        /// </summary>
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