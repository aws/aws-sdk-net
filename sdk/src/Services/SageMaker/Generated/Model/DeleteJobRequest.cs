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
    /// Container for the parameters to the DeleteJob operation.
    /// Deletes a job. This operation is idempotent. If the job is currently running, you
    /// must stop it before deleting it by calling <c>StopJob</c>.
    /// 
    ///  
    /// <para>
    /// The following operations are related to <c>DeleteJob</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StopJob</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeJob</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteJobRequest : AmazonSageMakerRequest
    {
        private JobCategory _jobCategory;
        private string _jobName;

        /// <summary>
        /// Gets and sets the property JobCategory. 
        /// <para>
        /// The category of the job to delete.
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
        /// The name of the job to delete.
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