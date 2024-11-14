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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private Palette _accent;
        private Palette _danger;
        private Palette _dimension;
        private Palette _info;
        private Palette _measure;
        private Palette _primary;
        private Palette _secondary;
        private Palette _success;
        private Palette _warning;

        /// <summary>
        /// Gets and sets the property Accent. 
        /// <para>
        /// The color that is used for accent elements.
        /// </para>
        /// </summary>
        public Palette Accent
        {
            get { return this._accent; }
            set { this._accent = value; }
        }

        // Check to see if Accent property is set
        internal bool IsSetAccent()
        {
            return this._accent != null;
        }

        /// <summary>
        /// Gets and sets the property Danger. 
        /// <para>
        /// The color that is used for danger elements.
        /// </para>
        /// </summary>
        public Palette Danger
        {
            get { return this._danger; }
            set { this._danger = value; }
        }

        // Check to see if Danger property is set
        internal bool IsSetDanger()
        {
            return this._danger != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The color that is used for dimension elements.
        /// </para>
        /// </summary>
        public Palette Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// The color that is used for info elements.
        /// </para>
        /// </summary>
        public Palette Info
        {
            get { return this._info; }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info != null;
        }

        /// <summary>
        /// Gets and sets the property Measure. 
        /// <para>
        /// The color that is used for measure elements.
        /// </para>
        /// </summary>
        public Palette Measure
        {
            get { return this._measure; }
            set { this._measure = value; }
        }

        // Check to see if Measure property is set
        internal bool IsSetMeasure()
        {
            return this._measure != null;
        }

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// The primary color.
        /// </para>
        /// </summary>
        public Palette Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary != null;
        }

        /// <summary>
        /// Gets and sets the property Secondary. 
        /// <para>
        /// The secondary color.
        /// </para>
        /// </summary>
        public Palette Secondary
        {
            get { return this._secondary; }
            set { this._secondary = value; }
        }

        // Check to see if Secondary property is set
        internal bool IsSetSecondary()
        {
            return this._secondary != null;
        }

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// The color that is used for success elements.
        /// </para>
        /// </summary>
        public Palette Success
        {
            get { return this._success; }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success != null;
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// The color that is used for warning elements.
        /// </para>
        /// </summary>
        public Palette Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null;
        }

    }
}