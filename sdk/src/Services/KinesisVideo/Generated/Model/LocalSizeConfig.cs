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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The configuration details that include the maximum size of the media (<code>MaxLocalMediaSizeInMB</code>)
    /// that you want to store for a stream on the Edge Agent, as well as the strategy that
    /// should be used (<code>StrategyOnFullSize</code>) when a stream's maximum size has
    /// been reached.
    /// </summary>
    public partial class LocalSizeConfig
    {
        private int? _maxLocalMediaSizeInMB;
        private StrategyOnFullSize _strategyOnFullSize;

        /// <summary>
        /// Gets and sets the property MaxLocalMediaSizeInMB. 
        /// <para>
        /// The overall maximum size of the media that you want to store for a stream on the Edge
        /// Agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=2000000)]
        public int MaxLocalMediaSizeInMB
        {
            get { return this._maxLocalMediaSizeInMB.GetValueOrDefault(); }
            set { this._maxLocalMediaSizeInMB = value; }
        }

        // Check to see if MaxLocalMediaSizeInMB property is set
        internal bool IsSetMaxLocalMediaSizeInMB()
        {
            return this._maxLocalMediaSizeInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StrategyOnFullSize. 
        /// <para>
        /// The strategy to perform when a stream’s <code>MaxLocalMediaSizeInMB</code> limit is
        /// reached.
        /// </para>
        /// </summary>
        public StrategyOnFullSize StrategyOnFullSize
        {
            get { return this._strategyOnFullSize; }
            set { this._strategyOnFullSize = value; }
        }

        // Check to see if StrategyOnFullSize property is set
        internal bool IsSetStrategyOnFullSize()
        {
            return this._strategyOnFullSize != null;
        }

    }
}