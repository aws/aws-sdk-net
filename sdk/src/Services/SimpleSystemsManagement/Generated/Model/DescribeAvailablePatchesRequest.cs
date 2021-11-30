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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAvailablePatches operation.
    /// Lists all patches eligible to be included in a patch baseline.
    /// </summary>
    public partial class DescribeAvailablePatchesRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<PatchOrchestratorFilter> _filters = new List<PatchOrchestratorFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Each element in the array is a structure containing a key-value pair.
        /// </para>
        ///  
        /// <para>
        ///  <b>Windows Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Supported keys for Windows Server managed node patches include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>PATCH_SET</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>OS</code> | <code>APPLICATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>PRODUCT</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>WindowsServer2012</code> | <code>Office 2010</code> | <code>MicrosoftDefenderAntivirus</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>PRODUCT_FAMILY</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>Windows</code> | <code>Office</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>MSRC_SEVERITY</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>ServicePacks</code> | <code>Important</code> | <code>Moderate</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>CLASSIFICATION</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>ServicePacks</code> | <code>SecurityUpdates</code> | <code>DefinitionUpdates</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>PATCH_ID</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>KB123456</code> | <code>KB4516046</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Linux</b> 
        /// </para>
        ///  <important> 
        /// <para>
        /// When specifying filters for Linux patches, you must specify a key-pair for <code>PRODUCT</code>.
        /// For example, using the Command Line Interface (CLI), the following command fails:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws ssm describe-available-patches --filters Key=CVE_ID,Values=CVE-2018-3615</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// However, the following command succeeds:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws ssm describe-available-patches --filters Key=PRODUCT,Values=AmazonLinux2018.03
        /// Key=CVE_ID,Values=CVE-2018-3615</code> 
        /// </para>
        ///  </important> 
        /// <para>
        /// Supported keys for Linux managed node patches include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>PRODUCT</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>AmazonLinux2018.03</code> | <code>AmazonLinux2.0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>NAME</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>kernel-headers</code> | <code>samba-python</code> | <code>php</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>SEVERITY</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>Critical</code> | <code>Important</code> | <code>Medium</code>
        /// | <code>Low</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>EPOCH</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>0</code> | <code>1</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>VERSION</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>78.6.1</code> | <code>4.10.16</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>RELEASE</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>9.56.amzn1</code> | <code>1.amzn2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>ARCH</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>i686</code> | <code>x86_64</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>REPOSITORY</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>Core</code> | <code>Updates</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>ADVISORY_ID</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>ALAS-2018-1058</code> | <code>ALAS2-2021-1594</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>CVE_ID</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>CVE-2018-3615</code> | <code>CVE-2020-1472</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>BUGZILLA_ID</code> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <code>1463241</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<PatchOrchestratorFilter> Filters
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of patches to return (per page).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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