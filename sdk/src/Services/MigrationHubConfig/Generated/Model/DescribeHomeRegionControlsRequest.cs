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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
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
    /// Container for the parameters to the DescribeHomeRegionControls operation.
    /// This API permits filtering on the <c>ControlId</c> and <c>HomeRegion</c> fields.
    /// </summary>
    public partial class DescribeHomeRegionControlsRequest : AmazonMigrationHubConfigRequest
    {
        private string _controlId;
        private string _homeRegion;
        private int? _maxResults;
        private string _nextToken;
        private Target _target;

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// The <c>ControlID</c> is a unique identifier string of your <c>HomeRegionControl</c>
        /// object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The name of the home region you'd like to view.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of filtering results to display per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// If a <c>NextToken</c> was returned by a previous call, more results are available.
        /// To retrieve the next page of results, make the call again using the returned token
        /// in <c>NextToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The target parameter specifies the identifier to which the home region is applied,
        /// which is always of type <c>ACCOUNT</c>. It applies the home region to the current
        /// <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        public Target Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}