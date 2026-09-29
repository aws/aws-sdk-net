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
    /// The color palette.
    /// </summary>
    public partial class BrandColorPalette
    {
        /// <summary>
        /// Gets and sets the property Accent. 
        /// <para>
        /// The color that is used for accent elements.
        /// </para>
        /// </summary>
        public Palette Accent { get; set; }

        /// <summary>
        /// Checks to see if the Accent property is set.
        /// </summary>
        internal bool IsSetAccent() => this.Accent != null;

        /// <summary>
        /// Gets and sets the property Danger. 
        /// <para>
        /// The color that is used for danger elements.
        /// </para>
        /// </summary>
        public Palette Danger { get; set; }

        /// <summary>
        /// Checks to see if the Danger property is set.
        /// </summary>
        internal bool IsSetDanger() => this.Danger != null;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The color that is used for dimension elements.
        /// </para>
        /// </summary>
        public Palette Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// The color that is used for info elements.
        /// </para>
        /// </summary>
        public Palette Info { get; set; }

        /// <summary>
        /// Checks to see if the Info property is set.
        /// </summary>
        internal bool IsSetInfo() => this.Info != null;

        /// <summary>
        /// Gets and sets the property Measure. 
        /// <para>
        /// The color that is used for measure elements.
        /// </para>
        /// </summary>
        public Palette Measure { get; set; }

        /// <summary>
        /// Checks to see if the Measure property is set.
        /// </summary>
        internal bool IsSetMeasure() => this.Measure != null;

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// The primary color.
        /// </para>
        /// </summary>
        public Palette Primary { get; set; }

        /// <summary>
        /// Checks to see if the Primary property is set.
        /// </summary>
        internal bool IsSetPrimary() => this.Primary != null;

        /// <summary>
        /// Gets and sets the property Secondary. 
        /// <para>
        /// The secondary color.
        /// </para>
        /// </summary>
        public Palette Secondary { get; set; }

        /// <summary>
        /// Checks to see if the Secondary property is set.
        /// </summary>
        internal bool IsSetSecondary() => this.Secondary != null;

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// The color that is used for success elements.
        /// </para>
        /// </summary>
        public Palette Success { get; set; }

        /// <summary>
        /// Checks to see if the Success property is set.
        /// </summary>
        internal bool IsSetSuccess() => this.Success != null;

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// The color that is used for warning elements.
        /// </para>
        /// </summary>
        public Palette Warning { get; set; }

        /// <summary>
        /// Checks to see if the Warning property is set.
        /// </summary>
        internal bool IsSetWarning() => this.Warning != null;
    }
}
