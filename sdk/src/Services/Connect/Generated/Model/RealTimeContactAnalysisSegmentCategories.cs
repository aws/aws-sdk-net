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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The matched category rules.
    /// </summary>
    public partial class RealTimeContactAnalysisSegmentCategories
    {
        private Dictionary<string, RealTimeContactAnalysisCategoryDetails> _matchedDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, RealTimeContactAnalysisCategoryDetails>() : null;

        /// <summary>
        /// Gets and sets the property MatchedDetails. 
        /// <para>
        /// Map between the name of the matched rule and RealTimeContactAnalysisCategoryDetails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public Dictionary<string, RealTimeContactAnalysisCategoryDetails> MatchedDetails
        {
            get { return this._matchedDetails; }
            set { this._matchedDetails = value; }
        }

        // Check to see if MatchedDetails property is set
        internal bool IsSetMatchedDetails()
        {
            return this._matchedDetails != null && (this._matchedDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}