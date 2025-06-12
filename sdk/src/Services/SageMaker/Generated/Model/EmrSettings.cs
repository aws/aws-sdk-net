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
    /// The configuration parameters that specify the IAM roles assumed by the execution role
    /// of SageMaker (assumable roles) and the cluster instances or job execution environments
    /// (execution roles or runtime roles) to manage and access resources required for running
    /// Amazon EMR clusters or Amazon EMR Serverless applications.
    /// </summary>
    public partial class EmrSettings
    {
        private List<string> _assumableRoleArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _executionRoleArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssumableRoleArns. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) of the IAM roles that the execution role
        /// of SageMaker can assume for performing operations or tasks related to Amazon EMR clusters
        /// or Amazon EMR Serverless applications. These roles define the permissions and access
        /// policies required when performing Amazon EMR-related operations, such as listing,
        /// connecting to, or terminating Amazon EMR clusters or Amazon EMR Serverless applications.
        /// They are typically used in cross-account access scenarios, where the Amazon EMR resources
        /// (clusters or serverless applications) are located in a different Amazon Web Services
        /// account than the SageMaker domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> AssumableRoleArns
        {
            get { return this._assumableRoleArns; }
            set { this._assumableRoleArns = value; }
        }

        // Check to see if AssumableRoleArns property is set
        internal bool IsSetAssumableRoleArns()
        {
            return this._assumableRoleArns != null && (this._assumableRoleArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArns. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) of the IAM roles used by the Amazon EMR cluster
        /// instances or job execution environments to access other Amazon Web Services services
        /// and resources needed during the runtime of your Amazon EMR or Amazon EMR Serverless
        /// workloads, such as Amazon S3 for data access, Amazon CloudWatch for logging, or other
        /// Amazon Web Services services based on the particular workload requirements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> ExecutionRoleArns
        {
            get { return this._executionRoleArns; }
            set { this._executionRoleArns = value; }
        }

        // Check to see if ExecutionRoleArns property is set
        internal bool IsSetExecutionRoleArns()
        {
            return this._executionRoleArns != null && (this._executionRoleArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}