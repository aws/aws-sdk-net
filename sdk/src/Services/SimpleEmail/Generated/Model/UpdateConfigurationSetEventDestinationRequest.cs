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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
    /// Container for the parameters to the UpdateConfigurationSetEventDestination operation.
    /// Updates the event destination of a configuration set. Event destinations are associated
    /// with configuration sets, which enable you to publish email sending events to Amazon
    /// CloudWatch, Amazon Kinesis Firehose, or Amazon Simple Notification Service (Amazon
    /// SNS). For information about using configuration sets, see <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Monitoring
    /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
    /// 
    ///  <note> 
    /// <para>
    /// When you create or update an event destination, you must provide one, and only one,
    /// destination. The destination can be Amazon CloudWatch, Amazon Kinesis Firehose, or
    /// Amazon Simple Notification Service (Amazon SNS).
    /// </para>
    ///  </note> 
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class UpdateConfigurationSetEventDestinationRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private EventDestination _eventDestination;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that contains the event destination.
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
        /// Gets and sets the property EventDestination. 
        /// <para>
        /// The event destination object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventDestination EventDestination
        {
            get { return this._eventDestination; }
            set { this._eventDestination = value; }
        }

        // Check to see if EventDestination property is set
        internal bool IsSetEventDestination()
        {
            return this._eventDestination != null;
        }

    }
}