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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details about the asset.
    /// </summary>
    public partial class AssetDetails
    {
        private ApiGatewayApiAsset _apiGatewayApiAsset;
        private LakeFormationDataPermissionAsset _lakeFormationDataPermissionAsset;
        private RedshiftDataShareAsset _redshiftDataShareAsset;
        private S3DataAccessAsset _s3DataAccessAsset;
        private S3SnapshotAsset _s3SnapshotAsset;

        /// <summary>
        /// Gets and sets the property ApiGatewayApiAsset. 
        /// <para>
        /// Information about the API Gateway API asset.
        /// </para>
        /// </summary>
        public ApiGatewayApiAsset ApiGatewayApiAsset
        {
            get { return this._apiGatewayApiAsset; }
            set { this._apiGatewayApiAsset = value; }
        }

        // Check to see if ApiGatewayApiAsset property is set
        internal bool IsSetApiGatewayApiAsset()
        {
            return this._apiGatewayApiAsset != null;
        }

        /// <summary>
        /// Gets and sets the property LakeFormationDataPermissionAsset. 
        /// <para>
        /// The AWS Lake Formation data permission that is the asset.
        /// </para>
        /// </summary>
        public LakeFormationDataPermissionAsset LakeFormationDataPermissionAsset
        {
            get { return this._lakeFormationDataPermissionAsset; }
            set { this._lakeFormationDataPermissionAsset = value; }
        }

        // Check to see if LakeFormationDataPermissionAsset property is set
        internal bool IsSetLakeFormationDataPermissionAsset()
        {
            return this._lakeFormationDataPermissionAsset != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDataShareAsset. 
        /// <para>
        /// The Amazon Redshift datashare that is the asset.
        /// </para>
        /// </summary>
        public RedshiftDataShareAsset RedshiftDataShareAsset
        {
            get { return this._redshiftDataShareAsset; }
            set { this._redshiftDataShareAsset = value; }
        }

        // Check to see if RedshiftDataShareAsset property is set
        internal bool IsSetRedshiftDataShareAsset()
        {
            return this._redshiftDataShareAsset != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataAccessAsset. 
        /// <para>
        /// The Amazon S3 data access that is the asset.
        /// </para>
        /// </summary>
        public S3DataAccessAsset S3DataAccessAsset
        {
            get { return this._s3DataAccessAsset; }
            set { this._s3DataAccessAsset = value; }
        }

        // Check to see if S3DataAccessAsset property is set
        internal bool IsSetS3DataAccessAsset()
        {
            return this._s3DataAccessAsset != null;
        }

        /// <summary>
        /// Gets and sets the property S3SnapshotAsset. 
        /// <para>
        /// The Amazon S3 object that is the asset.
        /// </para>
        /// </summary>
        public S3SnapshotAsset S3SnapshotAsset
        {
            get { return this._s3SnapshotAsset; }
            set { this._s3SnapshotAsset = value; }
        }

        // Check to see if S3SnapshotAsset property is set
        internal bool IsSetS3SnapshotAsset()
        {
            return this._s3SnapshotAsset != null;
        }

    }
}