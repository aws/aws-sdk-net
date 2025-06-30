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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutQueryDefinition operation.
    /// Creates or updates a query definition for CloudWatch Logs Insights. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">Analyzing
    /// Log Data with CloudWatch Logs Insights</a>.
    /// 
    ///  
    /// <para>
    /// To update a query definition, specify its <c>queryDefinitionId</c> in your request.
    /// The values of <c>name</c>, <c>queryString</c>, and <c>logGroupNames</c> are changed
    /// to the values that you specify in your update operation. No current values are retained
    /// from the current query definition. For example, imagine updating a current query definition
    /// that includes log groups. If you don't specify the <c>logGroupNames</c> parameter
    /// in your update operation, the query definition changes to contain no log groups.
    /// </para>
    ///  
    /// <para>
    /// You must have the <c>logs:PutQueryDefinition</c> permission to be able to perform
    /// this operation.
    /// </para>
    /// </summary>
    public partial class PutQueryDefinitionRequest : AmazonCloudWatchLogsRequest
    {
        private string _clientToken;
        private List<string> _logGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _queryDefinitionId;
        private QueryLanguage _queryLanguage;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used as an idempotency token, to avoid returning an exception if the service receives
        /// the same request twice because of a network error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupNames. 
        /// <para>
        /// Use this parameter to include specific log groups as part of your query definition.
        /// If your query uses the OpenSearch Service query language, you specify the log group
        /// names inside the <c>querystring</c> instead of here.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing query definition for the Logs Insights QL or OpenSearch
        /// Service PPL and you omit this parameter, then the updated definition will contain
        /// no log groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogGroupNames
        {
            get { return this._logGroupNames; }
            set { this._logGroupNames = value; }
        }

        // Check to see if LogGroupNames property is set
        internal bool IsSetLogGroupNames()
        {
            return this._logGroupNames != null && (this._logGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the query definition. If you are saving numerous query definitions, we
        /// recommend that you name them. This way, you can find the ones you want by using the
        /// first part of the name as a filter in the <c>queryDefinitionNamePrefix</c> parameter
        /// of <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeQueryDefinitions.html">DescribeQueryDefinitions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property QueryDefinitionId. 
        /// <para>
        /// If you are updating a query definition, use this parameter to specify the ID of the
        /// query definition that you want to update. You can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeQueryDefinitions.html">DescribeQueryDefinitions</a>
        /// to retrieve the IDs of your saved query definitions.
        /// </para>
        ///  
        /// <para>
        /// If you are creating a query definition, do not specify this parameter. CloudWatch
        /// generates a unique ID for the new query definition and include it in the response
        /// to this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string QueryDefinitionId
        {
            get { return this._queryDefinitionId; }
            set { this._queryDefinitionId = value; }
        }

        // Check to see if QueryDefinitionId property is set
        internal bool IsSetQueryDefinitionId()
        {
            return this._queryDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// Specify the query language to use for this query. The options are Logs Insights QL,
        /// OpenSearch PPL, and OpenSearch SQL. For more information about the query languages
        /// that CloudWatch Logs supports, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData_Languages.html">Supported
        /// query languages</a>.
        /// </para>
        /// </summary>
        public QueryLanguage QueryLanguage
        {
            get { return this._queryLanguage; }
            set { this._queryLanguage = value; }
        }

        // Check to see if QueryLanguage property is set
        internal bool IsSetQueryLanguage()
        {
            return this._queryLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to use for this definition. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}