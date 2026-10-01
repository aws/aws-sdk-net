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
    /// Category of the <c>Place</c> returned.
    /// </summary>
    public partial class Category
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The category ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LocalizedName. 
        /// <para>
        /// Localized name of the category type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100)]
        public string LocalizedName { get; set; }

        /// <summary>
        /// Checks to see if the LocalizedName property is set.
        /// </summary>
        internal bool IsSetLocalizedName() => this.LocalizedName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The category name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// Boolean which indicates if this category is the primary offered by the place.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Primary { get; set; }

        /// <summary>
        /// Checks to see if the Primary property is set.
        /// </summary>
        internal bool IsSetPrimary() => this.Primary.HasValue;
    }
}
