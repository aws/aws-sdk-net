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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBundleTasks operation.
    /// Describes the specified bundle tasks or all of your bundle tasks.
    /// 
    ///  <note> 
    /// <para>
    /// Completed bundle tasks are listed for only a limited time. If your bundle task is
    /// no longer in the list, you can still register an AMI from it. Just use <c>RegisterImage</c>
    /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
    /// task.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeBundleTasksRequest : AmazonEC2Request
    {
        private List<string> _bundleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Gets and sets the property BundleIds. 
        /// <para>
        /// The bundle task IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your bundle tasks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BundleIds
        {
            get { return this._bundleIds; }
            set { this._bundleIds = value; }
        }

        // Check to see if BundleIds property is set
        internal bool IsSetBundleIds()
        {
            return this._bundleIds != null && (this._bundleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>bundle-id</c> - The ID of the bundle task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>error-code</c> - If the task failed, the error code returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>error-message</c> - If the task failed, the error message returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> - The ID of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>progress</c> - The level of task completion, as a percentage (for example, 20%).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3-bucket</c> - The Amazon S3 bucket to store the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3-prefix</c> - The beginning of the AMI name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start-time</c> - The time the task started (for example, 2013-09-15T17:15:20.000Z).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the task (<c>pending</c> | <c>waiting-for-shutdown</c>
        /// | <c>bundling</c> | <c>storing</c> | <c>cancelling</c> | <c>complete</c> | <c>failed</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>update-time</c> - The time of the most recent update for the task.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}