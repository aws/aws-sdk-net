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
    /// This is the response object from the BatchDescribeModelPackage operation.
    /// </summary>
    public partial class BatchDescribeModelPackageResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, BatchDescribeModelPackageError> _batchDescribeModelPackageErrorMap = AWSConfigs.InitializeCollections ? new Dictionary<string, BatchDescribeModelPackageError>() : null;
        private Dictionary<string, BatchDescribeModelPackageSummary> _modelPackageSummaries = AWSConfigs.InitializeCollections ? new Dictionary<string, BatchDescribeModelPackageSummary>() : null;

        /// <summary>
        /// Gets and sets the property BatchDescribeModelPackageErrorMap. 
        /// <para>
        /// A map of the resource and BatchDescribeModelPackageError objects reporting the error
        /// associated with describing the model package.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, BatchDescribeModelPackageError> BatchDescribeModelPackageErrorMap
        {
            get { return this._batchDescribeModelPackageErrorMap; }
            set { this._batchDescribeModelPackageErrorMap = value; }
        }

        // Check to see if BatchDescribeModelPackageErrorMap property is set
        internal bool IsSetBatchDescribeModelPackageErrorMap()
        {
            return this._batchDescribeModelPackageErrorMap != null && (this._batchDescribeModelPackageErrorMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelPackageSummaries. 
        /// <para>
        /// The summaries for the model package versions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, BatchDescribeModelPackageSummary> ModelPackageSummaries
        {
            get { return this._modelPackageSummaries; }
            set { this._modelPackageSummaries = value; }
        }

        // Check to see if ModelPackageSummaries property is set
        internal bool IsSetModelPackageSummaries()
        {
            return this._modelPackageSummaries != null && (this._modelPackageSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}