/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJob operation.
    /// <para> This operation cancels a specified job. Only the job owner can
    /// cancel it. The operation fails if the job has already started or is
    /// complete. </para>
    /// </summary>
    /// <seealso cref="Amazon.ImportExport.AmazonImportExport.CancelJob"/>
    public class CancelJobRequest : AmazonWebServiceRequest
    {
        private string jobId;

        /// <summary>
        /// A unique identifier which refers to a particular job.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        /// <summary>
        /// Sets the JobId property
        /// </summary>
        /// <param name="jobId">The value to set for the JobId property </param>
        /// <returns>this instance</returns>
        public CancelJobRequest WithJobId(string jobId)
        {
            this.jobId = jobId;
            return this;
        }
            
        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;      
        }
    }
}
    
