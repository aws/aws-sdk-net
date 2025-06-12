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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationAggregatorSourcesStatus operation.
    /// Returns status information for sources within an aggregator. The status includes information
    /// about the last time Config verified authorization between the source account and an
    /// aggregator account. In case of a failure, the status contains the related error code
    /// or message.
    /// </summary>
    public partial class DescribeConfigurationAggregatorSourcesStatusRequest : AmazonConfigServiceRequest
    {
        private string _configurationAggregatorName;
        private int? _limit;
        private string _nextToken;
        private List<string> _updateStatus = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationAggregatorName
        {
            get { return this._configurationAggregatorName; }
            set { this._configurationAggregatorName = value; }
        }

        // Check to see if ConfigurationAggregatorName property is set
        internal bool IsSetConfigurationAggregatorName()
        {
            return this._configurationAggregatorName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of AggregatorSourceStatus returned on each page. The default is
        /// maximum. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// Filters the status type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid value FAILED indicates errors while moving data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid value SUCCEEDED indicates the data was successfully moved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid value OUTDATED indicates the data is not the most recent.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null && (this._updateStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}