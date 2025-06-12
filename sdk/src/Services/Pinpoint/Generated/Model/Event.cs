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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies information about an event that reports data to Amazon Pinpoint.
    /// </summary>
    public partial class Event
    {
        private string _appPackageName;
        private string _appTitle;
        private string _appVersionCode;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientSdkVersion;
        private string _eventType;
        private Dictionary<string, double> _metrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private string _sdkName;
        private Session _session;
        private string _timestamp;

        /// <summary>
        /// Gets and sets the property AppPackageName. 
        /// <para>
        /// The package name of the app that's recording the event.
        /// </para>
        /// </summary>
        public string AppPackageName
        {
            get { return this._appPackageName; }
            set { this._appPackageName = value; }
        }

        // Check to see if AppPackageName property is set
        internal bool IsSetAppPackageName()
        {
            return this._appPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property AppTitle. 
        /// <para>
        /// The title of the app that's recording the event.
        /// </para>
        /// </summary>
        public string AppTitle
        {
            get { return this._appTitle; }
            set { this._appTitle = value; }
        }

        // Check to see if AppTitle property is set
        internal bool IsSetAppTitle()
        {
            return this._appTitle != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersionCode. 
        /// <para>
        /// The version number of the app that's recording the event.
        /// </para>
        /// </summary>
        public string AppVersionCode
        {
            get { return this._appVersionCode; }
            set { this._appVersionCode = value; }
        }

        // Check to see if AppVersionCode property is set
        internal bool IsSetAppVersionCode()
        {
            return this._appVersionCode != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes that are associated with the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientSdkVersion. 
        /// <para>
        /// The version of the SDK that's running on the client device.
        /// </para>
        /// </summary>
        public string ClientSdkVersion
        {
            get { return this._clientSdkVersion; }
            set { this._clientSdkVersion = value; }
        }

        // Check to see if ClientSdkVersion property is set
        internal bool IsSetClientSdkVersion()
        {
            return this._clientSdkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics that are associated with the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SdkName. 
        /// <para>
        /// The name of the SDK that's being used to record the event.
        /// </para>
        /// </summary>
        public string SdkName
        {
            get { return this._sdkName; }
            set { this._sdkName = value; }
        }

        // Check to see if SdkName property is set
        internal bool IsSetSdkName()
        {
            return this._sdkName != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// Information about the session in which the event occurred.
        /// </para>
        /// </summary>
        public Session Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}