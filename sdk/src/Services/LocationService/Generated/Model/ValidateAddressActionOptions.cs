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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Options specific to address validation jobs.
    /// </summary>
    public partial class ValidateAddressActionOptions
    {
        private List<string> _additionalFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        /// A list of optional additional parameters that can be requested for each result.
        /// </para>
        ///  
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Position</c> - Return the position coordinates of the address if available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CountrySpecificAttributes</c> - Return additional information about the address
        /// specific to the country of origin.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> AdditionalFeatures
        {
            get { return this._additionalFeatures; }
            set { this._additionalFeatures = value; }
        }

        // Check to see if AdditionalFeatures property is set
        internal bool IsSetAdditionalFeatures()
        {
            return this._additionalFeatures != null && (this._additionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}