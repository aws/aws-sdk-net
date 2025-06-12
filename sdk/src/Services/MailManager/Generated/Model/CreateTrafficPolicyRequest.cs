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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrafficPolicy operation.
    /// Provision a new traffic policy resource.
    /// </summary>
    public partial class CreateTrafficPolicyRequest : AmazonMailManagerRequest
    {
        private string _clientToken;
        private AcceptAction _defaultAction;
        private int? _maxMessageSizeBytes;
        private List<PolicyStatement> _policyStatements = AWSConfigs.InitializeCollections ? new List<PolicyStatement>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trafficPolicyName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that Amazon SES uses to recognize subsequent retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// Default action instructs the traﬃc policy to either Allow or Deny (block) messages
        /// that fall outside of (or not addressed by) the conditions of your policy statements
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AcceptAction DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property MaxMessageSizeBytes. 
        /// <para>
        /// The maximum message size in bytes of email which is allowed in by this traffic policy—anything
        /// larger will be blocked.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxMessageSizeBytes
        {
            get { return this._maxMessageSizeBytes; }
            set { this._maxMessageSizeBytes = value; }
        }

        // Check to see if MaxMessageSizeBytes property is set
        internal bool IsSetMaxMessageSizeBytes()
        {
            return this._maxMessageSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStatements. 
        /// <para>
        /// Conditional statements for filtering email traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PolicyStatement> PolicyStatements
        {
            get { return this._policyStatements; }
            set { this._policyStatements = value; }
        }

        // Check to see if PolicyStatements property is set
        internal bool IsSetPolicyStatements()
        {
            return this._policyStatements != null && (this._policyStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for the resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyName. 
        /// <para>
        /// A user-friendly name for the traffic policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string TrafficPolicyName
        {
            get { return this._trafficPolicyName; }
            set { this._trafficPolicyName = value; }
        }

        // Check to see if TrafficPolicyName property is set
        internal bool IsSetTrafficPolicyName()
        {
            return this._trafficPolicyName != null;
        }

    }
}