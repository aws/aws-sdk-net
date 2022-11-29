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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of an insight visual.
    /// </summary>
    public partial class InsightConfiguration
    {
        private List<Computation> _computations = new List<Computation>();
        private CustomNarrativeOptions _customNarrative;

        /// <summary>
        /// Gets and sets the property Computations. 
        /// <para>
        /// The computations configurations of the insight visual
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<Computation> Computations
        {
            get { return this._computations; }
            set { this._computations = value; }
        }

        // Check to see if Computations property is set
        internal bool IsSetComputations()
        {
            return this._computations != null && this._computations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomNarrative. 
        /// <para>
        /// The custom narrative of the insight visual.
        /// </para>
        /// </summary>
        public CustomNarrativeOptions CustomNarrative
        {
            get { return this._customNarrative; }
            set { this._customNarrative = value; }
        }

        // Check to see if CustomNarrative property is set
        internal bool IsSetCustomNarrative()
        {
            return this._customNarrative != null;
        }

    }
}