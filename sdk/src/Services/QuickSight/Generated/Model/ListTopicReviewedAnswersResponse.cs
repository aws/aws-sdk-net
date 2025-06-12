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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the ListTopicReviewedAnswers operation.
    /// </summary>
    public partial class ListTopicReviewedAnswersResponse : AmazonWebServiceResponse
    {
        private List<TopicReviewedAnswer> _answers = AWSConfigs.InitializeCollections ? new List<TopicReviewedAnswer>() : null;
        private string _requestId;
        private int? _status;
        private string _topicArn;
        private string _topicId;

        /// <summary>
        /// Gets and sets the property Answers. 
        /// <para>
        /// The definition of all Answers in the topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicReviewedAnswer> Answers
        {
            get { return this._answers; }
            set { this._answers = value; }
        }

        // Check to see if Answers property is set
        internal bool IsSetAnswers()
        {
            return this._answers != null && (this._answers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the topic.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicId. 
        /// <para>
        /// The ID for the topic that contains the reviewed answer that you want to list. This
        /// ID is unique per Amazon Web Services Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TopicId
        {
            get { return this._topicId; }
            set { this._topicId = value; }
        }

        // Check to see if TopicId property is set
        internal bool IsSetTopicId()
        {
            return this._topicId != null;
        }

    }
}