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
    /// Contains the response data from the PollForActivityTask operation.
    /// </summary>
    public partial class PollForActivityTaskResponse : AmazonWebServiceResponse
    {
        private ActivityTask _activityTask;

        /// <summary>
        /// Gets and sets the ActivityTask member
        /// </summary>
        public ActivityTask ActivityTask
        {
            get { return this._activityTask; }
            set { this._activityTask = value; }
        }

        // Check to see if ActivityTask property is set
        internal bool IsSetActivityTask()
        {
            return this._activityTask != null;
        }
    }
}