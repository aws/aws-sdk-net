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
    /// The official administrative names for an address component, returned when <c>AddressNamesMode</c>
    /// is set to <c>Administrative</c>.
    /// </summary>
    public partial class AdminNames
    {
        private List<TranslationName> _names = AWSConfigs.InitializeCollections ? new List<TranslationName>() : null;
        private AdminNamesPreference _preference;

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of translation names for the administrative address component, including name
        /// variants and translations in available languages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<TranslationName> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Preference. 
        /// <para>
        /// Indicates the preference level of the administrative name. Valid values are <c>Primary</c>
        /// and <c>Alternative</c>.
        /// </para>
        /// </summary>
        public AdminNamesPreference Preference
        {
            get { return this._preference; }
            set { this._preference = value; }
        }

        // Check to see if Preference property is set
        internal bool IsSetPreference()
        {
            return this._preference != null;
        }

    }
}