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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// This is the response object from the StartFailureModeAssessment operation.
    /// </summary>
    public partial class StartFailureModeAssessmentResponse : AmazonWebServiceResponse
    {
        private string _assessmentId;
        private AssessmentStatus _assessmentStatus;
        private string _serviceArn;
        private DateTime? _startedAt;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique identifier of the started assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The status of the started assessment.
        /// </para>
        /// </summary>
        public AssessmentStatus AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the assessment started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

    }
}