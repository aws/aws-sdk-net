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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details about the asset.
    /// </summary>
    public partial class AssetDetails
    {
        /// <summary>
        /// Gets and sets the property ApiGatewayApiAsset. 
        /// <para>
        /// Information about the API Gateway API asset.
        /// </para>
        /// </summary>
        public ApiGatewayApiAsset ApiGatewayApiAsset { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayApiAsset property is set.
        /// </summary>
        internal bool IsSetApiGatewayApiAsset() => this.ApiGatewayApiAsset != null;

        /// <summary>
        /// Gets and sets the property LakeFormationDataPermissionAsset. 
        /// <para>
        /// The AWS Lake Formation data permission that is the asset.
        /// </para>
        /// </summary>
        public LakeFormationDataPermissionAsset LakeFormationDataPermissionAsset { get; set; }

        /// <summary>
        /// Checks to see if the LakeFormationDataPermissionAsset property is set.
        /// </summary>
        internal bool IsSetLakeFormationDataPermissionAsset() => this.LakeFormationDataPermissionAsset != null;

        /// <summary>
        /// Gets and sets the property RedshiftDataShareAsset. 
        /// <para>
        /// The Amazon Redshift datashare that is the asset.
        /// </para>
        /// </summary>
        public RedshiftDataShareAsset RedshiftDataShareAsset { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDataShareAsset property is set.
        /// </summary>
        internal bool IsSetRedshiftDataShareAsset() => this.RedshiftDataShareAsset != null;

        /// <summary>
        /// Gets and sets the property S3DataAccessAsset. 
        /// <para>
        /// The Amazon S3 data access that is the asset.
        /// </para>
        /// </summary>
        public S3DataAccessAsset S3DataAccessAsset { get; set; }

        /// <summary>
        /// Checks to see if the S3DataAccessAsset property is set.
        /// </summary>
        internal bool IsSetS3DataAccessAsset() => this.S3DataAccessAsset != null;

        /// <summary>
        /// Gets and sets the property S3SnapshotAsset. 
        /// <para>
        /// The Amazon S3 object that is the asset.
        /// </para>
        /// </summary>
        public S3SnapshotAsset S3SnapshotAsset { get; set; }

        /// <summary>
        /// Checks to see if the S3SnapshotAsset property is set.
        /// </summary>
        internal bool IsSetS3SnapshotAsset() => this.S3SnapshotAsset != null;
    }
}
