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
    /// Container for the parameters to the AssociateSourceResource operation.
    /// Associates a source resource with a migration task. For example, the source resource
    /// can be a source server, an application, or a migration wave.
    /// </summary>
    public partial class AssociateSourceResourceRequest : AmazonMigrationHubRequest
    {
        private bool? _dryRun;
        private string _migrationTaskName;
        private string _progressUpdateStream;
        private SourceResource _sourceResource;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// This is an optional parameter that you can use to test whether the call will succeed.
        /// Set this parameter to <c>true</c> to verify that you have the permissions that are
        /// required to make the call, and that you have specified the other parameters in the
        /// call correctly.
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
        /// A unique identifier that references the migration task. <i>Do not include sensitive
        /// data in this field.</i> 
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
        /// The name of the progress-update stream, which is used for access control as well as
        /// a namespace for migration-task names that is implicitly linked to your AWS account.
        /// The progress-update stream must uniquely identify the migration tool as it is used
        /// for all updates made by the tool; however, it does not need to be unique for each
        /// AWS account because it is scoped to the AWS account.
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

        /// <summary>
        /// Gets and sets the property SourceResource. 
        /// <para>
        /// The source resource that you want to associate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceResource SourceResource
        {
            get { return this._sourceResource; }
            set { this._sourceResource = value; }
        }

        // Check to see if SourceResource property is set
        internal bool IsSetSourceResource()
        {
            return this._sourceResource != null;
        }

    }
}