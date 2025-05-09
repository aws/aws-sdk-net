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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Status of edge devices with this model.
    /// </summary>
    public partial class EdgeModelStat
    {
        private long? _activeDeviceCount;
        private long? _connectedDeviceCount;
        private string _modelName;
        private string _modelVersion;
        private long? _offlineDeviceCount;
        private long? _samplingDeviceCount;

        /// <summary>
        /// Gets and sets the property ActiveDeviceCount. 
        /// <para>
        /// The number of devices that have this model version, a heart beat, and are currently
        /// running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ActiveDeviceCount
        {
            get { return this._activeDeviceCount; }
            set { this._activeDeviceCount = value; }
        }

        // Check to see if ActiveDeviceCount property is set
        internal bool IsSetActiveDeviceCount()
        {
            return this._activeDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectedDeviceCount. 
        /// <para>
        /// The number of devices that have this model version and have a heart beat. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ConnectedDeviceCount
        {
            get { return this._connectedDeviceCount; }
            set { this._connectedDeviceCount = value; }
        }

        // Check to see if ConnectedDeviceCount property is set
        internal bool IsSetConnectedDeviceCount()
        {
            return this._connectedDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The model version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineDeviceCount. 
        /// <para>
        /// The number of devices that have this model version and do not have a heart beat.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? OfflineDeviceCount
        {
            get { return this._offlineDeviceCount; }
            set { this._offlineDeviceCount = value; }
        }

        // Check to see if OfflineDeviceCount property is set
        internal bool IsSetOfflineDeviceCount()
        {
            return this._offlineDeviceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamplingDeviceCount. 
        /// <para>
        /// The number of devices with this model version and are producing sample data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? SamplingDeviceCount
        {
            get { return this._samplingDeviceCount; }
            set { this._samplingDeviceCount = value; }
        }

        // Check to see if SamplingDeviceCount property is set
        internal bool IsSetSamplingDeviceCount()
        {
            return this._samplingDeviceCount.HasValue; 
        }

    }
}