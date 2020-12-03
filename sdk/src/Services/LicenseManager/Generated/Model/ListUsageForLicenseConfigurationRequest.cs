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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsageForLicenseConfiguration operation.
    /// Lists all license usage records for a license configuration, displaying license consumption
    /// details by resource at a selected point in time. Use this action to audit the current
    /// license consumption for any license inventory and configuration.
    /// </summary>
    public partial class ListUsageForLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private string _licenseConfigurationArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to scope the results. The following filters and logical operators are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resourceArn</code> - The ARN of the license configuration resource. Logical
        /// operators are <code>EQUALS</code> | <code>NOT_EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resourceType</code> - The resource type (<code>EC2_INSTANCE</code> | <code>EC2_HOST</code>
        /// | <code>EC2_AMI</code> | <code>SYSTEMS_MANAGER_MANAGED_INSTANCE</code>). Logical operators
        /// are <code>EQUALS</code> | <code>NOT_EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resourceAccount</code> - The ID of the account that owns the resource. Logical
        /// operators are <code>EQUALS</code> | <code>NOT_EQUALS</code>.
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

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseConfigurationArn
        {
            get { return this._licenseConfigurationArn; }
            set { this._licenseConfigurationArn = value; }
        }

        // Check to see if LicenseConfigurationArn property is set
        internal bool IsSetLicenseConfigurationArn()
        {
            return this._licenseConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}