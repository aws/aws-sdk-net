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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies information about an event that reports data to Amazon Pinpoint.
    /// </summary>
    public partial class Event
    {
        /// <summary>
        /// Gets and sets the property AppPackageName. 
        /// <para>
        /// The package name of the app that's recording the event.
        /// </para>
        /// </summary>
        public string AppPackageName { get; set; }

        /// <summary>
        /// Checks to see if the AppPackageName property is set.
        /// </summary>
        internal bool IsSetAppPackageName() => this.AppPackageName != null;

        /// <summary>
        /// Gets and sets the property AppTitle. 
        /// <para>
        /// The title of the app that's recording the event.
        /// </para>
        /// </summary>
        public string AppTitle { get; set; }

        /// <summary>
        /// Checks to see if the AppTitle property is set.
        /// </summary>
        internal bool IsSetAppTitle() => this.AppTitle != null;

        /// <summary>
        /// Gets and sets the property AppVersionCode. 
        /// <para>
        /// The version number of the app that's recording the event.
        /// </para>
        /// </summary>
        public string AppVersionCode { get; set; }

        /// <summary>
        /// Checks to see if the AppVersionCode property is set.
        /// </summary>
        internal bool IsSetAppVersionCode() => this.AppVersionCode != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes that are associated with the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientSdkVersion. 
        /// <para>
        /// The version of the SDK that's running on the client device.
        /// </para>
        /// </summary>
        public string ClientSdkVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClientSdkVersion property is set.
        /// </summary>
        internal bool IsSetClientSdkVersion() => this.ClientSdkVersion != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics that are associated with the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SdkName. 
        /// <para>
        /// The name of the SDK that's being used to record the event.
        /// </para>
        /// </summary>
        public string SdkName { get; set; }

        /// <summary>
        /// Checks to see if the SdkName property is set.
        /// </summary>
        internal bool IsSetSdkName() => this.SdkName != null;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// Information about the session in which the event occurred.
        /// </para>
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
