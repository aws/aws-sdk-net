/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Additional details about a resource related to a finding.
    /// </summary>
    public partial class ResourceDetails
    {
        private AwsCloudFrontDistributionDetails _awsCloudFrontDistribution;
        private AwsEc2InstanceDetails _awsEc2Instance;
        private AwsElbv2LoadBalancerDetails _awsElbv2LoadBalancer;
        private AwsIamAccessKeyDetails _awsIamAccessKey;
        private AwsIamRoleDetails _awsIamRole;
        private AwsKmsKeyDetails _awsKmsKey;
        private AwsLambdaFunctionDetails _awsLambdaFunction;
        private AwsS3BucketDetails _awsS3Bucket;
        private AwsSnsTopicDetails _awsSnsTopic;
        private AwsSqsQueueDetails _awsSqsQueue;
        private ContainerDetails _container;
        private Dictionary<string, string> _other = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AwsCloudFrontDistribution. 
        /// <para>
        /// Details about a CloudFront distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionDetails AwsCloudFrontDistribution
        {
            get { return this._awsCloudFrontDistribution; }
            set { this._awsCloudFrontDistribution = value; }
        }

        // Check to see if AwsCloudFrontDistribution property is set
        internal bool IsSetAwsCloudFrontDistribution()
        {
            return this._awsCloudFrontDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2Instance. 
        /// <para>
        /// Details about an Amazon EC2 instance related to a finding.
        /// </para>
        /// </summary>
        public AwsEc2InstanceDetails AwsEc2Instance
        {
            get { return this._awsEc2Instance; }
            set { this._awsEc2Instance = value; }
        }

        // Check to see if AwsEc2Instance property is set
        internal bool IsSetAwsEc2Instance()
        {
            return this._awsEc2Instance != null;
        }

        /// <summary>
        /// Gets and sets the property AwsElbv2LoadBalancer. 
        /// <para>
        /// Details about a load balancer.
        /// </para>
        /// </summary>
        public AwsElbv2LoadBalancerDetails AwsElbv2LoadBalancer
        {
            get { return this._awsElbv2LoadBalancer; }
            set { this._awsElbv2LoadBalancer = value; }
        }

        // Check to see if AwsElbv2LoadBalancer property is set
        internal bool IsSetAwsElbv2LoadBalancer()
        {
            return this._awsElbv2LoadBalancer != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamAccessKey. 
        /// <para>
        /// Details about an IAM access key related to a finding.
        /// </para>
        /// </summary>
        public AwsIamAccessKeyDetails AwsIamAccessKey
        {
            get { return this._awsIamAccessKey; }
            set { this._awsIamAccessKey = value; }
        }

        // Check to see if AwsIamAccessKey property is set
        internal bool IsSetAwsIamAccessKey()
        {
            return this._awsIamAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamRole. 
        /// <para>
        /// Details about an IAM role.
        /// </para>
        /// </summary>
        public AwsIamRoleDetails AwsIamRole
        {
            get { return this._awsIamRole; }
            set { this._awsIamRole = value; }
        }

        // Check to see if AwsIamRole property is set
        internal bool IsSetAwsIamRole()
        {
            return this._awsIamRole != null;
        }

        /// <summary>
        /// Gets and sets the property AwsKmsKey. 
        /// <para>
        /// Details about a KMS key.
        /// </para>
        /// </summary>
        public AwsKmsKeyDetails AwsKmsKey
        {
            get { return this._awsKmsKey; }
            set { this._awsKmsKey = value; }
        }

        // Check to see if AwsKmsKey property is set
        internal bool IsSetAwsKmsKey()
        {
            return this._awsKmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property AwsLambdaFunction. 
        /// <para>
        /// Details about a Lambda function.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionDetails AwsLambdaFunction
        {
            get { return this._awsLambdaFunction; }
            set { this._awsLambdaFunction = value; }
        }

        // Check to see if AwsLambdaFunction property is set
        internal bool IsSetAwsLambdaFunction()
        {
            return this._awsLambdaFunction != null;
        }

        /// <summary>
        /// Gets and sets the property AwsS3Bucket. 
        /// <para>
        /// Details about an Amazon S3 Bucket related to a finding.
        /// </para>
        /// </summary>
        public AwsS3BucketDetails AwsS3Bucket
        {
            get { return this._awsS3Bucket; }
            set { this._awsS3Bucket = value; }
        }

        // Check to see if AwsS3Bucket property is set
        internal bool IsSetAwsS3Bucket()
        {
            return this._awsS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSnsTopic. 
        /// <para>
        /// Details about an SNS topic.
        /// </para>
        /// </summary>
        public AwsSnsTopicDetails AwsSnsTopic
        {
            get { return this._awsSnsTopic; }
            set { this._awsSnsTopic = value; }
        }

        // Check to see if AwsSnsTopic property is set
        internal bool IsSetAwsSnsTopic()
        {
            return this._awsSnsTopic != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSqsQueue. 
        /// <para>
        /// Details about an SQS queue.
        /// </para>
        /// </summary>
        public AwsSqsQueueDetails AwsSqsQueue
        {
            get { return this._awsSqsQueue; }
            set { this._awsSqsQueue = value; }
        }

        // Check to see if AwsSqsQueue property is set
        internal bool IsSetAwsSqsQueue()
        {
            return this._awsSqsQueue != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Details about a container resource related to a finding.
        /// </para>
        /// </summary>
        public ContainerDetails Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property Other. 
        /// <para>
        /// Details about a resource that doesn't have a specific type defined.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Other
        {
            get { return this._other; }
            set { this._other = value; }
        }

        // Check to see if Other property is set
        internal bool IsSetOther()
        {
            return this._other != null && this._other.Count > 0; 
        }

    }
}