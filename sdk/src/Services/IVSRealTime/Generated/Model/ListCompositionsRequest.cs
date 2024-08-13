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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the ListCompositions operation.
    /// Gets summary information about all Compositions in your account, in the AWS region
    /// where the API request is processed.
    /// </summary>
    public partial class ListCompositionsRequest : AmazonIVSRealTimeRequest
    {
        private string _filterByEncoderConfigurationArn;
        private string _filterByStageArn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FilterByEncoderConfigurationArn. 
        /// <para>
        /// Filters the Composition list to match the specified EncoderConfiguration attached
        /// to at least one of its output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FilterByEncoderConfigurationArn
        {
            get { return this._filterByEncoderConfigurationArn; }
            set { this._filterByEncoderConfigurationArn = value; }
        }

        // Check to see if FilterByEncoderConfigurationArn property is set
        internal bool IsSetFilterByEncoderConfigurationArn()
        {
            return this._filterByEncoderConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterByStageArn. 
        /// <para>
        /// Filters the Composition list to match the specified Stage ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FilterByStageArn
        {
            get { return this._filterByStageArn; }
            set { this._filterByStageArn = value; }
        }

        // Check to see if FilterByStageArn property is set
        internal bool IsSetFilterByStageArn()
        {
            return this._filterByStageArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return. Default: 100.
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
        /// The first Composition to retrieve. This is used for pagination; see the <c>nextToken</c>
        /// response field.
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