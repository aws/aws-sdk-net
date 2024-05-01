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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateCreatedArtifact operation.
    /// Associates a created artifact of an AWS cloud resource, the target receiving the migration,
    /// with the migration task performed by a migration tool. This API has the following
    /// traits:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Migration tools can call the <c>AssociateCreatedArtifact</c> operation to indicate
    /// which AWS artifact is associated with a migration task.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The created artifact name must be provided in ARN (Amazon Resource Name) format which
    /// will contain information about type and region; for example: <c>arn:aws:ec2:us-east-1:488216288981:image/ami-6d0ba87b</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Examples of the AWS resource behind the created artifact are, AMI's, EC2 instance,
    /// or DMS endpoint, etc.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssociateCreatedArtifactRequest : AmazonMigrationHubRequest
    {
        private CreatedArtifact _createdArtifact;
        private bool? _dryRun;
        private string _migrationTaskName;
        private string _progressUpdateStream;

        /// <summary>
        /// Gets and sets the property CreatedArtifact. 
        /// <para>
        /// An ARN of the AWS resource related to the migration (e.g., AMI, EC2 instance, RDS
        /// instance, etc.) 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CreatedArtifact CreatedArtifact
        {
            get { return this._createdArtifact; }
            set { this._createdArtifact = value; }
        }

        // Check to see if CreatedArtifact property is set
        internal bool IsSetCreatedArtifact()
        {
            return this._createdArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Optional boolean flag to indicate whether any effect should take place. Used to test
        /// if the caller has permission to make the call.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task. <i>Do not store personal data
        /// in this field.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MigrationTaskName
        {
            get { return this._migrationTaskName; }
            set { this._migrationTaskName = value; }
        }

        // Check to see if MigrationTaskName property is set
        internal bool IsSetMigrationTaskName()
        {
            return this._migrationTaskName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// The name of the ProgressUpdateStream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ProgressUpdateStream
        {
            get { return this._progressUpdateStream; }
            set { this._progressUpdateStream = value; }
        }

        // Check to see if ProgressUpdateStream property is set
        internal bool IsSetProgressUpdateStream()
        {
            return this._progressUpdateStream != null;
        }

    }
}