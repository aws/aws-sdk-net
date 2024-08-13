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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
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
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Container for the parameters to the ListRooms operation.
    /// Gets summary information about all your rooms in the AWS region where the API request
    /// is processed. Results are sorted in descending order of <c>updateTime</c>.
    /// </summary>
    public partial class ListRoomsRequest : AmazonIvschatRequest
    {
        private string _loggingConfigurationIdentifier;
        private int? _maxResults;
        private string _messageReviewHandlerUri;
        private string _name;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LoggingConfigurationIdentifier. 
        /// <para>
        /// Logging-configuration identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LoggingConfigurationIdentifier
        {
            get { return this._loggingConfigurationIdentifier; }
            set { this._loggingConfigurationIdentifier = value; }
        }

        // Check to see if LoggingConfigurationIdentifier property is set
        internal bool IsSetLoggingConfigurationIdentifier()
        {
            return this._loggingConfigurationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of rooms to return. Default: 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageReviewHandlerUri. 
        /// <para>
        /// Filters the list to match the specified message review handler URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=170)]
        public string MessageReviewHandlerUri
        {
            get { return this._messageReviewHandlerUri; }
            set { this._messageReviewHandlerUri = value; }
        }

        // Check to see if MessageReviewHandlerUri property is set
        internal bool IsSetMessageReviewHandlerUri()
        {
            return this._messageReviewHandlerUri != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filters the list to match the specified room name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The first room to retrieve. This is used for pagination; see the <c>nextToken</c>
        /// response field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}