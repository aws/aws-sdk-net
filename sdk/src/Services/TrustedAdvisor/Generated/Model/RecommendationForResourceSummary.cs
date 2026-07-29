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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Summary of a Recommendation for a specific AWS Resource
    /// </summary>
    public partial class RecommendationForResourceSummary
    {
        private string _awsResourceArn;
        private string _checkArn;
        private ExclusionStatus _exclusionStatus;
        private DateTime? _lastUpdatedAt;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _pillars = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _recommendationArn;
        private ResourceStatus _status;

        /// <summary>
        /// Gets and sets the property AwsResourceArn. 
        /// <para>
        /// The AWS Resource ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AwsResourceArn
        {
            get { return this._awsResourceArn; }
            set { this._awsResourceArn = value; }
        }

        // Check to see if AwsResourceArn property is set
        internal bool IsSetAwsResourceArn()
        {
            return this._awsResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property CheckArn. 
        /// <para>
        /// The Check ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CheckArn
        {
            get { return this._checkArn; }
            set { this._checkArn = value; }
        }

        // Check to see if CheckArn property is set
        internal bool IsSetCheckArn()
        {
            return this._checkArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionStatus. 
        /// <para>
        /// The exclusion status of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExclusionStatus ExclusionStatus
        {
            get { return this._exclusionStatus; }
            set { this._exclusionStatus = value; }
        }

        // Check to see if ExclusionStatus property is set
        internal bool IsSetExclusionStatus()
        {
            return this._exclusionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the recommendation was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata associated with the recommendation
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// The Pillars that the Recommendation is optimizing
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> Pillars
        {
            get { return this._pillars; }
            set { this._pillars = value; }
        }

        // Check to see if Pillars property is set
        internal bool IsSetPillars()
        {
            return this._pillars != null && (this._pillars.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Recommendation ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecommendationArn
        {
            get { return this._recommendationArn; }
            set { this._recommendationArn = value; }
        }

        // Check to see if RecommendationArn property is set
        internal bool IsSetRecommendationArn()
        {
            return this._recommendationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceStatus Status
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