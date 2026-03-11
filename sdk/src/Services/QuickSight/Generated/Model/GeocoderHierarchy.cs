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
    /// The preference hierarchy for the geocode preference.
    /// </summary>
    public partial class GeocoderHierarchy
    {
        private string _city;
        private string _country;
        private string _county;
        private string _postCode;
        private string _state;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3000)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3000)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The county/district value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3000)]
        public string County
        {
            get { return this._county; }
            set { this._county = value; }
        }

        // Check to see if County property is set
        internal bool IsSetCounty()
        {
            return this._county != null;
        }

        /// <summary>
        /// Gets and sets the property PostCode. 
        /// <para>
        /// The postcode value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3000)]
        public string PostCode
        {
            get { return this._postCode; }
            set { this._postCode = value; }
        }

        // Check to see if PostCode property is set
        internal bool IsSetPostCode()
        {
            return this._postCode != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state/region value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3000)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}