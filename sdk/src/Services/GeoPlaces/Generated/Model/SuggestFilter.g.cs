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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// SuggestFilter structure which contains a set of inclusion/exclusion properties that
    /// results must possess in order to be returned as a result.
    /// </summary>
    public partial class SuggestFilter
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// The bounding box enclosing the geometric shape (area or line) that an individual result
        /// covers.
        /// </para>
        ///  
        /// <para>
        /// The bounding box formed is defined as a set 4 coordinates: <c>[{westward lng}, {southern
        /// lat}, {eastward lng}, {northern lat}]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 4, Max = 4)]
        public List<double> BoundingBox { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null && (this.BoundingBox.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Circle.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FilterCircle Circle { get; set; }

        /// <summary>
        /// Checks to see if the Circle property is set.
        /// </summary>
        internal bool IsSetCircle() => this.Circle != null;

        /// <summary>
        /// Gets and sets the property IncludeCountries. 
        /// <para>
        ///  A list of countries that all results must be in. Countries are represented by either
        /// their alpha-2 or alpha-3 character codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> IncludeCountries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeCountries property is set.
        /// </summary>
        internal bool IsSetIncludeCountries() => this.IncludeCountries != null && (this.IncludeCountries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
