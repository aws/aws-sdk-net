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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about a message.
    /// </summary>
    public partial class GetMessageInsightsResponse : AmazonWebServiceResponse
    {
        private List<MessageTag> _emailTags = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;
        private string _fromEmailAddress;
        private List<EmailInsights> _insights = AWSConfigs.InitializeCollections ? new List<EmailInsights>() : null;
        private string _messageId;
        private string _subject;

        /// <summary>
        /// Gets and sets the property EmailTags. 
        /// <para>
        ///  A list of tags, in the form of name/value pairs, that were applied to the email you
        /// sent, along with Amazon SES <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-using-event-publishing.html">Auto-Tags</a>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> EmailTags
        {
            get { return this._emailTags; }
            set { this._emailTags = value; }
        }

        // Check to see if EmailTags property is set
        internal bool IsSetEmailTags()
        {
            return this._emailTags != null && (this._emailTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The from address used to send the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=320)]
        public string FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// A set of insights associated with the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EmailInsights> Insights
        {
            get { return this._insights; }
            set { this._insights = value; }
        }

        // Check to see if Insights property is set
        internal bool IsSetInsights()
        {
            return this._insights != null && (this._insights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier for the message.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=998)]
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}