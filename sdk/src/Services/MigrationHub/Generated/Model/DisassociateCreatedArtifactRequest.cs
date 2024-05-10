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
    /// Container for the parameters to the DisassociateCreatedArtifact operation.
    /// Disassociates a created artifact of an AWS resource with a migration task performed
    /// by a migration tool that was previously associated. This API has the following traits:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A migration user can call the <c>DisassociateCreatedArtifacts</c> operation to disassociate
    /// a created AWS Artifact from a migration task.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The created artifact name must be provided in ARN (Amazon Resource Name) format which
    /// will contain information about type and region; for example: <c>arn:aws:ec2:us-east-1:488216288981:image/ami-6d0ba87b</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Examples of the AWS resource behind the created artifact are, AMI's, EC2 instance,
    /// or RDS instance, etc.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DisassociateCreatedArtifactRequest : AmazonMigrationHubRequest
    {
        private string _createdArtifactName;
        private bool? _dryRun;
        private string _migrationTaskName;
        private string _progressUpdateStream;

        /// <summary>
        /// Gets and sets the property CreatedArtifactName. 
        /// <para>
        /// An ARN of the AWS resource related to the migration (e.g., AMI, EC2 instance, RDS
        /// instance, etc.)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string CreatedArtifactName
        {
            get { return this._createdArtifactName; }
            set { this._createdArtifactName = value; }
        }

        // Check to see if CreatedArtifactName property is set
        internal bool IsSetCreatedArtifactName()
        {
            return this._createdArtifactName != null;
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
        /// Unique identifier that references the migration task to be disassociated with the
        /// artifact. <i>Do not store personal data in this field.</i> 
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