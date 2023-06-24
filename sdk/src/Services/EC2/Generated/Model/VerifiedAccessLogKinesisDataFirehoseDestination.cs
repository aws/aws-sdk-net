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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Options for Kinesis as a logging destination.
    /// </summary>
    public partial class VerifiedAccessLogKinesisDataFirehoseDestination
    {
        private VerifiedAccessLogDeliveryStatus _deliveryStatus;
        private string _deliveryStream;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property DeliveryStatus. 
        /// <para>
        /// The delivery status.
        /// </para>
        /// </summary>
        public VerifiedAccessLogDeliveryStatus DeliveryStatus
        {
            get { return this._deliveryStatus; }
            set { this._deliveryStatus = value; }
        }

        // Check to see if DeliveryStatus property is set
        internal bool IsSetDeliveryStatus()
        {
            return this._deliveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStream. 
        /// <para>
        /// The ID of the delivery stream.
        /// </para>
        /// </summary>
        public string DeliveryStream
        {
            get { return this._deliveryStream; }
            set { this._deliveryStream = value; }
        }

        // Check to see if DeliveryStream property is set
        internal bool IsSetDeliveryStream()
        {
            return this._deliveryStream != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether logging is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}