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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeModelPackagingJob operation.
    /// Describes an Amazon Lookout for Vision model packaging job. 
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:DescribeModelPackagingJob</c>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <i>Using your Amazon Lookout for Vision model on an edge
    /// device</i> in the Amazon Lookout for Vision Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DescribeModelPackagingJobRequest : AmazonLookoutforVisionRequest
    {
        private string _jobName;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name for the model packaging job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that contains the model packaging job that you want to describe.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}