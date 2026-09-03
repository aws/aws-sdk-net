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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlowEntitlement operation. Updates an entitlement.
    /// You can change an entitlement's description, subscribers, and encryption. If you change
    /// the subscribers, the service will remove the outputs that are are used by the subscribers
    /// that are removed.
    /// </summary>
    public partial class UpdateFlowEntitlementRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the entitlement. This description appears only on the MediaConnect
        /// console and will not be seen by the subscriber or end user.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        ///  The type of encryption that will be used on the output associated with this entitlement.
        /// Allowable encryption types: static-key, speke.
        /// </para>
        /// </summary>
        public UpdateEncryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the entitlement that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EntitlementArn { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementArn property is set.
        /// </summary>
        internal bool IsSetEntitlementArn() => this.EntitlementArn != null;

        /// <summary>
        /// Gets and sets the property EntitlementStatus. 
        /// <para>
        ///  An indication of whether you want to enable the entitlement to allow access, or disable
        /// it to stop streaming content to the subscriber’s flow temporarily. If you don’t specify
        /// the <c>entitlementStatus</c> field in your request, MediaConnect leaves the value
        /// unchanged.
        /// </para>
        /// </summary>
        public EntitlementStatus EntitlementStatus { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementStatus property is set.
        /// </summary>
        internal bool IsSetEntitlementStatus() => this.EntitlementStatus != null;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow that is associated with the entitlement that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property Subscribers. 
        /// <para>
        ///  The Amazon Web Services account IDs that you want to share your content with. The
        /// receiving accounts (subscribers) will be allowed to create their own flow using your
        /// content as the source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subscribers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subscribers property is set.
        /// </summary>
        internal bool IsSetSubscribers() => this.Subscribers != null && (this.Subscribers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
