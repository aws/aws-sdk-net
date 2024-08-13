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
    /// Contains the output of ReportTaskProgress.
    /// </summary>
    public partial class ReportTaskProgressResponse : AmazonWebServiceResponse
    {
        private bool? _canceled;

        /// <summary>
        /// Gets and sets the property Canceled. 
        /// <para>
        /// If true, the calling task runner should cancel processing of the task. The task runner
        /// does not need to call <a>SetTaskStatus</a> for canceled tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Canceled
        {
            get { return this._canceled; }
            set { this._canceled = value; }
        }

        // Check to see if Canceled property is set
        internal bool IsSetCanceled()
        {
            return this._canceled.HasValue; 
        }

    }
}