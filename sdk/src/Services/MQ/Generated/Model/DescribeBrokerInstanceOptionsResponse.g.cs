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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MQ.Model
{
    /// <summary>
    /// This is the response object from the DescribeBrokerInstanceOptions operation.
    /// </summary>
    public partial class DescribeBrokerInstanceOptionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BrokerInstanceOptions. 
        /// <para>
        /// List of available broker instance options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BrokerInstanceOption> BrokerInstanceOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<BrokerInstanceOption>() : null;

        /// <summary>
        /// Checks to see if the BrokerInstanceOptions property is set.
        /// </summary>
        internal bool IsSetBrokerInstanceOptions() => this.BrokerInstanceOptions != null && (this.BrokerInstanceOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Required. The maximum number of instance options that can be returned per page (20
        /// by default). This value must be an integer from 5 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that specifies the next page of results Amazon MQ should return. To request
        /// the first page, leave nextToken empty.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
