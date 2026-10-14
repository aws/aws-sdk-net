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

namespace Amazon.MigrationHubConfig.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHomeRegionControls operation. This API
    /// permits filtering on the <c>ControlId</c> and <c>HomeRegion</c> fields.
    /// </summary>
    public partial class DescribeHomeRegionControlsRequest : AmazonMigrationHubConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// The <c>ControlID</c> is a unique identifier string of your <c>HomeRegionControl</c>
        /// object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ControlId { get; set; }

        /// <summary>
        /// Checks to see if the ControlId property is set.
        /// </summary>
        internal bool IsSetControlId() => this.ControlId != null;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The name of the home region you'd like to view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of filtering results to display per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a <c>NextToken</c> was returned by a previous call, more results are available.
        /// To retrieve the next page of results, make the call again using the returned token
        /// in <c>NextToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target parameter specifies the identifier to which the home region is applied,
        /// which is always of type <c>ACCOUNT</c>. It applies the home region to the current
        /// <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        public Target Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
