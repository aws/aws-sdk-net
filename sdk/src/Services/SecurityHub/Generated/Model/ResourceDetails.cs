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
    /// Provides additional details about the resource.
    /// </summary>
    public partial class ResourceDetails
    {
        private AwsEc2InstanceDetails _awsEc2Instance;
        private AwsIamAccessKeyDetails _awsIamAccessKey;
        private AwsS3BucketDetails _awsS3Bucket;
        private ContainerDetails _container;
        private Dictionary<string, string> _other = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AwsEc2Instance. 
        /// <para>
        /// The details of an AWS EC2 instance.
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
        /// Gets and sets the property AwsIamAccessKey. 
        /// <para>
        /// AWS IAM access key details related to a finding.
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
        /// Gets and sets the property AwsS3Bucket. 
        /// <para>
        /// The details of an AWS S3 Bucket.
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
        /// Gets and sets the property Container. 
        /// <para>
        /// Container details related to a finding.
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
        /// The details of a resource that does not have a specific sub-field for the resource
        /// type defined.
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