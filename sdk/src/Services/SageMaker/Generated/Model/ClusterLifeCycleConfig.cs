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
    /// The lifecycle configuration for a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterLifeCycleConfig
    {
        private string _onCreate;
        private string _sourceS3Uri;

        /// <summary>
        /// Gets and sets the property OnCreate. 
        /// <para>
        /// The file name of the entrypoint script of lifecycle scripts under <c>SourceS3Uri</c>.
        /// This entrypoint script runs during cluster creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OnCreate
        {
            get { return this._onCreate; }
            set { this._onCreate = value; }
        }

        // Check to see if OnCreate property is set
        internal bool IsSetOnCreate()
        {
            return this._onCreate != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Uri. 
        /// <para>
        /// An Amazon S3 bucket path where your lifecycle scripts are stored.
        /// </para>
        ///  <important> 
        /// <para>
        /// Make sure that the S3 bucket path starts with <c>s3://sagemaker-</c>. The <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-prerequisites.html#sagemaker-hyperpod-prerequisites-iam-role-for-hyperpod">IAM
        /// role for SageMaker HyperPod</a> has the managed <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/security-iam-awsmanpol-cluster.html">
        /// <c>AmazonSageMakerClusterInstanceRolePolicy</c> </a> attached, which allows access
        /// to S3 buckets with the specific prefix <c>sagemaker-</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string SourceS3Uri
        {
            get { return this._sourceS3Uri; }
            set { this._sourceS3Uri = value; }
        }

        // Check to see if SourceS3Uri property is set
        internal bool IsSetSourceS3Uri()
        {
            return this._sourceS3Uri != null;
        }

    }
}