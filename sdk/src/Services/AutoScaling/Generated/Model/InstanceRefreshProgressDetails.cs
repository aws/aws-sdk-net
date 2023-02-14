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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Reports progress on replacing instances in an Auto Scaling group that has a warm pool.
    /// This includes separate details for instances in the warm pool and instances in the
    /// Auto Scaling group (the live pool).
    /// </summary>
    public partial class InstanceRefreshProgressDetails
    {
        private InstanceRefreshLivePoolProgress _livePoolProgress;
        private InstanceRefreshWarmPoolProgress _warmPoolProgress;

        /// <summary>
        /// Gets and sets the property LivePoolProgress. 
        /// <para>
        /// Reports progress on replacing instances that are in the Auto Scaling group.
        /// </para>
        /// </summary>
        public InstanceRefreshLivePoolProgress LivePoolProgress
        {
            get { return this._livePoolProgress; }
            set { this._livePoolProgress = value; }
        }

        // Check to see if LivePoolProgress property is set
        internal bool IsSetLivePoolProgress()
        {
            return this._livePoolProgress != null;
        }

        /// <summary>
        /// Gets and sets the property WarmPoolProgress. 
        /// <para>
        /// Reports progress on replacing instances that are in the warm pool.
        /// </para>
        /// </summary>
        public InstanceRefreshWarmPoolProgress WarmPoolProgress
        {
            get { return this._warmPoolProgress; }
            set { this._warmPoolProgress = value; }
        }

        // Check to see if WarmPoolProgress property is set
        internal bool IsSetWarmPoolProgress()
        {
            return this._warmPoolProgress != null;
        }

    }
}