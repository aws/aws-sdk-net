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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Returns configuration information about the specified Amazon S3 access point. S3
    /// access points are named network endpoints that are attached to buckets that you can
    /// use to perform S3 object operations.
    /// </summary>
    public partial class AwsS3AccessPointDetails
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the access point. 
        /// </para>
        /// </summary>
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        ///  The name or alias of the access point. 
        /// </para>
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The name of the S3 bucket associated with the specified access point. 
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the S3 bucket associated with
        /// this access point. 
        /// </para>
        /// </summary>
        public string BucketAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketAccountId property is set.
        /// </summary>
        internal bool IsSetBucketAccountId() => this.BucketAccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the specified access point. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkOrigin. 
        /// <para>
        ///  Indicates whether this access point allows access from the public internet. 
        /// </para>
        /// </summary>
        public string NetworkOrigin { get; set; }

        /// <summary>
        /// Checks to see if the NetworkOrigin property is set.
        /// </summary>
        internal bool IsSetNetworkOrigin() => this.NetworkOrigin != null;

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration.
        /// </summary>
        public AwsS3AccountPublicAccessBlockDetails PublicAccessBlockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccessBlockConfiguration property is set.
        /// </summary>
        internal bool IsSetPublicAccessBlockConfiguration() => this.PublicAccessBlockConfiguration != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        ///  Contains the virtual private cloud (VPC) configuration for the specified access point.
        /// 
        /// </para>
        /// </summary>
        public AwsS3AccessPointVpcConfigurationDetails VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
