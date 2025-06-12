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

#pragma warning disable CS0612,CS0618,CS1570
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
        private string _runtime;
        private CoreDeviceStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// The name of the core device. This is also the name of the IoT thing.
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
        /// The version of the IoT Greengrass Core software that the core device runs. This version
        /// is equivalent to the version of the Greengrass nucleus component that runs on the
        /// core device. For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html">Greengrass
        /// nucleus component</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
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
        public DateTime? LastStatusUpdateTimestamp
        {
            get { return this._lastStatusUpdateTimestamp; }
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
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime for the core device. The runtime can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws_nucleus_classic</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws_nucleus_lite</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the core device. The core device status can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEALTHY</c> – The IoT Greengrass Core software and all components run on the core
        /// device without issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNHEALTHY</c> – The IoT Greengrass Core software or a component is in a failed
        /// state on the core device.
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
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/tag-resources.html">Tag
        /// your resources</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}