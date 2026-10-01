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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfigurationSet operation. Create a configuration
    /// set. <i>Configuration sets</i> are groups of rules that you can apply to the emails
    /// you send using Amazon Pinpoint. You apply a configuration set to an email by including
    /// a reference to the configuration set in the headers of the email. When you apply a
    /// configuration set to an email, all of the rules in that configuration set are applied
    /// to the email.
    /// </summary>
    public partial class CreateConfigurationSetRequest : AmazonPinpointEmailRequest
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
        /// An object that defines the dedicated IP pool that is used to send emails that you
        /// send using the configuration set.
        /// </para>
        /// </summary>
        public DeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryOptions property is set.
        /// </summary>
        internal bool IsSetDeliveryOptions() => this.DeliveryOptions != null;

        /// <summary>
        /// Gets and sets the property ReputationOptions. 
        /// <para>
        /// An object that defines whether or not Amazon Pinpoint collects reputation metrics
        /// for the emails that you send that use the configuration set.
        /// </para>
        /// </summary>
        public ReputationOptions ReputationOptions { get; set; }

        /// <summary>
        /// Checks to see if the ReputationOptions property is set.
        /// </summary>
        internal bool IsSetReputationOptions() => this.ReputationOptions != null;

        /// <summary>
        /// Gets and sets the property SendingOptions. 
        /// <para>
        /// An object that defines whether or not Amazon Pinpoint can send email that you send
        /// using the configuration set.
        /// </para>
        /// </summary>
        public SendingOptions SendingOptions { get; set; }

        /// <summary>
        /// Checks to see if the SendingOptions property is set.
        /// </summary>
        internal bool IsSetSendingOptions() => this.SendingOptions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that you want to associate
        /// with the configuration set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrackingOptions. 
        /// <para>
        /// An object that defines the open and click tracking options for emails that you send
        /// using the configuration set.
        /// </para>
        /// </summary>
        public TrackingOptions TrackingOptions { get; set; }

        /// <summary>
        /// Checks to see if the TrackingOptions property is set.
        /// </summary>
        internal bool IsSetTrackingOptions() => this.TrackingOptions != null;
    }
}
