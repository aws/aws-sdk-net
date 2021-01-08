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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// This is the response object from the GetCoreDevice operation.
    /// </summary>
    public partial class GetCoreDeviceResponse : AmazonWebServiceResponse
    {
        private string _architecture;
        private string _coreDeviceThingName;
        private string _coreVersion;
        private DateTime? _lastStatusUpdateTimestamp;
        private string _platform;
        private CoreDeviceStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The computer architecture of the core device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property CoreDeviceThingName. 
        /// <para>
        /// The name of the core device. This is also the name of the AWS IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CoreDeviceThingName
        {
            get { return this._coreDeviceThingName; }
            set { this._coreDeviceThingName = value; }
        }

        // Check to see if CoreDeviceThingName property is set
        internal bool IsSetCoreDeviceThingName()
        {
            return this._coreDeviceThingName != null;
        }

        /// <summary>
        /// Gets and sets the property CoreVersion. 
        /// <para>
        /// The version of the AWS IoT Greengrass Core software that the core device runs. This
        /// version is equivalent to the version of the AWS IoT Greengrass nucleus component that
        /// runs on the core device. For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html">AWS
        /// IoT Greengrass nucleus component</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CoreVersion
        {
            get { return this._coreVersion; }
            set { this._coreVersion = value; }
        }

        // Check to see if CoreVersion property is set
        internal bool IsSetCoreVersion()
        {
            return this._coreVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusUpdateTimestamp. 
        /// <para>
        /// The time at which the core device's status last updated, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime LastStatusUpdateTimestamp
        {
            get { return this._lastStatusUpdateTimestamp.GetValueOrDefault(); }
            set { this._lastStatusUpdateTimestamp = value; }
        }

        // Check to see if LastStatusUpdateTimestamp property is set
        internal bool IsSetLastStatusUpdateTimestamp()
        {
            return this._lastStatusUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform that the core device runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the core device. The core device status can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HEALTHY</code> – The AWS IoT Greengrass Core software and all components run
        /// on the core device without issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNHEALTHY</code> – The AWS IoT Greengrass Core software or a component is in
        /// a failed state on the core device.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CoreDeviceStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/tag-resources.html">Tag your
        /// resources</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}