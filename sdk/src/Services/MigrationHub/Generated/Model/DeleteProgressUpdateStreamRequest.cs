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
    /// Container for the parameters to the DeleteProgressUpdateStream operation.
    /// Deletes a progress update stream, including all of its tasks, which was previously
    /// created as an AWS resource used for access control. This API has the following traits:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The only parameter needed for <c>DeleteProgressUpdateStream</c> is the stream name
    /// (same as a <c>CreateProgressUpdateStream</c> call).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The call will return, and a background process will asynchronously delete the stream
    /// and all of its resources (tasks, associated resources, resource attributes, created
    /// artifacts).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the stream takes time to be deleted, it might still show up on a <c>ListProgressUpdateStreams</c>
    /// call.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateProgressUpdateStream</c>, <c>ImportMigrationTask</c>, <c>NotifyMigrationTaskState</c>,
    /// and all Associate[*] APIs related to the tasks belonging to the stream will throw
    /// "InvalidInputException" if the stream of the same name is in the process of being
    /// deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Once the stream and all of its resources are deleted, <c>CreateProgressUpdateStream</c>
    /// for a stream of the same name will succeed, and that stream will be an entirely new
    /// logical resource (without any resources associated with the old stream).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteProgressUpdateStreamRequest : AmazonMigrationHubRequest
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