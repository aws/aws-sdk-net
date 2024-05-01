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
    /// Container for the parameters to the CancelReplicationTaskAssessmentRun operation.
    /// Cancels a single premigration assessment run.
    /// 
    ///  
    /// <para>
    /// This operation prevents any individual assessments from running if they haven't started
    /// running. It also attempts to cancel any individual assessments that are currently
    /// running.
    /// </para>
    /// </summary>
    public partial class CancelReplicationTaskAssessmentRunRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _replicationTaskAssessmentRunArn;

        /// <summary>
        /// Gets and sets the property ReplicationTaskAssessmentRunArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the premigration assessment run to be canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationTaskAssessmentRunArn
        {
            get { return this._replicationTaskAssessmentRunArn; }
            set { this._replicationTaskAssessmentRunArn = value; }
        }

        // Check to see if ReplicationTaskAssessmentRunArn property is set
        internal bool IsSetReplicationTaskAssessmentRunArn()
        {
            return this._replicationTaskAssessmentRunArn != null;
        }

    }
}