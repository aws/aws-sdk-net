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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the ListRegexPatternSets operation.
    /// </summary>
    public partial class ListRegexPatternSetsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<RegexPatternSetSummary> _regexPatternSets = AWSConfigs.InitializeCollections ? new List<RegexPatternSetSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <c>RegexPatternSet</c> objects than the number that you specified
        /// for <c>Limit</c> in the request, the response includes a <c>NextMarker</c> value.
        /// To list more <c>RegexPatternSet</c> objects, submit another <c>ListRegexPatternSets</c>
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
        /// Gets and sets the property RegexPatternSets. 
        /// <para>
        /// An array of <a>RegexPatternSetSummary</a> objects.
        /// </para>
        /// </summary>
        public List<RegexPatternSetSummary> RegexPatternSets
        {
            get { return this._regexPatternSets; }
            set { this._regexPatternSets = value; }
        }

        // Check to see if RegexPatternSets property is set
        internal bool IsSetRegexPatternSets()
        {
            return this._regexPatternSets != null && (this._regexPatternSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}