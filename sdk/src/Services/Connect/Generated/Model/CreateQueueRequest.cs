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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Container for the parameters to the CreateQueue operation.
    /// Creates a new queue for the specified Amazon Connect instance.
    /// 
    ///  <important> <ul> <li> 
    /// <para>
    /// If the phone number is claimed to a traffic distribution group that was created in
    /// the same Region as the Amazon Connect instance where you are calling this API, then
    /// you can use a full phone number ARN or a UUID for <c>OutboundCallerIdNumberId</c>.
    /// However, if the phone number is claimed to a traffic distribution group that is in
    /// one Region, and you are calling this API from an instance in another Amazon Web Services
    /// Region that is associated with the traffic distribution group, you must provide a
    /// full phone number ARN. If a UUID is provided in this scenario, you will receive a
    /// <c>ResourceNotFoundException</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only use the phone number ARN format that doesn't contain <c>instance</c> in the path,
    /// for example, <c>arn:aws:connect:us-east-1:1234567890:phone-number/uuid</c>. This is
    /// the same ARN format that is returned when you call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
    /// API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you plan to use IAM policies to allow/deny access to this API for phone number
    /// resources claimed to a traffic distribution group, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security_iam_resource-level-policy-examples.html#allow-deny-queue-actions-replica-region">Allow
    /// or Deny queue API actions for phone numbers in a replica Region</a>.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class CreateQueueRequest : AmazonConnectRequest
    {
        private string _description;
        private string _hoursOfOperationId;
        private string _instanceId;
        private int? _maxContacts;
        private string _name;
        private OutboundCallerConfig _outboundCallerConfig;
        private OutboundEmailConfig _outboundEmailConfig;
        private List<string> _quickConnectIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HoursOfOperationId
        {
            get { return this._hoursOfOperationId; }
            set { this._hoursOfOperationId = value; }
        }

        // Check to see if HoursOfOperationId property is set
        internal bool IsSetHoursOfOperationId()
        {
            return this._hoursOfOperationId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxContacts. 
        /// <para>
        /// The maximum number of contacts that can be in the queue before it is considered full.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaxContacts
        {
            get { return this._maxContacts; }
            set { this._maxContacts = value; }
        }

        // Check to see if MaxContacts property is set
        internal bool IsSetMaxContacts()
        {
            return this._maxContacts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallerConfig. 
        /// <para>
        /// The outbound caller ID name, number, and outbound whisper flow.
        /// </para>
        /// </summary>
        public OutboundCallerConfig OutboundCallerConfig
        {
            get { return this._outboundCallerConfig; }
            set { this._outboundCallerConfig = value; }
        }

        // Check to see if OutboundCallerConfig property is set
        internal bool IsSetOutboundCallerConfig()
        {
            return this._outboundCallerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundEmailConfig. 
        /// <para>
        /// The outbound email address ID for a specified queue.
        /// </para>
        /// </summary>
        public OutboundEmailConfig OutboundEmailConfig
        {
            get { return this._outboundEmailConfig; }
            set { this._outboundEmailConfig = value; }
        }

        // Check to see if OutboundEmailConfig property is set
        internal bool IsSetOutboundEmailConfig()
        {
            return this._outboundEmailConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QuickConnectIds. 
        /// <para>
        /// The quick connects available to agents who are working the queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> QuickConnectIds
        {
            get { return this._quickConnectIds; }
            set { this._quickConnectIds = value; }
        }

        // Check to see if QuickConnectIds property is set
        internal bool IsSetQuickConnectIds()
        {
            return this._quickConnectIds != null && (this._quickConnectIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}