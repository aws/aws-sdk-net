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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Each job converts an input file into an output file or files. For more information,
    /// see the User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class Job
    {
        private string _arn;
        private BillingTagsSource _billingTagsSource;
        private DateTime? _createdAt;
        private int? _errorCode;
        private string _errorMessage;
        private string _id;
        private string _jobTemplate;
        private List<OutputGroupDetail> _outputGroupDetails = new List<OutputGroupDetail>();
        private string _queue;
        private string _role;
        private JobSettings _settings;
        private JobStatus _status;
        private Timing _timing;
        private Dictionary<string, string> _userMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. An identifier for this resource that is unique within
        /// all of AWS.
        /// </summary>
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
        /// Gets and sets the property BillingTagsSource.
        /// </summary>
        public BillingTagsSource BillingTagsSource
        {
            get { return this._billingTagsSource; }
            set { this._billingTagsSource = value; }
        }

        // Check to see if BillingTagsSource property is set
        internal bool IsSetBillingTagsSource()
        {
            return this._billingTagsSource != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in Unix epoch format in seconds, when
        /// the job got created.
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
        /// Gets and sets the property ErrorCode. Error code for the job
        /// </summary>
        public int ErrorCode
        {
            get { return this._errorCode.GetValueOrDefault(); }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message of Job
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. A portion of the job's ARN, unique within your AWS
        /// Elemental MediaConvert resources
        /// </summary>
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
        /// Gets and sets the property JobTemplate. The job template that the job is created from,
        /// if it is created from a job template.
        /// </summary>
        public string JobTemplate
        {
            get { return this._jobTemplate; }
            set { this._jobTemplate = value; }
        }

        // Check to see if JobTemplate property is set
        internal bool IsSetJobTemplate()
        {
            return this._jobTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property OutputGroupDetails. List of output group details
        /// </summary>
        public List<OutputGroupDetail> OutputGroupDetails
        {
            get { return this._outputGroupDetails; }
            set { this._outputGroupDetails = value; }
        }

        // Check to see if OutputGroupDetails property is set
        internal bool IsSetOutputGroupDetails()
        {
            return this._outputGroupDetails != null && this._outputGroupDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Queue. Optional. When you create a job, you can specify
        /// a queue to send it to. If you don't specify, the job will go to the default queue.
        /// For more about queues, see the User Guide topic at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
        /// </summary>
        public string Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property Role. The IAM role you use for creating this job. For details
        /// about permissions, see the User Guide topic at the User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Settings.
        /// </summary>
        public JobSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public JobStatus Status
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
        /// Gets and sets the property Timing.
        /// </summary>
        public Timing Timing
        {
            get { return this._timing; }
            set { this._timing = value; }
        }

        // Check to see if Timing property is set
        internal bool IsSetTiming()
        {
            return this._timing != null;
        }

        /// <summary>
        /// Gets and sets the property UserMetadata. User-defined metadata that you want to associate
        /// with an MediaConvert job. You specify metadata in key/value pairs.
        /// </summary>
        public Dictionary<string, string> UserMetadata
        {
            get { return this._userMetadata; }
            set { this._userMetadata = value; }
        }

        // Check to see if UserMetadata property is set
        internal bool IsSetUserMetadata()
        {
            return this._userMetadata != null && this._userMetadata.Count > 0; 
        }

    }
}