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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The per-recommendation LoRA adapter details. Contains both the model package ARNs
    /// and Amazon S3 URIs for each adapter, regardless of which form was originally supplied
    /// in the request. When you supply only Amazon S3 URIs, Amazon SageMaker AI creates model
    /// packages on your behalf.
    /// </summary>
    public partial class AIRecommendationAdapterDetails
    {
        private List<AIAdapterModelPackageEntry> _modelPackageArns = AWSConfigs.InitializeCollections ? new List<AIAdapterModelPackageEntry>() : null;
        private List<AIAdapterS3Entry> _s3Uris = AWSConfigs.InitializeCollections ? new List<AIAdapterS3Entry>() : null;

        /// <summary>
        /// Gets and sets the property ModelPackageArns. 
        /// <para>
        /// The list of LoRA adapters with their model package ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<AIAdapterModelPackageEntry> ModelPackageArns
        {
            get { return this._modelPackageArns; }
            set { this._modelPackageArns = value; }
        }

        // Check to see if ModelPackageArns property is set
        internal bool IsSetModelPackageArns()
        {
            return this._modelPackageArns != null && (this._modelPackageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Uris. 
        /// <para>
        /// The list of LoRA adapters with their Amazon S3 URIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<AIAdapterS3Entry> S3Uris
        {
            get { return this._s3Uris; }
            set { this._s3Uris = value; }
        }

        // Check to see if S3Uris property is set
        internal bool IsSetS3Uris()
        {
            return this._s3Uris != null && (this._s3Uris.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}