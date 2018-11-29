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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information for a work team.
    /// </summary>
    public partial class LabelingJobForWorkteamSummary
    {
        private DateTime? _creationTime;
        private string _jobReferenceCode;
        private LabelCountersForWorkteam _labelCounters;
        private string _labelingJobName;
        private string _workRequesterAccountId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the labeling job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobReferenceCode. 
        /// <para>
        /// A unique identifier for a labeling job. You can use this to refer to a specific labeling
        /// job.
        /// </para>
        /// </summary>
        public string JobReferenceCode
        {
            get { return this._jobReferenceCode; }
            set { this._jobReferenceCode = value; }
        }

        // Check to see if JobReferenceCode property is set
        internal bool IsSetJobReferenceCode()
        {
            return this._jobReferenceCode != null;
        }

        /// <summary>
        /// Gets and sets the property LabelCounters. 
        /// <para>
        /// Provides information about the progress of a labeling job.
        /// </para>
        /// </summary>
        public LabelCountersForWorkteam LabelCounters
        {
            get { return this._labelCounters; }
            set { this._labelCounters = value; }
        }

        // Check to see if LabelCounters property is set
        internal bool IsSetLabelCounters()
        {
            return this._labelCounters != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobName. 
        /// <para>
        /// The name of the labeling job that the work team is assigned to.
        /// </para>
        /// </summary>
        public string LabelingJobName
        {
            get { return this._labelingJobName; }
            set { this._labelingJobName = value; }
        }

        // Check to see if LabelingJobName property is set
        internal bool IsSetLabelingJobName()
        {
            return this._labelingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkRequesterAccountId.
        /// </summary>
        public string WorkRequesterAccountId
        {
            get { return this._workRequesterAccountId; }
            set { this._workRequesterAccountId = value; }
        }

        // Check to see if WorkRequesterAccountId property is set
        internal bool IsSetWorkRequesterAccountId()
        {
            return this._workRequesterAccountId != null;
        }

    }
}