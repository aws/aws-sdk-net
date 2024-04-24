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
    /// 
    /// </summary>
    public partial class CancelReplicationTaskAssessmentRunResponse : AmazonWebServiceResponse
    {
        private ReplicationTaskAssessmentRun _replicationTaskAssessmentRun;

        /// <summary>
        /// Gets and sets the property ReplicationTaskAssessmentRun. 
        /// <para>
        /// The <c>ReplicationTaskAssessmentRun</c> object for the canceled assessment run.
        /// </para>
        /// </summary>
        public ReplicationTaskAssessmentRun ReplicationTaskAssessmentRun
        {
            get { return this._replicationTaskAssessmentRun; }
            set { this._replicationTaskAssessmentRun = value; }
        }

        // Check to see if ReplicationTaskAssessmentRun property is set
        internal bool IsSetReplicationTaskAssessmentRun()
        {
            return this._replicationTaskAssessmentRun != null;
        }

    }
}