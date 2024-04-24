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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplicationTaskAssessment operation.
    /// Starts the replication task assessment for unsupported data types in the source database.
    /// 
    /// 
    ///  
    /// <para>
    /// You can only use this operation for a task if the following conditions are true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The task must be in the <c>stopped</c> state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The task must have successful connections to the source and target.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If either of these conditions are not met, an <c>InvalidResourceStateFault</c> error
    /// will result. 
    /// </para>
    ///  
    /// <para>
    /// For information about DMS task assessments, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.AssessmentReport.html">Creating
    /// a task assessment report</a> in the <i>Database Migration Service User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartReplicationTaskAssessmentRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _replicationTaskArn;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the replication task. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

    }
}