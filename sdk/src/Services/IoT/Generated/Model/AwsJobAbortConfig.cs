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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The criteria that determine when and how a job abort takes place.
    /// </summary>
    public partial class AwsJobAbortConfig
    {
        private List<AwsJobAbortCriteria> _abortCriteriaList = new List<AwsJobAbortCriteria>();

        /// <summary>
        /// Gets and sets the property AbortCriteriaList. 
        /// <para>
        /// The list of criteria that determine when and how to abort the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AwsJobAbortCriteria> AbortCriteriaList
        {
            get { return this._abortCriteriaList; }
            set { this._abortCriteriaList = value; }
        }

        // Check to see if AbortCriteriaList property is set
        internal bool IsSetAbortCriteriaList()
        {
            return this._abortCriteriaList != null && this._abortCriteriaList.Count > 0; 
        }

    }
}