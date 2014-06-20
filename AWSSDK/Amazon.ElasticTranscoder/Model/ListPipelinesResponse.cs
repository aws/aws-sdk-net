/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using Amazon.Runtime;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Returns information about the ListPipelinesResult response and response metadata.
    /// </summary>
    public class ListPipelinesResponse : AmazonWebServiceResponse
    {
        private ListPipelinesResult _listPipelinesResult;

        /// <summary>
        /// Gets and sets the ListPipelinesResult property.
        /// Represents the output of a ListPipelines operation.
        /// </summary>
        public ListPipelinesResult ListPipelinesResult
        {
            get
            {
                if(this._listPipelinesResult == null)
                {
                    this._listPipelinesResult = new ListPipelinesResult();
                }
                return this._listPipelinesResult;
            }
            set { this._listPipelinesResult = value; }
        }
    }
}