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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The customizations that you specified for the distribution tenant for geographic restrictions.
    /// </summary>
    public partial class GeoRestrictionCustomization
    {
        private List<string> _locations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GeoRestrictionType _restrictionType;

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// The locations for geographic restrictions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestrictionType. 
        /// <para>
        /// The method that you want to use to restrict distribution of your content by country:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>none</c>: No geographic restriction is enabled, meaning access to content is not
        /// restricted by client geo location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>blacklist</c>: The <c>Location</c> elements specify the countries in which you
        /// don't want CloudFront to distribute your content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>whitelist</c>: The <c>Location</c> elements specify the countries in which you
        /// want CloudFront to distribute your content.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeoRestrictionType RestrictionType
        {
            get { return this._restrictionType; }
            set { this._restrictionType = value; }
        }

        // Check to see if RestrictionType property is set
        internal bool IsSetRestrictionType()
        {
            return this._restrictionType != null;
        }

    }
}