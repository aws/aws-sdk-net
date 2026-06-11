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
    /// Container for the parameters to the UpdateWhatsAppFlow operation.
    /// Updates the metadata of a WhatsApp Flow, such as its name or categories. This does
    /// not update the Flow JSON definition. Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_UpdateWhatsAppFlowAssets.html">UpdateWhatsAppFlowAssets</a>
    /// to update the Flow JSON.
    /// </summary>
    public partial class UpdateWhatsAppFlowRequest : AmazonSocialMessagingRequest
    {
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _flowId;
        private string _flowName;
        private string _id;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The updated categories for the Flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the Flow to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string FlowId
        {
            get { return this._flowId; }
            set { this._flowId = value; }
        }

        // Check to see if FlowId property is set
        internal bool IsSetFlowId()
        {
            return this._flowId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The updated name for the Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the WhatsApp Business Account associated with this Flow.
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