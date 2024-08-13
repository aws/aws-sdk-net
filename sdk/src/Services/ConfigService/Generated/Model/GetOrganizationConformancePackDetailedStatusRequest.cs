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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the GetOrganizationConformancePackDetailedStatus operation.
    /// Returns detailed status for each member account within an organization for a given
    /// organization conformance pack.
    /// </summary>
    public partial class GetOrganizationConformancePackDetailedStatusRequest : AmazonConfigServiceRequest
    {
        private OrganizationResourceDetailedStatusFilters _filters;
        private int? _limit;
        private string _nextToken;
        private string _organizationConformancePackName;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An <c>OrganizationResourceDetailedStatusFilters</c> object.
        /// </para>
        /// </summary>
        public OrganizationResourceDetailedStatusFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of <c>OrganizationConformancePackDetailedStatuses</c> returned
        /// on each page. If you do not specify a number, Config uses the default. The default
        /// is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string returned on a previous page that you use to get the next page
        /// of results in a paginated response. 
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

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackName. 
        /// <para>
        /// The name of organization conformance pack for which you want status details for member
        /// accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OrganizationConformancePackName
        {
            get { return this._organizationConformancePackName; }
            set { this._organizationConformancePackName = value; }
        }

        // Check to see if OrganizationConformancePackName property is set
        internal bool IsSetOrganizationConformancePackName()
        {
            return this._organizationConformancePackName != null;
        }

    }
}