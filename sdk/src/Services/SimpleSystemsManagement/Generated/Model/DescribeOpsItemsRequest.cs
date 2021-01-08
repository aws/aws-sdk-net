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
    /// Container for the parameters to the DescribeOpsItems operation.
    /// Query a set of OpsItems. You must have permission in AWS Identity and Access Management
    /// (IAM) to query a list of OpsItems. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
    /// started with OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
    /// remediate operational issues impacting the performance and health of their AWS resources.
    /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
    /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DescribeOpsItemsRequest : AmazonSimpleSystemsManagementRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<OpsItemFilter> _opsItemFilters = new List<OpsItemFilter>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// A token to start the list. Use this token to get the next set of results.
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
        /// Gets and sets the property OpsItemFilters. 
        /// <para>
        /// One or more filters to limit the response.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key: CreatedTime
        /// </para>
        ///  
        /// <para>
        /// Operations: GreaterThan, LessThan
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: LastModifiedBy
        /// </para>
        ///  
        /// <para>
        /// Operations: Contains, Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: LastModifiedTime
        /// </para>
        ///  
        /// <para>
        /// Operations: GreaterThan, LessThan
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: Priority
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: Source
        /// </para>
        ///  
        /// <para>
        /// Operations: Contains, Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: Status
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: Title
        /// </para>
        ///  
        /// <para>
        /// Operations: Contains
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: OperationalData*
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: OperationalDataKey
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: OperationalDataValue
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals, Contains
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: OpsItemId
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: ResourceId
        /// </para>
        ///  
        /// <para>
        /// Operations: Contains
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key: AutomationId
        /// </para>
        ///  
        /// <para>
        /// Operations: Equals
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// *If you filter the response by using the OperationalData operator, specify a key-value
        /// pair by using the following JSON format: {"key":"key_name","value":"a_value"}
        /// </para>
        /// </summary>
        public List<OpsItemFilter> OpsItemFilters
        {
            get { return this._opsItemFilters; }
            set { this._opsItemFilters = value; }
        }

        // Check to see if OpsItemFilters property is set
        internal bool IsSetOpsItemFilters()
        {
            return this._opsItemFilters != null && this._opsItemFilters.Count > 0; 
        }

    }
}