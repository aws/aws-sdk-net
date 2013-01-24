/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Returns information about the  DescribePipelinesResult response and response metadata.
    /// </summary>
    public class DescribePipelinesResponse : AmazonWebServiceResponse
    {
        private DescribePipelinesResult describePipelinesResult;

        /// <summary>
        /// Gets and sets the DescribePipelinesResult property.
        /// Contains the output from the DescribePipelines action.
        /// </summary>
        public DescribePipelinesResult DescribePipelinesResult
        {
            get
            {
                if(this.describePipelinesResult == null)
                {
                    this.describePipelinesResult = new DescribePipelinesResult();
                }

                return this.describePipelinesResult;
            }
            set { this.describePipelinesResult = value; }
        }
    }
}
    
