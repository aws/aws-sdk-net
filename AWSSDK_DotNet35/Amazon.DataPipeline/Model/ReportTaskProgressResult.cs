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
using Amazon.Runtime;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains the output from the ReportTaskProgress action.</para>
    /// </summary>
    public partial class ReportTaskProgressResult : AmazonWebServiceResponse
    {
        
        private bool? canceled;

        /// <summary>
        /// If <c>True</c>, the calling task runner should cancel processing of the task. The task runner does not need to call <a>SetTaskStatus</a> for
        /// canceled tasks.
        ///  
        /// </summary>
        public bool Canceled
        {
            get { return this.canceled ?? default(bool); }
            set { this.canceled = value; }
        }

        // Check to see if Canceled property is set
        internal bool IsSetCanceled()
        {
            return this.canceled.HasValue;
        }
    }
}
