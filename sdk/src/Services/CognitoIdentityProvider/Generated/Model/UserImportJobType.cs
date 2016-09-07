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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The user import job type.
    /// </summary>
    public partial class UserImportJobType
    {
        private string _cloudWatchLogsRoleArn;
        private DateTime? _completionDate;
        private string _completionMessage;
        private DateTime? _creationDate;
        private long? _failedUsers;
        private long? _importedUsers;
        private string _jobId;
        private string _jobName;
        private string _preSignedUrl;
        private long? _skippedUsers;
        private DateTime? _startDate;
        private UserImportJobStatusType _status;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// The role ARN for the Amazon CloudWatch Logging role for the user import job. For more
        /// information, see "Creating the CloudWatch Logs IAM Role" in the Amazon Cognito Developer
        /// Guide.
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn
        {
            get { return this._cloudWatchLogsRoleArn; }
            set { this._cloudWatchLogsRoleArn = value; }
        }

        // Check to see if CloudWatchLogsRoleArn property is set
        internal bool IsSetCloudWatchLogsRoleArn()
        {
            return this._cloudWatchLogsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date when the user imoprt job was completed.
        /// </para>
        /// </summary>
        public DateTime CompletionDate
        {
            get { return this._completionDate.GetValueOrDefault(); }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletionMessage. 
        /// <para>
        /// The message returned when the user import job is completed.
        /// </para>
        /// </summary>
        public string CompletionMessage
        {
            get { return this._completionMessage; }
            set { this._completionMessage = value; }
        }

        // Check to see if CompletionMessage property is set
        internal bool IsSetCompletionMessage()
        {
            return this._completionMessage != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the user import job was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedUsers. 
        /// <para>
        /// The number of users that could not be imported.
        /// </para>
        /// </summary>
        public long FailedUsers
        {
            get { return this._failedUsers.GetValueOrDefault(); }
            set { this._failedUsers = value; }
        }

        // Check to see if FailedUsers property is set
        internal bool IsSetFailedUsers()
        {
            return this._failedUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportedUsers. 
        /// <para>
        /// The number of users that were successfully imported.
        /// </para>
        /// </summary>
        public long ImportedUsers
        {
            get { return this._importedUsers.GetValueOrDefault(); }
            set { this._importedUsers = value; }
        }

        // Check to see if ImportedUsers property is set
        internal bool IsSetImportedUsers()
        {
            return this._importedUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID for the user import job.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name for the user import job.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// The pre-signed URL to be used to upload the .csv file.
        /// </para>
        /// </summary>
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SkippedUsers. 
        /// <para>
        /// The number of users that were skipped.
        /// </para>
        /// </summary>
        public long SkippedUsers
        {
            get { return this._skippedUsers.GetValueOrDefault(); }
            set { this._skippedUsers = value; }
        }

        // Check to see if SkippedUsers property is set
        internal bool IsSetSkippedUsers()
        {
            return this._skippedUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date when the user import job was started.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the user import job. One of the following:
        /// </para>
        ///  <ul> <li>Created - The job was created but not started.</li> <li>Pending - A transition
        /// state. You have started the job, but it has not begun importing users yet.</li> <li>InProgress
        /// - The job has started, and users are being imported.</li> <li>Stopping - You have
        /// stopped the job, but the job has not stopped importing users yet.</li> <li>Stopped
        /// - You have stopped the job, and the job has stopped importing users.</li> <li>Succeeded
        /// - The job has completed successfully.</li> <li>Failed - The job has stopped due to
        /// an error.</li> <li>Expired - You created a job, but did not start the job within 24-48
        /// hours. All data associated with the job was deleted, and the job cannot be started.</li>
        /// </ul>
        /// </summary>
        public UserImportJobStatusType Status
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
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool that the users are being imported into.
        /// </para>
        /// </summary>
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}