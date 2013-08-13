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
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateJobResult
    {
        
        private Job job;

        /// <summary>
        /// A section of the response body that provides information about the job that is created.
        ///  
        /// </summary>
        public Job Job
        {
            get { return this.job; }
            set { this.job = value; }
        }

        /// <summary>
        /// Sets the Job property
        /// </summary>
        /// <param name="job">The value to set for the Job property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobResult WithJob(Job job)
        {
            this.job = job;
            return this;
        }
            

        // Check to see if Job property is set
        internal bool IsSetJob()
        {
            return this.job != null;
        }
    }
}
