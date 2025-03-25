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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing a push config.
    /// </summary>
    public partial class PushConfig
    {
        private OtaTaskAbortConfig _abortConfig;
        private OtaTaskExecutionRolloutConfig _rolloutConfig;
        private OtaTaskTimeoutConfig _timeoutConfig;

        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Structure representing one abort config.
        /// </para>
        /// </summary>
        public OtaTaskAbortConfig AbortConfig
        {
            get { return this._abortConfig; }
            set { this._abortConfig = value; }
        }

        // Check to see if AbortConfig property is set
        internal bool IsSetAbortConfig()
        {
            return this._abortConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RolloutConfig. 
        /// <para>
        /// Structure representing one rollout config.
        /// </para>
        /// </summary>
        public OtaTaskExecutionRolloutConfig RolloutConfig
        {
            get { return this._rolloutConfig; }
            set { this._rolloutConfig = value; }
        }

        // Check to see if RolloutConfig property is set
        internal bool IsSetRolloutConfig()
        {
            return this._rolloutConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Structure representing one timeout config.
        /// </para>
        /// </summary>
        public OtaTaskTimeoutConfig TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

    }
}