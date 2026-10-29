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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the ListDashboards operation. <important> <para> CloudTrail
    /// Lake will no longer be open to new customers starting May 31, 2026. If you would like
    /// to use CloudTrail Lake, sign up prior to that date. Existing customers can continue
    /// to use the service as normal. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-service-availability-change.html">CloudTrail
    /// Lake availability change</a>. </para> </important> <para> Returns information about
    /// all dashboards in the account, in the current Region. </para>
    /// </summary>
    public partial class ListDashboardsRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of dashboards to display on a single page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        ///  Specify a name prefix to filter on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token you can use to get the next page of dashboard results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Specify a dashboard type to filter on: <c>CUSTOM</c> or <c>MANAGED</c>. 
        /// </para>
        /// </summary>
        public DashboardType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
