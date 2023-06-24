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
    /// The configuration that determines how many retries are allowed for each failure type
    /// for a job.
    /// </summary>
    public partial class JobExecutionsRetryConfig
    {
        private List<RetryCriteria> _criteriaList = new List<RetryCriteria>();

        /// <summary>
        /// Gets and sets the property CriteriaList. 
        /// <para>
        /// The list of criteria that determines how many retries are allowed for each failure
        /// type for a job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<RetryCriteria> CriteriaList
        {
            get { return this._criteriaList; }
            set { this._criteriaList = value; }
        }

        // Check to see if CriteriaList property is set
        internal bool IsSetCriteriaList()
        {
            return this._criteriaList != null && this._criteriaList.Count > 0; 
        }

    }
}