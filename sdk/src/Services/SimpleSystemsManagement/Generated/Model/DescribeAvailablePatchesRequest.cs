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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAvailablePatches operation.
    /// Lists all patches eligible to be included in a patch baseline.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, <c>DescribeAvailablePatches</c> supports only the Amazon Linux 1, Amazon
    /// Linux 2, and Windows Server operating systems.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeAvailablePatchesRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<PatchOrchestratorFilter> _filters = AWSConfigs.InitializeCollections ? new List<PatchOrchestratorFilter>() : null;
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
        ///  <b> <c>PATCH_SET</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>OS</c> | <c>APPLICATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>PRODUCT</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>WindowsServer2012</c> | <c>Office 2010</c> | <c>MicrosoftDefenderAntivirus</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>PRODUCT_FAMILY</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>Windows</c> | <c>Office</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>MSRC_SEVERITY</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>ServicePacks</c> | <c>Important</c> | <c>Moderate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CLASSIFICATION</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>ServicePacks</c> | <c>SecurityUpdates</c> | <c>DefinitionUpdates</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>PATCH_ID</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>KB123456</c> | <c>KB4516046</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Linux</b> 
        /// </para>
        ///  <important> 
        /// <para>
        /// When specifying filters for Linux patches, you must specify a key-pair for <c>PRODUCT</c>.
        /// For example, using the Command Line Interface (CLI), the following command fails:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws ssm describe-available-patches --filters Key=CVE_ID,Values=CVE-2018-3615</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// However, the following command succeeds:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws ssm describe-available-patches --filters Key=PRODUCT,Values=AmazonLinux2018.03
        /// Key=CVE_ID,Values=CVE-2018-3615</c> 
        /// </para>
        ///  </important> 
        /// <para>
        /// Supported keys for Linux managed node patches include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>PRODUCT</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>AmazonLinux2018.03</c> | <c>AmazonLinux2.0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NAME</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>kernel-headers</c> | <c>samba-python</c> | <c>php</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>SEVERITY</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>Critical</c> | <c>Important</c> | <c>Medium</c> | <c>Low</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>EPOCH</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>0</c> | <c>1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>VERSION</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>78.6.1</c> | <c>4.10.16</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>RELEASE</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>9.56.amzn1</c> | <c>1.amzn2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ARCH</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>i686</c> | <c>x86_64</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>REPOSITORY</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>Core</c> | <c>Updates</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ADVISORY_ID</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>ALAS-2018-1058</c> | <c>ALAS2-2021-1594</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CVE_ID</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>CVE-2018-3615</c> | <c>CVE-2020-1472</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>BUGZILLA_ID</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>1463241</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of patches to return (per page).
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