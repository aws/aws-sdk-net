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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfigurationSetEventDestination operation.
    /// Creates a configuration set event destination.
    /// 
    ///  <note> 
    /// <para>
    /// When you create or update an event destination, you must provide one, and only one,
    /// destination. The destination can be CloudWatch, Amazon Kinesis Firehose, or Amazon
    /// Simple Notification Service (Amazon SNS).
    /// </para>
    ///  </note> 
    /// <para>
    /// An event destination is the AWS service to which Amazon SES publishes the email sending
    /// events associated with a configuration set. For information about using configuration
    /// sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class CreateConfigurationSetEventDestinationRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private EventDestination _eventDestination;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that the event destination should be associated
        /// with.
        /// </para>
        /// </summary>
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
        /// An object that describes the AWS service that email sending event information will
        /// be published to.
        /// </para>
        /// </summary>
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