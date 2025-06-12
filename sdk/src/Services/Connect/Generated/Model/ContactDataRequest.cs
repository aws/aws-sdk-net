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
    /// Request object with information to create a contact.
    /// </summary>
    public partial class ContactDataRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Campaign _campaign;
        private Endpoint _customerEndpoint;
        private string _queueId;
        private string _requestIdentifier;
        private Endpoint _systemEndpoint;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// List of attributes to be stored in a contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Campaign. 
        /// <para>
        /// Structure to store information associated with a campaign.
        /// </para>
        /// </summary>
        public Campaign Campaign
        {
            get { return this._campaign; }
            set { this._campaign = value; }
        }

        // Check to see if Campaign property is set
        internal bool IsSetCampaign()
        {
            return this._campaign != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// Endpoint of the customer for which contact will be initiated.
        /// </para>
        /// </summary>
        public Endpoint CustomerEndpoint
        {
            get { return this._customerEndpoint; }
            set { this._customerEndpoint = value; }
        }

        // Check to see if CustomerEndpoint property is set
        internal bool IsSetCustomerEndpoint()
        {
            return this._customerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier of the queue associated with the Amazon Connect instance in which contacts
        /// that are created will be queued.
        /// </para>
        /// </summary>
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// Identifier to uniquely identify individual requests in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Max=80)]
        public string RequestIdentifier
        {
            get { return this._requestIdentifier; }
            set { this._requestIdentifier = value; }
        }

        // Check to see if RequestIdentifier property is set
        internal bool IsSetRequestIdentifier()
        {
            return this._requestIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// Endpoint associated with the Amazon Connect instance from which outbound contact will
        /// be initiated for the campaign.
        /// </para>
        /// </summary>
        public Endpoint SystemEndpoint
        {
            get { return this._systemEndpoint; }
            set { this._systemEndpoint = value; }
        }

        // Check to see if SystemEndpoint property is set
        internal bool IsSetSystemEndpoint()
        {
            return this._systemEndpoint != null;
        }

    }
}