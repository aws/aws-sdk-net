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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// The progress values reported by the <code>AssessmentProgress</code> response element.
    /// </summary>
    public partial class ReplicationTaskAssessmentRunProgress
    {
        private int? _individualAssessmentCompletedCount;
        private int? _individualAssessmentCount;

        /// <summary>
        /// Gets and sets the property IndividualAssessmentCompletedCount. 
        /// <para>
        /// The number of individual assessments that have completed, successfully or not.
        /// </para>
        /// </summary>
        public int IndividualAssessmentCompletedCount
        {
            get { return this._individualAssessmentCompletedCount.GetValueOrDefault(); }
            set { this._individualAssessmentCompletedCount = value; }
        }

        // Check to see if IndividualAssessmentCompletedCount property is set
        internal bool IsSetIndividualAssessmentCompletedCount()
        {
            return this._individualAssessmentCompletedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndividualAssessmentCount. 
        /// <para>
        /// The number of individual assessments that are specified to run.
        /// </para>
        /// </summary>
        public int IndividualAssessmentCount
        {
            get { return this._individualAssessmentCount.GetValueOrDefault(); }
            set { this._individualAssessmentCount = value; }
        }

        // Check to see if IndividualAssessmentCount property is set
        internal bool IsSetIndividualAssessmentCount()
        {
            return this._individualAssessmentCount.HasValue; 
        }

    }
}