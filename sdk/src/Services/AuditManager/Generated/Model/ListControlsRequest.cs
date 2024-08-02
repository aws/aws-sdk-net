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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListControls operation.
    /// Returns a list of controls from Audit Manager.
    /// </summary>
    public partial class ListControlsRequest : AmazonAuditManagerRequest
    {
        private string _controlCatalogId;
        private ControlType _controlType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ControlCatalogId. 
        /// <para>
        /// A filter that narrows the list of controls to a specific resource from the Amazon
        /// Web Services Control Catalog. 
        /// </para>
        ///  
        /// <para>
        /// To use this parameter, specify the ARN of the Control Catalog resource. You can specify
        /// either a control domain, a control objective, or a common control. For information
        /// about how to find the ARNs for these resources, see <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_ListDomains.html">
        /// <c>ListDomains</c> </a>, <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_ListObjectives.html">
        /// <c>ListObjectives</c> </a>, and <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_ListCommonControls.html">
        /// <c>ListCommonControls</c> </a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only filter by one Control Catalog resource at a time. Specifying multiple
        /// resource ARNs isn’t currently supported. If you want to filter by more than one ARN,
        /// we recommend that you run the <c>ListControls</c> operation separately for each ARN.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// Alternatively, specify <c>UNCATEGORIZED</c> to list controls that aren't mapped to
        /// a Control Catalog resource. For example, this operation might return a list of custom
        /// controls that don't belong to any control domain or control objective.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=2048)]
        public string ControlCatalogId
        {
            get { return this._controlCatalogId; }
            set { this._controlCatalogId = value; }
        }

        // Check to see if ControlCatalogId property is set
        internal bool IsSetControlCatalogId()
        {
            return this._controlCatalogId != null;
        }

        /// <summary>
        /// Gets and sets the property ControlType. 
        /// <para>
        /// A filter that narrows the list of controls to a specific type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlType ControlType
        {
            get { return this._controlType; }
            set { this._controlType = value; }
        }

        // Check to see if ControlType property is set
        internal bool IsSetControlType()
        {
            return this._controlType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results on a page or for an API request call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The pagination token that's used to fetch the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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