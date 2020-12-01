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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Currently, the <code>TrafficRoutingConfig</code> API is not supported.
    /// </summary>
    public partial class TrafficRoutingConfig
    {
        private CapacitySize _canarySize;
        private TrafficRoutingConfigType _type;
        private int? _waitIntervalInSeconds;

        /// <summary>
        /// Gets and sets the property CanarySize.
        /// </summary>
        public CapacitySize CanarySize
        {
            get { return this._canarySize; }
            set { this._canarySize = value; }
        }

        // Check to see if CanarySize property is set
        internal bool IsSetCanarySize()
        {
            return this._canarySize != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required=true)]
        public TrafficRoutingConfigType Type
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
        /// Gets and sets the property WaitIntervalInSeconds.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3600)]
        public int WaitIntervalInSeconds
        {
            get { return this._waitIntervalInSeconds.GetValueOrDefault(); }
            set { this._waitIntervalInSeconds = value; }
        }

        // Check to see if WaitIntervalInSeconds property is set
        internal bool IsSetWaitIntervalInSeconds()
        {
            return this._waitIntervalInSeconds.HasValue; 
        }

    }
}