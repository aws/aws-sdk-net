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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the UpdateClusterSchedulerConfig operation.
    /// </summary>
    public partial class UpdateClusterSchedulerConfigResponse : AmazonWebServiceResponse
    {
        private string _clusterSchedulerConfigArn;
        private int? _clusterSchedulerConfigVersion;

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigArn. 
        /// <para>
        /// ARN of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ClusterSchedulerConfigArn
        {
            get { return this._clusterSchedulerConfigArn; }
            set { this._clusterSchedulerConfigArn = value; }
        }

        // Check to see if ClusterSchedulerConfigArn property is set
        internal bool IsSetClusterSchedulerConfigArn()
        {
            return this._clusterSchedulerConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigVersion. 
        /// <para>
        /// Version of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ClusterSchedulerConfigVersion
        {
            get { return this._clusterSchedulerConfigVersion; }
            set { this._clusterSchedulerConfigVersion = value; }
        }

        // Check to see if ClusterSchedulerConfigVersion property is set
        internal bool IsSetClusterSchedulerConfigVersion()
        {
            return this._clusterSchedulerConfigVersion.HasValue; 
        }

    }
}