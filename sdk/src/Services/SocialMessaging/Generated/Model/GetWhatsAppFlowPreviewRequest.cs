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
    /// Container for the parameters to the GetWhatsAppFlowPreview operation.
    /// Generates a web preview URL for testing a WhatsApp Flow before publishing. Preview
    /// URLs expire in 30 days and can be shared with stakeholders for review.
    /// </summary>
    public partial class GetWhatsAppFlowPreviewRequest : AmazonSocialMessagingRequest
    {
        private string _flowId;
        private string _id;
        private bool? _invalidate;

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the Flow to preview.
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

        /// <summary>
        /// Gets and sets the property Invalidate. 
        /// <para>
        /// Set to <c>true</c> to force generation of a new preview URL. Use this if the previous
        /// URL has been compromised or you want a fresh expiration period.
        /// </para>
        /// </summary>
        public bool? Invalidate
        {
            get { return this._invalidate; }
            set { this._invalidate = value; }
        }

        // Check to see if Invalidate property is set
        internal bool IsSetInvalidate()
        {
            return this._invalidate.HasValue; 
        }

    }
}