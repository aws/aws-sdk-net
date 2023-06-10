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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the DescribePrincipalMapping operation.
    /// </summary>
    public partial class DescribePrincipalMappingResponse : AmazonWebServiceResponse
    {
        private string _dataSourceId;
        private string _groupId;
        private List<GroupOrderingIdSummary> _groupOrderingIdSummaries = new List<GroupOrderingIdSummary>();
        private string _indexId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// Shows the identifier of the data source to see information on the processing of <code>PUT</code>
        /// and <code>DELETE</code> actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Shows the identifier of the group to see information on the processing of <code>PUT</code>
        /// and <code>DELETE</code> actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupOrderingIdSummaries. 
        /// <para>
        /// Shows the following information on the processing of <code>PUT</code> and <code>DELETE</code>
        /// actions for mapping users to their groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Status—the status can be either <code>PROCESSING</code>, <code>SUCCEEDED</code>, <code>DELETING</code>,
        /// <code>DELETED</code>, or <code>FAILED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Last updated—the last date-time an action was updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Received—the last date-time an action was received or submitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ordering ID—the latest action that should process and apply after other actions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failure reason—the reason an action could not be processed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<GroupOrderingIdSummary> GroupOrderingIdSummaries
        {
            get { return this._groupOrderingIdSummaries; }
            set { this._groupOrderingIdSummaries = value; }
        }

        // Check to see if GroupOrderingIdSummaries property is set
        internal bool IsSetGroupOrderingIdSummaries()
        {
            return this._groupOrderingIdSummaries != null && this._groupOrderingIdSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// Shows the identifier of the index to see information on the processing of <code>PUT</code>
        /// and <code>DELETE</code> actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}