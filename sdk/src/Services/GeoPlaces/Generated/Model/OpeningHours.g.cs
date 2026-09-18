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
    /// List of opening hours objects.
    /// </summary>
    public partial class OpeningHours
    {
        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// Categories of results that results must belong too.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<Category> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<Category>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// Components of the opening hours object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<OpeningHoursComponents> Components { get; set; } = AWSConfigs.InitializeCollections ? new List<OpeningHoursComponents>() : null;

        /// <summary>
        /// Checks to see if the Components property is set.
        /// </summary>
        internal bool IsSetComponents() => this.Components != null && (this.Components.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Display. 
        /// <para>
        /// List of opening hours in the format they are displayed in. This can vary by result
        /// and in most cases represents how the result uniquely formats their opening hours.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> Display { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Display property is set.
        /// </summary>
        internal bool IsSetDisplay() => this.Display != null && (this.Display.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpenNow. 
        /// <para>
        /// Boolean which indicates if the result/place is currently open. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? OpenNow { get; set; }

        /// <summary>
        /// Checks to see if the OpenNow property is set.
        /// </summary>
        internal bool IsSetOpenNow() => this.OpenNow.HasValue;
    }
}
