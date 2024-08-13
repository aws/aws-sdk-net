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
    /// Container for the parameters to the CreateProgressUpdateStream operation.
    /// Creates a progress update stream which is an AWS resource used for access control
    /// as well as a namespace for migration task names that is implicitly linked to your
    /// AWS account. It must uniquely identify the migration tool as it is used for all updates
    /// made by the tool; however, it does not need to be unique for each AWS account because
    /// it is scoped to the AWS account.
    /// </summary>
    public partial class CreateProgressUpdateStreamRequest : AmazonMigrationHubRequest
    {
        private bool? _dryRun;
        private string _progressUpdateStreamName;

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
        /// Gets and sets the property ProgressUpdateStreamName. 
        /// <para>
        /// The name of the ProgressUpdateStream. <i>Do not store personal data in this field.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ProgressUpdateStreamName
        {
            get { return this._progressUpdateStreamName; }
            set { this._progressUpdateStreamName = value; }
        }

        // Check to see if ProgressUpdateStreamName property is set
        internal bool IsSetProgressUpdateStreamName()
        {
            return this._progressUpdateStreamName != null;
        }

    }
}