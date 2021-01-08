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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// Provides information about the category rule that was matched.
    /// </summary>
    public partial class CategoryDetails
    {
        private List<PointOfInterest> _pointsOfInterest = new List<PointOfInterest>();

        /// <summary>
        /// Gets and sets the property PointsOfInterest. 
        /// <para>
        /// The section of audio where the category rule was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<PointOfInterest> PointsOfInterest
        {
            get { return this._pointsOfInterest; }
            set { this._pointsOfInterest = value; }
        }

        // Check to see if PointsOfInterest property is set
        internal bool IsSetPointsOfInterest()
        {
            return this._pointsOfInterest != null && this._pointsOfInterest.Count > 0; 
        }

    }
}