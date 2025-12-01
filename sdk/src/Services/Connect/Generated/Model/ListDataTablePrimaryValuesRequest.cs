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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ListDataTablePrimaryValues operation.
    /// Lists all primary value combinations for a given data table. Returns the unique combinations
    /// of primary attribute values that identify records in the table. Up to 100 records
    /// are returned per request.
    /// </summary>
    public partial class ListDataTablePrimaryValuesRequest : AmazonConnectRequest
    {
        private string _dataTableId;
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private List<PrimaryAttributeValueFilter> _primaryAttributeValues = AWSConfigs.InitializeCollections ? new List<PrimaryAttributeValueFilter>() : null;
        private List<string> _recordIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table whose primary values should be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DataTableId
        {
            get { return this._dataTableId; }
            set { this._dataTableId = value; }
        }

        // Check to see if DataTableId property is set
        internal bool IsSetDataTableId()
        {
            return this._dataTableId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of data table primary values to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
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
        /// Gets and sets the property PrimaryAttributeValues. 
        /// <para>
        /// Optional filter to retrieve primary values matching specific criteria.
        /// </para>
        /// </summary>
        public List<PrimaryAttributeValueFilter> PrimaryAttributeValues
        {
            get { return this._primaryAttributeValues; }
            set { this._primaryAttributeValues = value; }
        }

        // Check to see if PrimaryAttributeValues property is set
        internal bool IsSetPrimaryAttributeValues()
        {
            return this._primaryAttributeValues != null && (this._primaryAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordIds. 
        /// <para>
        /// Optional list of specific record IDs to retrieve. Used for CloudFormation to effectively
        /// describe records by ID. If NextToken is provided, this parameter is ignored.
        /// </para>
        /// </summary>
        public List<string> RecordIds
        {
            get { return this._recordIds; }
            set { this._recordIds = value; }
        }

        // Check to see if RecordIds property is set
        internal bool IsSetRecordIds()
        {
            return this._recordIds != null && (this._recordIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}