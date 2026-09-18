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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// This is the response object from the GetMessageInsights operation.
    /// </summary>
    public partial class GetMessageInsightsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EmailTags. 
        /// <para>
        ///  A list of tags, in the form of name/value pairs, that were applied to the email you
        /// sent, along with Amazon SES <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-using-event-publishing.html">Auto-Tags</a>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> EmailTags { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;

        /// <summary>
        /// Checks to see if the EmailTags property is set.
        /// </summary>
        internal bool IsSetEmailTags() => this.EmailTags != null && (this.EmailTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The from address used to send the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 320)]
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// A set of insights associated with the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EmailInsights> Insights { get; set; } = AWSConfigs.InitializeCollections ? new List<EmailInsights>() : null;

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null && (this.Insights.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier for the message.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 998)]
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
