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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetResourceProfile operation.
    /// </summary>
    public partial class GetResourceProfileResponse : AmazonWebServiceResponse
    {
        private DateTime? _profileUpdatedAt;
        private int? _sensitivityScore;
        private bool? _sensitivityScoreOverridden;
        private ResourceStatistics _statistics;

        /// <summary>
        /// Gets and sets the property ProfileUpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie most recently
        /// recalculated sensitive data discovery statistics and details for the bucket. If the
        /// bucket's sensitivity score is calculated automatically, this includes the score.
        /// </para>
        /// </summary>
        public DateTime ProfileUpdatedAt
        {
            get { return this._profileUpdatedAt.GetValueOrDefault(); }
            set { this._profileUpdatedAt = value; }
        }

        // Check to see if ProfileUpdatedAt property is set
        internal bool IsSetProfileUpdatedAt()
        {
            return this._profileUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitivityScore. 
        /// <para>
        /// The current sensitivity score for the bucket, ranging from -1 (no analysis due to
        /// an error) to 100 (sensitive). By default, this score is calculated automatically based
        /// on the amount of data that Amazon Macie has analyzed in the bucket and the amount
        /// of sensitive data that Macie has found in the bucket.
        /// </para>
        /// </summary>
        public int SensitivityScore
        {
            get { return this._sensitivityScore.GetValueOrDefault(); }
            set { this._sensitivityScore = value; }
        }

        // Check to see if SensitivityScore property is set
        internal bool IsSetSensitivityScore()
        {
            return this._sensitivityScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitivityScoreOverridden. 
        /// <para>
        /// Specifies whether the bucket's current sensitivity score was set manually. If this
        /// value is true, the score was manually changed to 100. If this value is false, the
        /// score was calculated automatically by Amazon Macie.
        /// </para>
        /// </summary>
        public bool SensitivityScoreOverridden
        {
            get { return this._sensitivityScoreOverridden.GetValueOrDefault(); }
            set { this._sensitivityScoreOverridden = value; }
        }

        // Check to see if SensitivityScoreOverridden property is set
        internal bool IsSetSensitivityScoreOverridden()
        {
            return this._sensitivityScoreOverridden.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The sensitive data discovery statistics for the bucket. The statistics capture the
        /// results of automated sensitive data discovery activities that Amazon Macie has performed
        /// for the bucket.
        /// </para>
        /// </summary>
        public ResourceStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

    }
}