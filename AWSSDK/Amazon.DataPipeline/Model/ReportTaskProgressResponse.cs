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
    /// Returns information about the  ReportTaskProgressResult response and response metadata.
    /// </summary>
    public class ReportTaskProgressResponse : AmazonWebServiceResponse
    {
        private ReportTaskProgressResult reportTaskProgressResult;

        /// <summary>
        /// Gets and sets the ReportTaskProgressResult property.
        /// Contains the output from the ReportTaskProgress action.
        /// </summary>
        public ReportTaskProgressResult ReportTaskProgressResult
        {
            get
            {
                if(this.reportTaskProgressResult == null)
                {
                    this.reportTaskProgressResult = new ReportTaskProgressResult();
                }

                return this.reportTaskProgressResult;
            }
            set { this.reportTaskProgressResult = value; }
        }
    }
}
    
