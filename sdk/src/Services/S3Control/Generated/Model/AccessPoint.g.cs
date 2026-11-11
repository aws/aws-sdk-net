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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// An access point used to access a bucket.
    /// </summary>
    public partial class AccessPoint
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN for the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 128)]
        public string AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointArn property is set.
        /// </summary>
        internal bool IsSetAccessPointArn() => this.AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The name or alias of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the bucket associated with this access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the S3 bucket associated with this
        /// access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string BucketAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketAccountId property is set.
        /// </summary>
        internal bool IsSetBucketAccountId() => this.BucketAccountId != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A unique identifier for the data source of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 191)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of the data source that the access point is attached to.
        /// </para>
        /// </summary>
        public string DataSourceType { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceType property is set.
        /// </summary>
        internal bool IsSetDataSourceType() => this.DataSourceType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkOrigin. 
        /// <para>
        /// Indicates whether this access point allows access from the public internet. If <c>VpcConfiguration</c>
        /// is specified for this access point, then <c>NetworkOrigin</c> is <c>VPC</c>, and the
        /// access point doesn't allow access from the public internet. Otherwise, <c>NetworkOrigin</c>
        /// is <c>Internet</c>, and the access point allows access from the public internet, subject
        /// to the access point and bucket access policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NetworkOrigin NetworkOrigin { get; set; }

        /// <summary>
        /// Checks to see if the NetworkOrigin property is set.
        /// </summary>
        internal bool IsSetNetworkOrigin() => this.NetworkOrigin != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The virtual private cloud (VPC) configuration for this access point, if one exists.
        /// </para>
        ///  <note> 
        /// <para>
        /// This element is empty if this access point is an Amazon S3 on Outposts access point
        /// that is used by other Amazon Web Services services.
        /// </para>
        ///  </note>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
