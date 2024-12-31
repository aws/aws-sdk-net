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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the GetMedia operation.
    /// Returns the image bytes corresponding to a media object. If you have implemented your
    /// own application with the Chat and ChatSync APIs, and have enabled content extraction
    /// from visual data in Amazon Q Business, you use the GetMedia API operation to download
    /// the images so you can show them in your UI with responses.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/extracting-meaning-from-images.html">Extracting
    /// semantic meaning from images and visuals</a>.
    /// </para>
    /// </summary>
    public partial class GetMediaRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _conversationId;
        private string _mediaId;
        private string _messageId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business which contains the media object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the Amazon Q Business conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// The identifier of the media object. You can find this in the <c>sourceAttributions</c>
        /// returned by the <c>Chat</c>, <c>ChatSync</c>, and <c>ListMessages</c> API responses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MediaId
        {
            get { return this._mediaId; }
            set { this._mediaId = value; }
        }

        // Check to see if MediaId property is set
        internal bool IsSetMediaId()
        {
            return this._mediaId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the Amazon Q Business message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

    }
}