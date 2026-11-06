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
    /// This is the response object from the GetAccessPoint operation.
    /// </summary>
    public partial class GetAccessPointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The ARN of the access point.
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
        /// The name of the bucket associated with the specified access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the specified access point was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier for the data source of the access point.
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
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The VPC endpoint for the access point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the specified access point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
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
        ///  
        /// <para>
        /// This will always be true for an Amazon S3 on Outposts access point
        /// </para>
        /// </summary>
        public NetworkOrigin NetworkOrigin { get; set; }

        /// <summary>
        /// Checks to see if the NetworkOrigin property is set.
        /// </summary>
        internal bool IsSetNetworkOrigin() => this.NetworkOrigin != null;

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration.
        /// </summary>
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccessBlockConfiguration property is set.
        /// </summary>
        internal bool IsSetPublicAccessBlockConfiguration() => this.PublicAccessBlockConfiguration != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Contains the virtual private cloud (VPC) configuration for the specified access point.
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
