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
    /// Request object with information to create a contact.
    /// </summary>
    public partial class ContactDataRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// List of attributes to be stored in a contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Campaign. 
        /// <para>
        /// Structure to store information associated with a campaign.
        /// </para>
        /// </summary>
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Checks to see if the Campaign property is set.
        /// </summary>
        internal bool IsSetCampaign() => this.Campaign != null;

        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// Endpoint of the customer for which contact will be initiated.
        /// </para>
        /// </summary>
        public Endpoint CustomerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEndpoint property is set.
        /// </summary>
        internal bool IsSetCustomerEndpoint() => this.CustomerEndpoint != null;

        /// <summary>
        /// Gets and sets the property OutboundStrategy. 
        /// <para>
        /// Information about the outbound strategy.
        /// </para>
        /// </summary>
        public OutboundStrategy OutboundStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OutboundStrategy property is set.
        /// </summary>
        internal bool IsSetOutboundStrategy() => this.OutboundStrategy != null;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier of the queue associated with the Connect Customer instance in which
        /// contacts that are created will be queued.
        /// </para>
        /// </summary>
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// Identifier to uniquely identify individual requests in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 80)]
        public string RequestIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RequestIdentifier property is set.
        /// </summary>
        internal bool IsSetRequestIdentifier() => this.RequestIdentifier != null;

        /// <summary>
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// Endpoint associated with the Connect Customer instance from which outbound contact
        /// will be initiated for the campaign.
        /// </para>
        /// </summary>
        public Endpoint SystemEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SystemEndpoint property is set.
        /// </summary>
        internal bool IsSetSystemEndpoint() => this.SystemEndpoint != null;
    }
}
