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
    /// The options that determine the visibility, color, type, and tooltip visibility of
    /// the sparkline of a KPI visual.
    /// </summary>
    public partial class KPISparklineOptions
    {
        private string _color;
        private Visibility _tooltipVisibility;
        private KPISparklineType _type;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color of the sparkline.
        /// </para>
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property TooltipVisibility. 
        /// <para>
        /// The tooltip visibility of the sparkline.
        /// </para>
        /// </summary>
        public Visibility TooltipVisibility
        {
            get { return this._tooltipVisibility; }
            set { this._tooltipVisibility = value; }
        }

        // Check to see if TooltipVisibility property is set
        internal bool IsSetTooltipVisibility()
        {
            return this._tooltipVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the sparkline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KPISparklineType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the sparkline.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}