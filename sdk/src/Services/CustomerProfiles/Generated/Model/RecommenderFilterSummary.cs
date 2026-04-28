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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Provides a summary of a recommender filter's configuration and current state.
    /// </summary>
    public partial class RecommenderFilterSummary
    {
        private DateTime? _createdAt;
        private string _description;
        private string _failureReason;
        private string _recommenderFilterExpression;
        private string _recommenderFilterName;
        private RecommenderFilterStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the recommender filter was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the recommender filter's purpose and characteristics.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the recommender filter is in a failed state, provides the reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderFilterExpression. 
        /// <para>
        /// The filter expression that defines which items to include or exclude from recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2500)]
        public string RecommenderFilterExpression
        {
            get { return this._recommenderFilterExpression; }
            set { this._recommenderFilterExpression = value; }
        }

        // Check to see if RecommenderFilterExpression property is set
        internal bool IsSetRecommenderFilterExpression()
        {
            return this._recommenderFilterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property RecommenderFilterName. 
        /// <para>
        /// The name of the recommender filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string RecommenderFilterName
        {
            get { return this._recommenderFilterName; }
            set { this._recommenderFilterName = value; }
        }

        // Check to see if RecommenderFilterName property is set
        internal bool IsSetRecommenderFilterName()
        {
            return this._recommenderFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current operational status of the recommender filter.
        /// </para>
        /// </summary>
        public RecommenderFilterStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}