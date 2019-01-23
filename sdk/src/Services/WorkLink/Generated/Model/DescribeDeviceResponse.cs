/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// This is the response object from the DescribeDevice operation.
    /// </summary>
    public partial class DescribeDeviceResponse : AmazonWebServiceResponse
    {
        private DateTime? _firstAccessedTime;
        private DateTime? _lastAccessedTime;
        private string _manufacturer;
        private string _model;
        private string _operatingSystem;
        private string _operatingSystemVersion;
        private string _patchLevel;
        private DeviceStatus _status;
        private string _username;

        /// <summary>
        /// Gets and sets the property FirstAccessedTime. 
        /// <para>
        /// The date that the device first signed in to Amazon WorkLink.
        /// </para>
        /// </summary>
        public DateTime FirstAccessedTime
        {
            get { return this._firstAccessedTime.GetValueOrDefault(); }
            set { this._firstAccessedTime = value; }
        }

        // Check to see if FirstAccessedTime property is set
        internal bool IsSetFirstAccessedTime()
        {
            return this._firstAccessedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAccessedTime. 
        /// <para>
        /// The date that the device last accessed Amazon WorkLink.
        /// </para>
        /// </summary>
        public DateTime LastAccessedTime
        {
            get { return this._lastAccessedTime.GetValueOrDefault(); }
            set { this._lastAccessedTime = value; }
        }

        // Check to see if LastAccessedTime property is set
        internal bool IsSetLastAccessedTime()
        {
            return this._lastAccessedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The manufacturer of the device.
        /// </para>
        /// </summary>
        public string Manufacturer
        {
            get { return this._manufacturer; }
            set { this._manufacturer = value; }
        }

        // Check to see if Manufacturer property is set
        internal bool IsSetManufacturer()
        {
            return this._manufacturer != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the device.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system of the device.
        /// </para>
        /// </summary>
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystemVersion. 
        /// <para>
        /// The operating system version of the device.
        /// </para>
        /// </summary>
        public string OperatingSystemVersion
        {
            get { return this._operatingSystemVersion; }
            set { this._operatingSystemVersion = value; }
        }

        // Check to see if OperatingSystemVersion property is set
        internal bool IsSetOperatingSystemVersion()
        {
            return this._operatingSystemVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PatchLevel. 
        /// <para>
        /// The operating system patch level of the device.
        /// </para>
        /// </summary>
        public string PatchLevel
        {
            get { return this._patchLevel; }
            set { this._patchLevel = value; }
        }

        // Check to see if PatchLevel property is set
        internal bool IsSetPatchLevel()
        {
            return this._patchLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the device.
        /// </para>
        /// </summary>
        public DeviceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name associated with the device.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}