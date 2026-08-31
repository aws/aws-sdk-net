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
    /// The settings for a flow entitlement.
    /// </summary>
    public partial class Entitlement
    {
        /// <summary>
        /// Gets and sets the property DataTransferSubscriberFeePercent. 
        /// <para>
        ///  Percentage from 0-100 of the data transfer cost to be billed to the subscriber.
        /// </para>
        /// </summary>
        public int? DataTransferSubscriberFeePercent { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferSubscriberFeePercent property is set.
        /// </summary>
        internal bool IsSetDataTransferSubscriberFeePercent() => this.DataTransferSubscriberFeePercent.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the entitlement.
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
        ///  The type of encryption that will be used on the output that is associated with this
        /// entitlement.
        /// </para>
        /// </summary>
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property EntitlementArn. 
        /// <para>
        ///  The ARN of the entitlement. 
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
        ///  An indication of whether the entitlement is enabled. 
        /// </para>
        /// </summary>
        public EntitlementStatus EntitlementStatus { get; set; }

        /// <summary>
        /// Checks to see if the EntitlementStatus property is set.
        /// </summary>
        internal bool IsSetEntitlementStatus() => this.EntitlementStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the entitlement. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Required = true)]
        public List<string> Subscribers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subscribers property is set.
        /// </summary>
        internal bool IsSetSubscribers() => this.Subscribers != null && (this.Subscribers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
