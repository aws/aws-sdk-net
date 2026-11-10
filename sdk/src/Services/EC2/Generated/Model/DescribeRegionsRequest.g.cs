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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeRegions operation. Describes the Regions
    /// that are enabled for your account, or all Regions. <para> For a list of the Regions
    /// supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-endpoints.html">Amazon
    /// EC2 service endpoints</a>. </para> <para> For information about enabling and disabling
    /// Regions for your account, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-regions.html">Specify
    /// which Amazon Web Services Regions your account can use</a> in the <i>Amazon Web Services
    /// Account Management Reference Guide</i>. </para> <note> <para> The order of the elements
    /// in the response, including those within nested structures, might vary. Applications
    /// should not assume the elements appear in a particular order. </para> </note>
    /// </summary>
    public partial class DescribeRegionsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        /// Indicates whether to display all Regions, including Regions that are disabled for
        /// your account.
        /// </para>
        /// </summary>
        public bool? AllRegions { get; set; }

        /// <summary>
        /// Checks to see if the AllRegions property is set.
        /// </summary>
        internal bool IsSetAllRegions() => this.AllRegions.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>endpoint</c> - The endpoint of the Region (for example, <c>ec2.us-east-1.amazonaws.com</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>opt-in-status</c> - The opt-in status of the Region (<c>opt-in-not-required</c>
        /// | <c>opted-in</c> | <c>not-opted-in</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region-name</c> - The name of the Region (for example, <c>us-east-1</c>).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The names of the Regions. You can specify any Regions, whether they are enabled and
        /// disabled for your account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RegionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegionNames property is set.
        /// </summary>
        internal bool IsSetRegionNames() => this.RegionNames != null && (this.RegionNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
