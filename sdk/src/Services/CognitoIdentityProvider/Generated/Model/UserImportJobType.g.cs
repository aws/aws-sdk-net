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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A user import job in a user pool. Describes the status of user import with a CSV file.
    /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-using-import-tool.html">Importing
    /// users into user pools from a CSV file</a>.
    /// </summary>
    public partial class UserImportJobType
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// The role Amazon Resource Name (ARN) for the Amazon CloudWatch Logging role for the
        /// user import job. For more information, see "Creating the CloudWatch Logs IAM Role"
        /// in the Amazon Cognito Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsRoleArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsRoleArn() => this.CloudWatchLogsRoleArn != null;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date when the user import job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property CompletionMessage. 
        /// <para>
        /// The message returned when the user import job is completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string CompletionMessage { get; set; }

        /// <summary>
        /// Checks to see if the CompletionMessage property is set.
        /// </summary>
        internal bool IsSetCompletionMessage() => this.CompletionMessage != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property FailedUsers. 
        /// <para>
        /// The number of users that couldn't be imported.
        /// </para>
        /// </summary>
        public long? FailedUsers { get; set; }

        /// <summary>
        /// Checks to see if the FailedUsers property is set.
        /// </summary>
        internal bool IsSetFailedUsers() => this.FailedUsers.HasValue;

        /// <summary>
        /// Gets and sets the property ImportedUsers. 
        /// <para>
        /// The number of users that were successfully imported.
        /// </para>
        /// </summary>
        public long? ImportedUsers { get; set; }

        /// <summary>
        /// Checks to see if the ImportedUsers property is set.
        /// </summary>
        internal bool IsSetImportedUsers() => this.ImportedUsers.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the user import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The friendly name of the user import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property PasswordHashingAlgorithm. 
        /// <para>
        /// The password hashing algorithm used to generate the hashes in the CSV file for this
        /// import job.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>BCRYPT</c> | <c>SCRYPT</c> | <c>ARGON2ID</c> | <c>PBKDF2_SHA256</c>
        /// 
        /// </para>
        /// </summary>
        public PasswordHashingAlgorithmType PasswordHashingAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the PasswordHashingAlgorithm property is set.
        /// </summary>
        internal bool IsSetPasswordHashingAlgorithm() => this.PasswordHashingAlgorithm != null;

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// The pre-signed URL target for uploading the CSV file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PreSignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PreSignedUrl property is set.
        /// </summary>
        internal bool IsSetPreSignedUrl() => this.PreSignedUrl != null;

        /// <summary>
        /// Gets and sets the property SkippedUsers. 
        /// <para>
        /// The number of users that were skipped.
        /// </para>
        /// </summary>
        public long? SkippedUsers { get; set; }

        /// <summary>
        /// Checks to see if the SkippedUsers property is set.
        /// </summary>
        internal bool IsSetSkippedUsers() => this.SkippedUsers.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date when the user import job was started.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the user import job. One of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Created</c> - The job was created but not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c> - A transition state. You have started the job, but it has not begun
        /// importing users yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c> - The job has started, and users are being imported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopping</c> - You have stopped the job, but the job has not stopped importing
        /// users yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopped</c> - You have stopped the job, and the job has stopped importing users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Succeeded</c> - The job has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The job has stopped due to an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Expired</c> - You created a job, but did not start the job within 24-48 hours.
        /// All data associated with the job was deleted, and the job can't be started.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserImportJobStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that the users are being imported into.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
