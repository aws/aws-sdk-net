/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFindingsFeedback operation.
    /// Marks specified Amazon GuardDuty findings as useful or not useful.
    /// </summary>
    public partial class UpdateFindingsFeedbackRequest : AmazonGuardDutyRequest
    {
        private string _comments;
        private string _detectorId;
        private Feedback _feedback;
        private List<string> _findingIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// Additional feedback about the GuardDuty findings.
        /// </para>
        /// </summary>
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        // Check to see if Comments property is set
        internal bool IsSetComments()
        {
            return this._comments != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector that specifies the GuardDuty service whose findings you want
        /// to mark as useful or not useful.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Valid values: USEFUL | NOT_USEFUL
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Feedback Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null;
        }

        /// <summary>
        /// Gets and sets the property FindingIds. 
        /// <para>
        /// IDs of the findings that you want to mark as useful or not useful.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> FindingIds
        {
            get { return this._findingIds; }
            set { this._findingIds = value; }
        }

        // Check to see if FindingIds property is set
        internal bool IsSetFindingIds()
        {
            return this._findingIds != null && this._findingIds.Count > 0; 
        }

    }
}