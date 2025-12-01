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
    /// Contains information about an update operation performed on a recommender.
    /// </summary>
    public partial class RecommenderUpdate
    {
        private DateTime? _createdAt;
        private string _failureReason;
        private DateTime? _lastUpdatedAt;
        private RecommenderConfig _recommenderConfig;
        private RecommenderStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this recommender update was initiated.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the update operation failed, provides the reason for the failure.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the recommender was edited.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The updated configuration settings applied to the recommender during this update.
        /// </para>
        /// </summary>
        public RecommenderConfig RecommenderConfig
        {
            get { return this._recommenderConfig; }
            set { this._recommenderConfig = value; }
        }

        // Check to see if RecommenderConfig property is set
        internal bool IsSetRecommenderConfig()
        {
            return this._recommenderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommender update operation.
        /// </para>
        /// </summary>
        public RecommenderStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}