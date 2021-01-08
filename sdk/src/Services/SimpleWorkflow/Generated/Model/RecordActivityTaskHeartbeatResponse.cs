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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains the response data from the RecordActivityTaskHeartbeat operation.
    /// </summary>
    public partial class RecordActivityTaskHeartbeatResponse : AmazonWebServiceResponse
    {
        private ActivityTaskStatus _activityTaskStatus;

        /// <summary>
        /// Gets and sets the ActivityTaskStatus member
        /// </summary>
        public ActivityTaskStatus ActivityTaskStatus
        {
            get { return this._activityTaskStatus; }
            set { this._activityTaskStatus = value; }
        }

        // Check to see if ActivityTaskStatus property is set
        internal bool IsSetActivityTaskStatus()
        {
            return this._activityTaskStatus != null;
        }
    }
}