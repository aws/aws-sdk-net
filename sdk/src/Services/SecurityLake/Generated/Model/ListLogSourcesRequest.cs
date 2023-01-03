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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the ListLogSources operation.
    /// Retrieves the log sources in the current Amazon Web Services Region.
    /// </summary>
    public partial class ListLogSourcesRequest : AmazonSecurityLakeRequest
    {
        private List<string> _inputOrder = new List<string>();
        private Dictionary<string, Dictionary<string, List<string>>> _listAllDimensions = new Dictionary<string, Dictionary<string, List<string>>>();
        private List<string> _listSingleDimension = new List<string>();
        private Dictionary<string, List<string>> _listTwoDimensions = new Dictionary<string, List<string>>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InputOrder. 
        /// <para>
        /// Lists the log sources in input order, namely Region, source type, and member account.
        /// </para>
        /// </summary>
        public List<string> InputOrder
        {
            get { return this._inputOrder; }
            set { this._inputOrder = value; }
        }

        // Check to see if InputOrder property is set
        internal bool IsSetInputOrder()
        {
            return this._inputOrder != null && this._inputOrder.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListAllDimensions. 
        /// <para>
        /// List the view of log sources for enabled Amazon Security Lake accounts for specific
        /// Amazon Web Services sources from specific accounts and specific Regions.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> ListAllDimensions
        {
            get { return this._listAllDimensions; }
            set { this._listAllDimensions = value; }
        }

        // Check to see if ListAllDimensions property is set
        internal bool IsSetListAllDimensions()
        {
            return this._listAllDimensions != null && this._listAllDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListSingleDimension. 
        /// <para>
        /// List the view of log sources for enabled Security Lake accounts for all Amazon Web
        /// Services sources from specific accounts or specific Regions.
        /// </para>
        /// </summary>
        public List<string> ListSingleDimension
        {
            get { return this._listSingleDimension; }
            set { this._listSingleDimension = value; }
        }

        // Check to see if ListSingleDimension property is set
        internal bool IsSetListSingleDimension()
        {
            return this._listSingleDimension != null && this._listSingleDimension.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListTwoDimensions. 
        /// <para>
        /// Lists the view of log sources for enabled Security Lake accounts for specific Amazon
        /// Web Services sources from specific accounts or specific Regions.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> ListTwoDimensions
        {
            get { return this._listTwoDimensions; }
            set { this._listTwoDimensions = value; }
        }

        // Check to see if ListTwoDimensions property is set
        internal bool IsSetListTwoDimensions()
        {
            return this._listTwoDimensions != null && this._listTwoDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of accounts for which the log sources are displayed.
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
        /// If nextToken is returned, there are more results available. You can repeat the call
        /// using the returned token to retrieve the next page.
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