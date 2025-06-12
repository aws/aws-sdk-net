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
    /// This is the response object from the ListIPSets operation.
    /// </summary>
    public partial class ListIPSetsResponse : AmazonWebServiceResponse
    {
        private List<IPSetSummary> _ipSets = AWSConfigs.InitializeCollections ? new List<IPSetSummary>() : null;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property IPSets. 
        /// <para>
        /// An array of <a>IPSetSummary</a> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IPSetSummary> IPSets
        {
            get { return this._ipSets; }
            set { this._ipSets = value; }
        }

        // Check to see if IPSets property is set
        internal bool IsSetIPSets()
        {
            return this._ipSets != null && (this._ipSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// To list more <c>IPSet</c> objects, submit another <c>ListIPSets</c> request, and in
        /// the next request use the <c>NextMarker</c> response value as the <c>NextMarker</c>
        /// value.
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

    }
}