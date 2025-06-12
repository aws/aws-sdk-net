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
    /// Organization Recommendation Resource Summary
    /// </summary>
    public partial class OrganizationRecommendationResourceSummary
    {
        private string _accountId;
        private string _arn;
        private string _awsResourceId;
        private ExclusionStatus _exclusionStatus;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _recommendationArn;
        private string _regionCode;
        private ResourceStatus _status;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Recommendation Resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsResourceId. 
        /// <para>
        /// The AWS resource identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AwsResourceId
        {
            get { return this._awsResourceId; }
            set { this._awsResourceId = value; }
        }

        // Check to see if AwsResourceId property is set
        internal bool IsSetAwsResourceId()
        {
            return this._awsResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionStatus. 
        /// <para>
        /// The exclusion status of the Recommendation Resource
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Recommendation Resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the Recommendation Resource was last updated
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
        /// Metadata associated with the Recommendation Resource
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
        /// Gets and sets the property RegionCode. 
        /// <para>
        /// The AWS Region code that the Recommendation Resource is in
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=20)]
        public string RegionCode
        {
            get { return this._regionCode; }
            set { this._regionCode = value; }
        }

        // Check to see if RegionCode property is set
        internal bool IsSetRegionCode()
        {
            return this._regionCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Recommendation Resource
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