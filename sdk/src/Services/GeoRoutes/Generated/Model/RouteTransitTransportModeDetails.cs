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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Transport mode details for the transit leg.
    /// </summary>
    public partial class RouteTransitTransportModeDetails
    {
        private RouteAccessibilityAvailabilityDetails _accessibility;
        private string _color;
        private string _headsign;
        private string _longRouteName;
        private RouteTransitMode _mode;
        private string _routeName;
        private string _shortRouteName;
        private string _textColor;

        /// <summary>
        /// Gets and sets the property Accessibility. 
        /// <para>
        /// Wheelchair accessibility information for the transit vehicle.
        /// </para>
        /// </summary>
        public RouteAccessibilityAvailabilityDetails Accessibility
        {
            get { return this._accessibility; }
            set { this._accessibility = value; }
        }

        // Check to see if Accessibility property is set
        internal bool IsSetAccessibility()
        {
            return this._accessibility != null;
        }

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Color of the transport polyline and background for the transport name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property Headsign. 
        /// <para>
        /// Transit route headsign.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Headsign
        {
            get { return this._headsign; }
            set { this._headsign = value; }
        }

        // Check to see if Headsign property is set
        internal bool IsSetHeadsign()
        {
            return this._headsign != null;
        }

        /// <summary>
        /// Gets and sets the property LongRouteName. 
        /// <para>
        /// Long name of the transit route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string LongRouteName
        {
            get { return this._longRouteName; }
            set { this._longRouteName = value; }
        }

        // Check to see if LongRouteName property is set
        internal bool IsSetLongRouteName()
        {
            return this._longRouteName != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Mode of the transit transport.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteTransitMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property RouteName. 
        /// <para>
        /// Transit route name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string RouteName
        {
            get { return this._routeName; }
            set { this._routeName = value; }
        }

        // Check to see if RouteName property is set
        internal bool IsSetRouteName()
        {
            return this._routeName != null;
        }

        /// <summary>
        /// Gets and sets the property ShortRouteName. 
        /// <para>
        /// Short name of the transit route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ShortRouteName
        {
            get { return this._shortRouteName; }
            set { this._shortRouteName = value; }
        }

        // Check to see if ShortRouteName property is set
        internal bool IsSetShortRouteName()
        {
            return this._shortRouteName != null;
        }

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// Color of the transport name text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TextColor
        {
            get { return this._textColor; }
            set { this._textColor = value; }
        }

        // Check to see if TextColor property is set
        internal bool IsSetTextColor()
        {
            return this._textColor != null;
        }

    }
}