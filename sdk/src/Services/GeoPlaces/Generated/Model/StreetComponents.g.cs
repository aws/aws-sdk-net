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
    /// Components of a street.
    /// </summary>
    public partial class StreetComponents
    {
        /// <summary>
        /// Gets and sets the property BaseName. 
        /// <para>
        /// Base name part of the street name. 
        /// </para>
        ///  
        /// <para>
        /// Example: Younge from the "Younge street".
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string BaseName { get; set; }

        /// <summary>
        /// Checks to see if the BaseName property is set.
        /// </summary>
        internal bool IsSetBaseName() => this.BaseName != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Indicates the official directional identifiers assigned to highways.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public string Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language codes for the results to be rendered in. If there is no
        /// data for the result in the requested language, data will be returned in the default
        /// language for the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix is a directional identifier that precedes, but is not included in, the base
        /// name of a road. 
        /// </para>
        ///  
        /// <para>
        /// Example: E for East.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// A suffix is a directional identifier that follows, but is not included in, the base
        /// name of a road. 
        /// </para>
        ///  
        /// <para>
        /// Example W for West.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public string Suffix { get; set; }

        /// <summary>
        /// Checks to see if the Suffix property is set.
        /// </summary>
        internal bool IsSetSuffix() => this.Suffix != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Street type part of the street name. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"avenue"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property TypePlacement. 
        /// <para>
        /// Defines if the street type is before or after the base name.
        /// </para>
        /// </summary>
        public TypePlacement TypePlacement { get; set; }

        /// <summary>
        /// Checks to see if the TypePlacement property is set.
        /// </summary>
        internal bool IsSetTypePlacement() => this.TypePlacement != null;

        /// <summary>
        /// Gets and sets the property TypeSeparator. 
        /// <para>
        /// Defines a separator character such as <c>""</c> or <c>" "</c> between the base name
        /// and type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public string TypeSeparator { get; set; }

        /// <summary>
        /// Checks to see if the TypeSeparator property is set.
        /// </summary>
        internal bool IsSetTypeSeparator() => this.TypeSeparator != null;
    }
}
