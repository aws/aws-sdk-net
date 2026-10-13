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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRegion operation. Retrieves details about
    /// a specific Region enabled in an IAM Identity Center instance. Details include the
    /// Region name, current status (ACTIVE, ADDING, or REMOVING), the date when the Region
    /// was added, and whether it is the primary Region. The request must be made from one
    /// of the enabled Regions of the IAM Identity Center instance. <para> The following actions
    /// are related to <c>DescribeRegion</c>: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_AddRegion.html">
    /// AddRegion</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_RemoveRegion.html">RemoveRegion</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListRegions.html">ListRegions</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class DescribeRegionRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Amazon Web Services Region to retrieve information about. The Region
        /// name must be 1-32 characters long and follow the pattern of Amazon Web Services Region
        /// names (for example, us-east-1).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;
    }
}
