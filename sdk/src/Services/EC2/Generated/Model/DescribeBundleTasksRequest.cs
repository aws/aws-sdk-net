/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Describes one or more of your bundling tasks.
    /// 
    ///  <note>
    /// <para>
    /// Completed bundle tasks are listed for only a limited time. If your bundle task is
    /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
    /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
    /// task.
    /// </para>
    /// </note>
    /// </summary>
    public partial class DescribeBundleTasksRequest : AmazonEC2Request
    {
        private List<string> _bundleIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();

        /// <summary>
        /// Gets and sets the property BundleIds. 
        /// <para>
        /// One or more bundle task IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your bundle tasks.
        /// </para>
        /// </summary>
        public List<string> BundleIds
        {
            get { return this._bundleIds; }
            set { this._bundleIds = value; }
        }

        // Check to see if BundleIds property is set
        internal bool IsSetBundleIds()
        {
            return this._bundleIds != null && this._bundleIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>bundle-id</code> - The ID of the bundle task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>error-code</code> - If the task failed, the error code returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>error-message</code> - If the task failed, the error message returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-id</code> - The ID of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>progress</code> - The level of task completion, as a percentage (for example,
        /// 20%).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>s3-bucket</code> - The Amazon S3 bucket to store the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>s3-prefix</code> - The beginning of the AMI name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>start-time</code> - The time the task started (for example, 2013-09-15T17:15:20.000Z).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>state</code> - The state of the task (<code>pending</code> | <code>waiting-for-shutdown</code>
        /// | <code>bundling</code> | <code>storing</code> | <code>cancelling</code> | <code>complete</code>
        /// | <code>failed</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>update-time</code> - The time of the most recent update for the task.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

    }
}