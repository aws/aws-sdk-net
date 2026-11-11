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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQueue operation. Creates a new queue for
    /// the specified Connect Customer instance. <important> <ul> <li> <para> If the phone
    /// number is claimed to a traffic distribution group that was created in the same Region
    /// as the Connect Customer instance where you are calling this API, then you can use
    /// a full phone number ARN or a UUID for <c>OutboundCallerIdNumberId</c>. However, if
    /// the phone number is claimed to a traffic distribution group that is in one Region,
    /// and you are calling this API from an instance in another Amazon Web Services Region
    /// that is associated with the traffic distribution group, you must provide a full phone
    /// number ARN. If a UUID is provided in this scenario, you will receive a <c>ResourceNotFoundException</c>.
    /// </para> </li> <li> <para> Only use the phone number ARN format that doesn't contain
    /// <c>instance</c> in the path, for example, <c>arn:aws:connect:us-east-1:1234567890:phone-number/uuid</c>.
    /// This is the same ARN format that is returned when you call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
    /// API. </para> </li> <li> <para> If you plan to use IAM policies to allow/deny access
    /// to this API for phone number resources claimed to a traffic distribution group, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_resource-level-policy-examples.html#allow-deny-queue-actions-replica-region">Allow
    /// or Deny queue API actions for phone numbers in a replica Region</a>. </para> </li>
    /// </ul> </important>
    /// </summary>
    public partial class CreateQueueRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EmailAddressesConfig. 
        /// <para>
        /// Configuration list containing the email addresses to associate with the queue during
        /// creation. Each configuration specifies an email address ID that agents can select
        /// when handling email contacts in this queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<EmailAddressConfig> EmailAddressesConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<EmailAddressConfig>() : null;

        /// <summary>
        /// Checks to see if the EmailAddressesConfig property is set.
        /// </summary>
        internal bool IsSetEmailAddressesConfig() => this.EmailAddressesConfig != null && (this.EmailAddressesConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HoursOfOperationId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationId() => this.HoursOfOperationId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxContacts. 
        /// <para>
        /// The maximum number of contacts that can be in the queue before it is considered full.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxContacts { get; set; }

        /// <summary>
        /// Checks to see if the MaxContacts property is set.
        /// </summary>
        internal bool IsSetMaxContacts() => this.MaxContacts.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutboundCallerConfig. 
        /// <para>
        /// The outbound caller ID name, number, and outbound whisper flow.
        /// </para>
        /// </summary>
        public OutboundCallerConfig OutboundCallerConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallerConfig property is set.
        /// </summary>
        internal bool IsSetOutboundCallerConfig() => this.OutboundCallerConfig != null;

        /// <summary>
        /// Gets and sets the property OutboundEmailConfig. 
        /// <para>
        /// The outbound email address ID for a specified queue.
        /// </para>
        /// </summary>
        public OutboundEmailConfig OutboundEmailConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutboundEmailConfig property is set.
        /// </summary>
        internal bool IsSetOutboundEmailConfig() => this.OutboundEmailConfig != null;

        /// <summary>
        /// Gets and sets the property QuickConnectIds. 
        /// <para>
        /// The quick connects available to agents who are working the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> QuickConnectIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QuickConnectIds property is set.
        /// </summary>
        internal bool IsSetQuickConnectIds() => this.QuickConnectIds != null && (this.QuickConnectIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
