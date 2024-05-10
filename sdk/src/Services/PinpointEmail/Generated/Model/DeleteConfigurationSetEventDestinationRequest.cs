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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConfigurationSetEventDestination operation.
    /// Delete an event destination.
    /// 
    ///  
    /// <para>
    /// In Amazon Pinpoint, <i>events</i> include message sends, deliveries, opens, clicks,
    /// bounces, and complaints. <i>Event destinations</i> are places that you can send information
    /// about these events to. For example, you can send event data to Amazon SNS to receive
    /// notifications when you receive bounces or complaints, or you can use Amazon Kinesis
    /// Data Firehose to stream data to Amazon S3 for long-term storage.
    /// </para>
    /// </summary>
    public partial class DeleteConfigurationSetEventDestinationRequest : AmazonPinpointEmailRequest
    {
        private string _configurationSetName;
        private string _eventDestinationName;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that contains the event destination that you want
        /// to delete.
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
        /// Gets and sets the property EventDestinationName. 
        /// <para>
        /// The name of the event destination that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventDestinationName
        {
            get { return this._eventDestinationName; }
            set { this._eventDestinationName = value; }
        }

        // Check to see if EventDestinationName property is set
        internal bool IsSetEventDestinationName()
        {
            return this._eventDestinationName != null;
        }

    }
}