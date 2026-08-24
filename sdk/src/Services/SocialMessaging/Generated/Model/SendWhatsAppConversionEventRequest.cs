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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the SendWhatsAppConversionEvent operation.
    /// Sends a conversion event to Meta's Conversions API for the specified WhatsApp Business
    /// Account dataset.
    /// </summary>
    public partial class SendWhatsAppConversionEventRequest : AmazonSocialMessagingRequest
    {
        private string _datasetId;
        private MemoryStream _eventData;
        private string _id;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The Meta-generated dataset ID to send the event to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=20)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property EventData. 
        /// <para>
        /// The raw Meta Conversions API event payload as a JSON blob. See <a href="https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/server-event">Meta's
        /// server event parameters</a> for the supported format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024000)]
        public MemoryStream EventData
        {
            get { return this._eventData; }
            set { this._eventData = value; }
        }

        // Check to see if EventData property is set
        internal bool IsSetEventData()
        {
            return this._eventData != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the WhatsApp Business Account associated with the dataset, formatted as
        /// <c>waba-01234567890123456789012345678901</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=115)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}