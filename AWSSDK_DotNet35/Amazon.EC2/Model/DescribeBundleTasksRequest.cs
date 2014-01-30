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
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBundleTasks operation.
    /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
    /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
    /// image manifest name you provided to the bundle task. </para>
    /// </summary>
    public partial class DescribeBundleTasksRequest : AmazonEC2Request
    {
        private List<string> bundleIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more bundle task IDs. Default: Describes all your bundle tasks.
        ///  
        /// </summary>
        public List<string> BundleIds
        {
            get { return this.bundleIds; }
            set { this.bundleIds = value; }
        }

        // Check to see if BundleIds property is set
        internal bool IsSetBundleIds()
        {
            return this.bundleIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>bundle-id</c> - The ID of the bundle task. </li> <li> <c>error-code</c> - If the task failed, the error
        /// code returned. </li> <li> <c>error-message</c> - If the task failed, the error message returned. </li> <li> <c>instance-id</c> - The ID of
        /// the instance. </li> <li> <c>progress</c> - The level of task completion, as a percentage (for example, 20%). </li> <li> <c>s3-bucket</c> -
        /// The Amazon S3 bucket to store the AMI. </li> <li> <c>s3-prefix</c> - The beginning of the AMI name. </li> <li> <c>start-time</c> - The time
        /// the task started (for example, 2013-09-15T17:15:20.000Z). </li> <li> <c>state</c> - The state of the task (<c>pending</c> |
        /// <c>waiting-for-shutdown</c> | <c>bundling</c> | <c>storing</c> | <c>cancelling</c> | <c>complete</c> | <c>failed</c>). </li> <li>
        /// <c>update-time</c> - The time of the most recent update for the task. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
