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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Specifies how the connector scales.
    /// </summary>
    public partial class AutoScaling
    {
        private int? _maxWorkerCount;
        private int? _mcuCount;
        private int? _minWorkerCount;
        private ScaleInPolicy _scaleInPolicy;
        private ScaleOutPolicy _scaleOutPolicy;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. 
        /// <para>
        /// The maximum number of workers allocated to the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxWorkerCount
        {
            get { return this._maxWorkerCount; }
            set { this._maxWorkerCount = value; }
        }

        // Check to see if MaxWorkerCount property is set
        internal bool IsSetMaxWorkerCount()
        {
            return this._maxWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property McuCount. 
        /// <para>
        /// The number of microcontroller units (MCUs) allocated to each connector worker. The
        /// valid values are 1,2,4,8.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public int? McuCount
        {
            get { return this._mcuCount; }
            set { this._mcuCount = value; }
        }

        // Check to see if McuCount property is set
        internal bool IsSetMcuCount()
        {
            return this._mcuCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinWorkerCount. 
        /// <para>
        /// The minimum number of workers allocated to the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinWorkerCount
        {
            get { return this._minWorkerCount; }
            set { this._minWorkerCount = value; }
        }

        // Check to see if MinWorkerCount property is set
        internal bool IsSetMinWorkerCount()
        {
            return this._minWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleInPolicy. 
        /// <para>
        /// The sacle-in policy for the connector.
        /// </para>
        /// </summary>
        public ScaleInPolicy ScaleInPolicy
        {
            get { return this._scaleInPolicy; }
            set { this._scaleInPolicy = value; }
        }

        // Check to see if ScaleInPolicy property is set
        internal bool IsSetScaleInPolicy()
        {
            return this._scaleInPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ScaleOutPolicy. 
        /// <para>
        /// The sacle-out policy for the connector.
        /// </para>
        /// </summary>
        public ScaleOutPolicy ScaleOutPolicy
        {
            get { return this._scaleOutPolicy; }
            set { this._scaleOutPolicy = value; }
        }

        // Check to see if ScaleOutPolicy property is set
        internal bool IsSetScaleOutPolicy()
        {
            return this._scaleOutPolicy != null;
        }

    }
}