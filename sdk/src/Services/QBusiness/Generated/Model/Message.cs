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
    /// A message in an Amazon Q Business web experience.
    /// </summary>
    public partial class Message
    {
        private ActionExecution _actionExecution;
        private ActionReview _actionReview;
        private List<AttachmentOutput> _attachments = AWSConfigs.InitializeCollections ? new List<AttachmentOutput>() : null;
        private string _body;
        private string _messageId;
        private List<SourceAttribution> _sourceAttribution = AWSConfigs.InitializeCollections ? new List<SourceAttribution>() : null;
        private DateTime? _time;
        private MessageType _type;

        /// <summary>
        /// Gets and sets the property ActionExecution.
        /// </summary>
        public ActionExecution ActionExecution
        {
            get { return this._actionExecution; }
            set { this._actionExecution = value; }
        }

        // Check to see if ActionExecution property is set
        internal bool IsSetActionExecution()
        {
            return this._actionExecution != null;
        }

        /// <summary>
        /// Gets and sets the property ActionReview.
        /// </summary>
        public ActionReview ActionReview
        {
            get { return this._actionReview; }
            set { this._actionReview = value; }
        }

        // Check to see if ActionReview property is set
        internal bool IsSetActionReview()
        {
            return this._actionReview != null;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A file directly uploaded into an Amazon Q Business web experience chat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentOutput> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The content of the Amazon Q Business web experience message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the Amazon Q Business web experience message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property SourceAttribution. 
        /// <para>
        /// The source documents used to generate Amazon Q Business web experience message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceAttribution> SourceAttribution
        {
            get { return this._sourceAttribution; }
            set { this._sourceAttribution = value; }
        }

        // Check to see if SourceAttribution property is set
        internal bool IsSetSourceAttribution()
        {
            return this._sourceAttribution != null && (this._sourceAttribution.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp of the first Amazon Q Business web experience message.
        /// </para>
        /// </summary>
        public DateTime? Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Amazon Q Business message, whether <c>HUMAN</c> or <c>AI</c> generated.
        /// </para>
        /// </summary>
        public MessageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}