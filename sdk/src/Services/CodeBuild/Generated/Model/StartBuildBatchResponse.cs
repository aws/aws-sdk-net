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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the StartBuildBatch operation.
    /// </summary>
    public partial class StartBuildBatchResponse : AmazonWebServiceResponse
    {
        private BuildBatch _buildBatch;

        /// <summary>
        /// Gets and sets the property BuildBatch. 
        /// <para>
        /// A <c>BuildBatch</c> object that contains information about the batch build.
        /// </para>
        /// </summary>
        public BuildBatch BuildBatch
        {
            get { return this._buildBatch; }
            set { this._buildBatch = value; }
        }

        // Check to see if BuildBatch property is set
        internal bool IsSetBuildBatch()
        {
            return this._buildBatch != null;
        }

    }
}