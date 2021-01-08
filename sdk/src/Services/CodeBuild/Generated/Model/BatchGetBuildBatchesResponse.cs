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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetBuildBatches operation.
    /// </summary>
    public partial class BatchGetBuildBatchesResponse : AmazonWebServiceResponse
    {
        private List<BuildBatch> _buildBatches = new List<BuildBatch>();
        private List<string> _buildBatchesNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property BuildBatches. 
        /// <para>
        /// An array of <code>BuildBatch</code> objects that represent the retrieved batch builds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<BuildBatch> BuildBatches
        {
            get { return this._buildBatches; }
            set { this._buildBatches = value; }
        }

        // Check to see if BuildBatches property is set
        internal bool IsSetBuildBatches()
        {
            return this._buildBatches != null && this._buildBatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BuildBatchesNotFound. 
        /// <para>
        /// An array that contains the identifiers of any batch builds that are not found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> BuildBatchesNotFound
        {
            get { return this._buildBatchesNotFound; }
            set { this._buildBatchesNotFound = value; }
        }

        // Check to see if BuildBatchesNotFound property is set
        internal bool IsSetBuildBatchesNotFound()
        {
            return this._buildBatchesNotFound != null && this._buildBatchesNotFound.Count > 0; 
        }

    }
}