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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Amazon Web Services resource that is associated with
    /// the activity that prompted GuardDuty to generate a finding.
    /// </summary>
    public partial class ResourceData
    {
        private AccessKey _accessKey;
        private ContainerFindingResource _container;
        private Ec2Instance _ec2Instance;
        private Ec2NetworkInterface _ec2NetworkInterface;
        private EksCluster _eksCluster;
        private KubernetesWorkload _kubernetesWorkload;
        private S3Bucket _s3Bucket;
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// Contains information about the IAM access key details of a user that involved in the
        /// GuardDuty finding.
        /// </para>
        /// </summary>
        public AccessKey AccessKey
        {
            get { return this._accessKey; }
            set { this._accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this._accessKey != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Contains detailed information about the container associated with the activity that
        /// prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public ContainerFindingResource Container
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
        /// Gets and sets the property Ec2Instance. 
        /// <para>
        /// Contains information about the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2Instance Ec2Instance
        {
            get { return this._ec2Instance; }
            set { this._ec2Instance = value; }
        }

        // Check to see if Ec2Instance property is set
        internal bool IsSetEc2Instance()
        {
            return this._ec2Instance != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2NetworkInterface. 
        /// <para>
        /// Contains information about the elastic network interface of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2NetworkInterface Ec2NetworkInterface
        {
            get { return this._ec2NetworkInterface; }
            set { this._ec2NetworkInterface = value; }
        }

        // Check to see if Ec2NetworkInterface property is set
        internal bool IsSetEc2NetworkInterface()
        {
            return this._ec2NetworkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property EksCluster. 
        /// <para>
        /// Contains detailed information about the Amazon EKS cluster associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public EksCluster EksCluster
        {
            get { return this._eksCluster; }
            set { this._eksCluster = value; }
        }

        // Check to see if EksCluster property is set
        internal bool IsSetEksCluster()
        {
            return this._eksCluster != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesWorkload. 
        /// <para>
        /// Contains detailed information about the Kubernetes workload associated with the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public KubernetesWorkload KubernetesWorkload
        {
            get { return this._kubernetesWorkload; }
            set { this._kubernetesWorkload = value; }
        }

        // Check to see if KubernetesWorkload property is set
        internal bool IsSetKubernetesWorkload()
        {
            return this._kubernetesWorkload != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Contains information about the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3Bucket S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// Contains information about the Amazon S3 object.
        /// </para>
        /// </summary>
        public S3Object S3Object
        {
            get { return this._s3Object; }
            set { this._s3Object = value; }
        }

        // Check to see if S3Object property is set
        internal bool IsSetS3Object()
        {
            return this._s3Object != null;
        }

    }
}