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
    /// Describes how the parts of the textQuery matched the input query by returning the
    /// sections of the response which matched to textQuery terms.
    /// </summary>
    public partial class SuggestAddressHighlights
    {
        private List<Highlight> _label = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Indicates the starting and ending indexes of the places in the result which were identified
        /// to match the textQuery. This result is useful for providing emphasis to results where
        /// the user query directly matched to make selecting the correct result from a list easier
        /// for an end user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null && (this._label.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}