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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the GetAccessPoint operation.
    /// </summary>
    public partial class GetAccessPointResponse : AmazonWebServiceResponse
    {
        private string _accessPointArn;
        private string _alias;
        private string _bucket;
        private string _bucketAccountId;
        private DateTime? _creationDate;
        private Dictionary<string, string> _endpoints = new Dictionary<string, string>();
        private string _name;
        private NetworkOrigin _networkOrigin;
        private PublicAccessBlockConfiguration _publicAccessBlockConfiguration;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN of the access point.
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
        /// The name of the bucket associated with the specified access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the specified access point was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The VPC endpoint for the access point.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the specified access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
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
        /// Indicates whether this access point allows access from the public internet. If <code>VpcConfiguration</code>
        /// is specified for this access point, then <code>NetworkOrigin</code> is <code>VPC</code>,
        /// and the access point doesn't allow access from the public internet. Otherwise, <code>NetworkOrigin</code>
        /// is <code>Internet</code>, and the access point allows access from the public internet,
        /// subject to the access point and bucket access policies.
        /// </para>
        ///  
        /// <para>
        /// This will always be true for an Amazon S3 on Outposts access point
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PublicAccessBlockConfiguration.
        /// </summary>
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration
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
        /// Contains the virtual private cloud (VPC) configuration for the specified access point.
        /// </para>
        ///  <note> 
        /// <para>
        /// This element is empty if this access point is an Amazon S3 on Outposts access point
        /// that is used by other Amazon Web Services.
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