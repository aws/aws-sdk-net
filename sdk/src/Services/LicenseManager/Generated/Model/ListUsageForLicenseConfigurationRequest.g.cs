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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsageForLicenseConfiguration operation. Lists
    /// all license usage records for a license configuration, displaying license consumption
    /// details by resource at a selected point in time. Use this action to audit the current
    /// license consumption for any license inventory and configuration.
    /// </summary>
    public partial class ListUsageForLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to scope the results. The following filters and logical operators are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resourceArn</c> - The ARN of the license configuration resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resourceType</c> - The resource type (<c>EC2_INSTANCE</c> | <c>EC2_HOST</c> |
        /// <c>EC2_AMI</c> | <c>SYSTEMS_MANAGER_MANAGED_INSTANCE</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resourceAccount</c> - The ID of the account that owns the resource.
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
        /// Gets and sets the property LicenseConfigurationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LicenseConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseConfigurationArn property is set.
        /// </summary>
        internal bool IsSetLicenseConfigurationArn() => this.LicenseConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
