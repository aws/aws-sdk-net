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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// This is the response object from the AddWorkload operation.
    /// </summary>
    public partial class AddWorkloadResponse : AmazonWebServiceResponse
    {
        private WorkloadConfiguration _workloadConfiguration;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property WorkloadConfiguration. 
        /// <para>
        /// The configuration settings of the workload. The value is the escaped JSON of the configuration.
        /// </para>
        /// </summary>
        public WorkloadConfiguration WorkloadConfiguration
        {
            get { return this._workloadConfiguration; }
            set { this._workloadConfiguration = value; }
        }

        // Check to see if WorkloadConfiguration property is set
        internal bool IsSetWorkloadConfiguration()
        {
            return this._workloadConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadId. 
        /// <para>
        /// The ID of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=38, Max=38)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}