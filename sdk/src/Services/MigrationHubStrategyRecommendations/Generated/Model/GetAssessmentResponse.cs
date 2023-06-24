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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// This is the response object from the GetAssessment operation.
    /// </summary>
    public partial class GetAssessmentResponse : AmazonWebServiceResponse
    {
        private List<AssessmentTarget> _assessmentTargets = new List<AssessmentTarget>();
        private DataCollectionDetails _dataCollectionDetails;
        private string _id;

        /// <summary>
        /// Gets and sets the property AssessmentTargets. 
        /// <para>
        /// List of criteria for assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<AssessmentTarget> AssessmentTargets
        {
            get { return this._assessmentTargets; }
            set { this._assessmentTargets = value; }
        }

        // Check to see if AssessmentTargets property is set
        internal bool IsSetAssessmentTargets()
        {
            return this._assessmentTargets != null && this._assessmentTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataCollectionDetails. 
        /// <para>
        ///  Detailed information about the assessment. 
        /// </para>
        /// </summary>
        public DataCollectionDetails DataCollectionDetails
        {
            get { return this._dataCollectionDetails; }
            set { this._dataCollectionDetails = value; }
        }

        // Check to see if DataCollectionDetails property is set
        internal bool IsSetDataCollectionDetails()
        {
            return this._dataCollectionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID for the specific assessment task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=52)]
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

    }
}