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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output of DescribePipelines.
    /// </summary>
    public partial class DescribePipelinesResponse : AmazonWebServiceResponse
    {
        private List<PipelineDescription> _pipelineDescriptionList = AWSConfigs.InitializeCollections ? new List<PipelineDescription>() : null;

        /// <summary>
        /// Gets and sets the property PipelineDescriptionList. 
        /// <para>
        /// An array of descriptions for the specified pipelines.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PipelineDescription> PipelineDescriptionList
        {
            get { return this._pipelineDescriptionList; }
            set { this._pipelineDescriptionList = value; }
        }

        // Check to see if PipelineDescriptionList property is set
        internal bool IsSetPipelineDescriptionList()
        {
            return this._pipelineDescriptionList != null && (this._pipelineDescriptionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}