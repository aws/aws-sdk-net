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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Returns configuration information about the specified Amazon S3 access point. S3
    /// access points are named network endpoints that are attached to buckets that you can
    /// use to perform S3 object operations.
    /// </summary>
    public partial class AwsS3AccessPointDetails
    {
        private string _accessPointArn;
        private string _alias;
        private string _bucket;
        private string _bucketAccountId;
        private string _name;
        private string _networkOrigin;
        private AwsS3AccountPublicAccessBlockDetails _publicAccessBlockConfiguration;
        private AwsS3AccessPointVpcConfigurationDetails _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the access point. 
        /// </para>
        /// </summary>
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        ///  The name or alias of the access point. 
        /// </para>
        /// </summary>
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The name of the S3 bucket associated with the specified access point. 
        /// </para>
        /// </summary>
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property BucketAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the S3 bucket associated with
        /// this access point. 
        /// </para>
        /// </summary>
        public string BucketAccountId
        {
            get { return this._bucketAccountId; }
            set { this._bucketAccountId = value; }
        }

        // Check to see if BucketAccountId property is set
        internal bool IsSetBucketAccountId()
        {
            return this._bucketAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the specified access point. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkOrigin. 
        /// <para>
        ///  Indicates whether this access point allows access from the public internet. 
        /// </para>
        /// </summary>
        public string NetworkOrigin
        {
            get { return this._networkOrigin; }
            set { this._networkOrigin = value; }
        }

        // Check to see if NetworkOrigin property is set
        internal bool IsSetNetworkOrigin()
        {
            return this._networkOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration.
        /// </summary>
        public AwsS3AccountPublicAccessBlockDetails PublicAccessBlockConfiguration
        {
            get { return this._publicAccessBlockConfiguration; }
            set { this._publicAccessBlockConfiguration = value; }
        }

        // Check to see if PublicAccessBlockConfiguration property is set
        internal bool IsSetPublicAccessBlockConfiguration()
        {
            return this._publicAccessBlockConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        ///  Contains the virtual private cloud (VPC) configuration for the specified access point.
        /// 
        /// </para>
        /// </summary>
        public AwsS3AccessPointVpcConfigurationDetails VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}