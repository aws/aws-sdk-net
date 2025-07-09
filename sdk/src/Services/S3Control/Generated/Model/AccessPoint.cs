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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
        private string _accessPointArn;
        private string _alias;
        private string _bucket;
        private string _bucketAccountId;
        private string _dataSourceId;
        private string _dataSourceType;
        private string _name;
        private NetworkOrigin _networkOrigin;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN for the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=128)]
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
        /// The name or alias of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
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
        /// The name of the bucket associated with this access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// The Amazon Web Services account ID associated with the S3 bucket associated with this
        /// access point.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A unique identifier for the data source of the access point.
        /// </para>
        /// </summary>
        [AWSProperty(Max=191)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of the data source that the access point is attached to.
        /// </para>
        /// </summary>
        public string DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }

        // Check to see if DataSourceType property is set
        internal bool IsSetDataSourceType()
        {
            return this._dataSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Indicates whether this access point allows access from the public internet. If <c>VpcConfiguration</c>
        /// is specified for this access point, then <c>NetworkOrigin</c> is <c>VPC</c>, and the
        /// access point doesn't allow access from the public internet. Otherwise, <c>NetworkOrigin</c>
        /// is <c>Internet</c>, and the access point allows access from the public internet, subject
        /// to the access point and bucket access policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkOrigin NetworkOrigin
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
        public VpcConfiguration VpcConfiguration
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