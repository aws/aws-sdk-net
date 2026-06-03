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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the StopJob operation.
    /// Stops a running job. When you call <c>StopJob</c>, Amazon SageMaker sets the job status
    /// to <c>Stopping</c>. After the job stops, the status changes to <c>Stopped</c>. Partial
    /// results may be available in the output location if the job was in progress. To delete
    /// a stopped job, call <c>DeleteJob</c>.
    /// 
    ///  
    /// <para>
    /// The following operations are related to <c>StopJob</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteJob</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StopJobRequest : AmazonSageMakerRequest
    {
        private JobCategory _jobCategory;
        private string _jobName;

        /// <summary>
        /// Gets and sets the property JobCategory. 
        /// <para>
        /// The category of the job to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobCategory JobCategory
        {
            get { return this._jobCategory; }
            set { this._jobCategory = value; }
        }

        // Check to see if JobCategory property is set
        internal bool IsSetJobCategory()
        {
            return this._jobCategory != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

    }
}