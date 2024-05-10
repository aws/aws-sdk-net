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
    /// Provides information about the category rule that was matched.
    /// </summary>
    public partial class RealTimeContactAnalysisCategoryDetails
    {
        private List<RealTimeContactAnalysisPointOfInterest> _pointsOfInterest = AWSConfigs.InitializeCollections ? new List<RealTimeContactAnalysisPointOfInterest>() : null;

        /// <summary>
        /// Gets and sets the property PointsOfInterest. 
        /// <para>
        /// List of PointOfInterest - objects describing a single match of a rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5)]
        public List<RealTimeContactAnalysisPointOfInterest> PointsOfInterest
        {
            get { return this._pointsOfInterest; }
            set { this._pointsOfInterest = value; }
        }

        // Check to see if PointsOfInterest property is set
        internal bool IsSetPointsOfInterest()
        {
            return this._pointsOfInterest != null && (this._pointsOfInterest.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}