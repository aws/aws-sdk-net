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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the GetOnClusterAppUIPresignedURL operation.
    /// The presigned URL properties for the cluster's application user interface.
    /// </summary>
    public partial class GetOnClusterAppUIPresignedURLRequest : AmazonElasticMapReduceRequest
    {
        private string _applicationId;
        private string _clusterId;
        private bool? _dryRun;
        private string _executionRoleArn;
        private OnClusterAppUIType _onClusterAppUIType;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID associated with the cluster's application user interface presigned
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The cluster ID associated with the cluster's application user interface presigned
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Determines if the user interface presigned URL is for a dry run.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN associated with the cluster's application user interface presigned
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property OnClusterAppUIType. 
        /// <para>
        /// The application UI type associated with the cluster's application user interface presigned
        /// URL.
        /// </para>
        /// </summary>
        public OnClusterAppUIType OnClusterAppUIType
        {
            get { return this._onClusterAppUIType; }
            set { this._onClusterAppUIType = value; }
        }

        // Check to see if OnClusterAppUIType property is set
        internal bool IsSetOnClusterAppUIType()
        {
            return this._onClusterAppUIType != null;
        }

    }
}