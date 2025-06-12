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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// The result of <c>DescribeDomainAutoTunes</c> request. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
    /// target="_blank">Developer Guide</a> for more information.
    /// </summary>
    public partial class DescribeDomainAutoTunesResponse : AmazonWebServiceResponse
    {
        private List<AutoTune> _autoTunes = AWSConfigs.InitializeCollections ? new List<AutoTune>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoTunes. 
        /// <para>
        /// Specifies the list of setting adjustments that Auto-Tune has made to the domain. See
        /// the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank">Developer Guide</a> for more information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoTune> AutoTunes
        {
            get { return this._autoTunes; }
            set { this._autoTunes = value; }
        }

        // Check to see if AutoTunes property is set
        internal bool IsSetAutoTunes()
        {
            return this._autoTunes != null && (this._autoTunes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies an identifier to allow retrieval of paginated results.
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