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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEventDestination operation. Deletes an existing
    /// event destination. <para> An event destination is a location where you send response
    /// information about the messages that you send. For example, when a message is delivered
    /// successfully, you can send information about that event to an Amazon CloudWatch destination,
    /// or send notifications to endpoints that are subscribed to an Amazon SNS topic. </para>
    /// </summary>
    public partial class DeleteEventDestinationRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set or the configuration set's Amazon Resource Name
        /// (ARN) to remove the event destination from. The ConfigurateSetName and ConfigurationSetArn
        /// can be found using the <a>DescribeConfigurationSets</a> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property EventDestinationName. 
        /// <para>
        /// The name of the event destination to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EventDestinationName { get; set; }

        /// <summary>
        /// Checks to see if the EventDestinationName property is set.
        /// </summary>
        internal bool IsSetEventDestinationName() => this.EventDestinationName != null;
    }
}
