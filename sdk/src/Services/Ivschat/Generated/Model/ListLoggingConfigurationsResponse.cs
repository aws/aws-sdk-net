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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
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
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// This is the response object from the ListLoggingConfigurations operation.
    /// </summary>
    public partial class ListLoggingConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<LoggingConfigurationSummary> _loggingConfigurations = AWSConfigs.InitializeCollections ? new List<LoggingConfigurationSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LoggingConfigurations. 
        /// <para>
        /// List of the matching logging configurations (summary information only). There is only
        /// one type of destination (<c>cloudWatchLogs</c>, <c>firehose</c>, or <c>s3</c>) in
        /// a <c>destinationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LoggingConfigurationSummary> LoggingConfigurations
        {
            get { return this._loggingConfigurations; }
            set { this._loggingConfigurations = value; }
        }

        // Check to see if LoggingConfigurations property is set
        internal bool IsSetLoggingConfigurations()
        {
            return this._loggingConfigurations != null && (this._loggingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more logging configurations than <c>maxResults</c>, use <c>nextToken</c>
        /// in the request to get the next set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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