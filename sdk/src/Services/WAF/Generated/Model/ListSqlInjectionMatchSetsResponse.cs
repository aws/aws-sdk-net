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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// The response to a <a>ListSqlInjectionMatchSets</a> request.
    /// </summary>
    public partial class ListSqlInjectionMatchSetsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<SqlInjectionMatchSetSummary> _sqlInjectionMatchSets = AWSConfigs.InitializeCollections ? new List<SqlInjectionMatchSetSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <a>SqlInjectionMatchSet</a> objects than the number that you specified
        /// for <c>Limit</c> in the request, the response includes a <c>NextMarker</c> value.
        /// To list more <c>SqlInjectionMatchSet</c> objects, submit another <c>ListSqlInjectionMatchSets</c>
        /// request, and specify the <c>NextMarker</c> value from the response in the <c>NextMarker</c>
        /// value in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property SqlInjectionMatchSets. 
        /// <para>
        /// An array of <a>SqlInjectionMatchSetSummary</a> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SqlInjectionMatchSetSummary> SqlInjectionMatchSets
        {
            get { return this._sqlInjectionMatchSets; }
            set { this._sqlInjectionMatchSets = value; }
        }

        // Check to see if SqlInjectionMatchSets property is set
        internal bool IsSetSqlInjectionMatchSets()
        {
            return this._sqlInjectionMatchSets != null && (this._sqlInjectionMatchSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}