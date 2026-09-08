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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// A single number preference — specifies a pattern type and filter value.
    /// </summary>
    public partial class NumberPreferenceItem
    {
        private List<string> _filter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _preferenceType = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The digit pattern values to match against available phone numbers, using the specified
        /// preference type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && (this._filter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreferenceType. 
        /// <para>
        /// The type of match to apply to the filter values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>StartsWith</c>: Returns numbers that begin with the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EndsWith</c>: Returns numbers that end with the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Contains</c>: Returns numbers that contain the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExactMatch</c>: Returns the number that exactly matches the filter value.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> PreferenceType
        {
            get { return this._preferenceType; }
            set { this._preferenceType = value; }
        }

        // Check to see if PreferenceType property is set
        internal bool IsSetPreferenceType()
        {
            return this._preferenceType != null && (this._preferenceType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}