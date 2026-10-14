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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the DescribeWorkload operation.
    /// </summary>
    public partial class DescribeWorkloadResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property WorkloadConfiguration. 
        /// <para>
        /// The configuration settings of the workload. The value is the escaped JSON of the configuration.
        /// </para>
        /// </summary>
        public WorkloadConfiguration WorkloadConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkloadConfiguration() => this.WorkloadConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkloadId. 
        /// <para>
        /// The ID of the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 38, Max = 38)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;

        /// <summary>
        /// Gets and sets the property WorkloadRemarks. 
        /// <para>
        /// If logging is supported for the resource type, shows whether the component has configured
        /// logs to be monitored.
        /// </para>
        /// </summary>
        public string WorkloadRemarks { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadRemarks property is set.
        /// </summary>
        internal bool IsSetWorkloadRemarks() => this.WorkloadRemarks != null;
    }
}
