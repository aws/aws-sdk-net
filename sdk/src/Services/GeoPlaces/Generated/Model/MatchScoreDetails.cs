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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Details related to the match score.
    /// </summary>
    public partial class MatchScoreDetails
    {
        private ComponentMatchScores _components;
        private double? _overall;

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// Indicates how well the component input matches the returned. It is equal to 1 if all
        /// input tokens are recognized and matched.
        /// </para>
        /// </summary>
        public ComponentMatchScores Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null;
        }

        /// <summary>
        /// Gets and sets the property Overall. 
        /// <para>
        /// Indicates how well the entire input matches the returned. It is equal to 1 if all
        /// input tokens are recognized and matched.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Overall
        {
            get { return this._overall; }
            set { this._overall = value; }
        }

        // Check to see if Overall property is set
        internal bool IsSetOverall()
        {
            return this._overall.HasValue; 
        }

    }
}