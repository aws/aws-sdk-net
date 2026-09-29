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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The general configuration of a column.
    /// </summary>
    public partial class ColumnConfiguration
    {
        /// <summary>
        /// Gets and sets the property ColorsConfiguration. 
        /// <para>
        /// The color configurations of the column.
        /// </para>
        /// </summary>
        public ColorsConfiguration ColorsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ColorsConfiguration property is set.
        /// </summary>
        internal bool IsSetColorsConfiguration() => this.ColorsConfiguration != null;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property DecalSettingsConfiguration. 
        /// <para>
        /// Decal configuration of the column.
        /// </para>
        /// </summary>
        public DecalSettingsConfiguration DecalSettingsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DecalSettingsConfiguration property is set.
        /// </summary>
        internal bool IsSetDecalSettingsConfiguration() => this.DecalSettingsConfiguration != null;

        /// <summary>
        /// Gets and sets the property FormatConfiguration. 
        /// <para>
        /// The format configuration of a column.
        /// </para>
        /// </summary>
        public FormatConfiguration FormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FormatConfiguration property is set.
        /// </summary>
        internal bool IsSetFormatConfiguration() => this.FormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the column.
        /// </para>
        /// </summary>
        public ColumnRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
