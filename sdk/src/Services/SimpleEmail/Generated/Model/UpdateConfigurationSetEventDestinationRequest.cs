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
    /// Container for the parameters to the UpdateConfigurationSetEventDestination operation.
    /// Updates the event destination of a configuration set.
    /// 
    ///  <note> 
    /// <para>
    /// When you create or update an event destination, you must provide one, and only one,
    /// destination. The destination can be either Amazon CloudWatch or Amazon Kinesis Firehose.
    /// </para>
    ///  </note> 
    /// <para>
    /// Event destinations are associated with configuration sets, which enable you to publish
    /// email sending events to Amazon CloudWatch or Amazon Kinesis Firehose. For information
    /// about using configuration sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class UpdateConfigurationSetEventDestinationRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private EventDestination _eventDestination;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that you want to update.
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
        /// The event destination object that you want to apply to the specified configuration
        /// set.
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