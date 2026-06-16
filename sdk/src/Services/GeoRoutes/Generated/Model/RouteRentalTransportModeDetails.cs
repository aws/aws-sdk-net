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
    /// Transport mode details for the rental leg.
    /// </summary>
    public partial class RouteRentalTransportModeDetails
    {
        private int? _availableSeats;
        private string _category;
        private string _color;
        private RouteEngineType _engine;
        private string _licensePlate;
        private RouteRentalMode _mode;
        private string _model;
        private string _name;
        private string _textColor;

        /// <summary>
        /// Gets and sets the property AvailableSeats. 
        /// <para>
        /// Number of available seats in the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? AvailableSeats
        {
            get { return this._availableSeats; }
            set { this._availableSeats = value; }
        }

        // Check to see if AvailableSeats property is set
        internal bool IsSetAvailableSeats()
        {
            return this._availableSeats.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Human readable transport category.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// Vehicle engine type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteEngineType Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property LicensePlate. 
        /// <para>
        /// Vehicle license plate number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string LicensePlate
        {
            get { return this._licensePlate; }
            set { this._licensePlate = value; }
        }

        // Check to see if LicensePlate property is set
        internal bool IsSetLicensePlate()
        {
            return this._licensePlate != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Mode of the rental transport.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteRentalMode Mode
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
        /// Gets and sets the property Model. 
        /// <para>
        /// Vehicle model.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Vehicle name or mobility provider name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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