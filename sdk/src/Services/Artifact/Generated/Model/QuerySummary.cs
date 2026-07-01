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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Summary information about a single query within a compliance inquiry.
    /// </summary>
    public partial class QuerySummary
    {
        private List<Citation> _citations = AWSConfigs.InitializeCollections ? new List<Citation>() : null;
        private DateTime? _createdAt;
        private string _query;
        private int? _queryIdentifier;
        private string _response;
        private ReviewType _reviewType;
        private QueryStatus _status;
        private QueryStatusMessage _statusMessage;
        private List<ResponseVersion> _updatedResponseVersions = AWSConfigs.InitializeCollections ? new List<ResponseVersion>() : null;

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// Supporting citations for the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Citation> Citations
        {
            get { return this._citations; }
            set { this._citations = value; }
        }

        // Check to see if Citations property is set
        internal bool IsSetCitations()
        {
            return this._citations != null && (this._citations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The actual query text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property QueryIdentifier. 
        /// <para>
        /// Sequential identifier of the query within the inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? QueryIdentifier
        {
            get { return this._queryIdentifier; }
            set { this._queryIdentifier = value; }
        }

        // Check to see if QueryIdentifier property is set
        internal bool IsSetQueryIdentifier()
        {
            return this._queryIdentifier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// Generated response to the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewType. 
        /// <para>
        /// Type of review for the response.
        /// </para>
        /// </summary>
        public ReviewType ReviewType
        {
            get { return this._reviewType; }
            set { this._reviewType = value; }
        }

        // Check to see if ReviewType property is set
        internal bool IsSetReviewType()
        {
            return this._reviewType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current processing status of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Descriptive status message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryStatusMessage StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedResponseVersions. 
        /// <para>
        /// Ordered list of response version history entries, oldest first.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponseVersion> UpdatedResponseVersions
        {
            get { return this._updatedResponseVersions; }
            set { this._updatedResponseVersions = value; }
        }

        // Check to see if UpdatedResponseVersions property is set
        internal bool IsSetUpdatedResponseVersions()
        {
            return this._updatedResponseVersions != null && (this._updatedResponseVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}