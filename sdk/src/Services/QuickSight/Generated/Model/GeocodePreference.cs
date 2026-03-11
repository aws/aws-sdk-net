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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The geocode preference.
    /// </summary>
    public partial class GeocodePreference
    {
        private GeocodePreferenceValue _preference;
        private GeocoderHierarchy _requestKey;

        /// <summary>
        /// Gets and sets the property Preference. 
        /// <para>
        /// The preference definition for the geocode preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeocodePreferenceValue Preference
        {
            get { return this._preference; }
            set { this._preference = value; }
        }

        // Check to see if Preference property is set
        internal bool IsSetPreference()
        {
            return this._preference != null;
        }

        /// <summary>
        /// Gets and sets the property RequestKey. 
        /// <para>
        /// The unique request key for the geocode preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeocoderHierarchy RequestKey
        {
            get { return this._requestKey; }
            set { this._requestKey = value; }
        }

        // Check to see if RequestKey property is set
        internal bool IsSetRequestKey()
        {
            return this._requestKey != null;
        }

    }
}