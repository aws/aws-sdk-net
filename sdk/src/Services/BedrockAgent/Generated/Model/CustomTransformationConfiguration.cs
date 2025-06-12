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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Settings for customizing steps in the data source content ingestion pipeline.
    /// 
    ///  
    /// <para>
    /// You can configure the data source to process documents with a Lambda function after
    /// they are parsed and converted into chunks. When you add a post-chunking transformation,
    /// the service stores chunked documents in an S3 bucket and invokes a Lambda function
    /// to process them.
    /// </para>
    ///  
    /// <para>
    /// To process chunked documents with a Lambda function, define an S3 bucket path for
    /// input and output objects, and a transformation that specifies the Lambda function
    /// to invoke. You can use the Lambda function to customize how chunks are split, and
    /// the metadata for each chunk. 
    /// </para>
    /// </summary>
    public partial class CustomTransformationConfiguration
    {
        private IntermediateStorage _intermediateStorage;
        private List<Transformation> _transformations = AWSConfigs.InitializeCollections ? new List<Transformation>() : null;

        /// <summary>
        /// Gets and sets the property IntermediateStorage. 
        /// <para>
        /// An S3 bucket path for input and output objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntermediateStorage IntermediateStorage
        {
            get { return this._intermediateStorage; }
            set { this._intermediateStorage = value; }
        }

        // Check to see if IntermediateStorage property is set
        internal bool IsSetIntermediateStorage()
        {
            return this._intermediateStorage != null;
        }

        /// <summary>
        /// Gets and sets the property Transformations. 
        /// <para>
        /// A Lambda function that processes documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<Transformation> Transformations
        {
            get { return this._transformations; }
            set { this._transformations = value; }
        }

        // Check to see if Transformations property is set
        internal bool IsSetTransformations()
        {
            return this._transformations != null && (this._transformations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}