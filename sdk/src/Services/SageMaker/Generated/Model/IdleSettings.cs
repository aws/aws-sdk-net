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
    /// Settings related to idle shutdown of Studio applications.
    /// </summary>
    public partial class IdleSettings
    {
        private int? _idleTimeoutInMinutes;
        private LifecycleManagement _lifecycleManagement;
        private int? _maxIdleTimeoutInMinutes;
        private int? _minIdleTimeoutInMinutes;

        /// <summary>
        /// Gets and sets the property IdleTimeoutInMinutes. 
        /// <para>
        /// The time that SageMaker waits after the application becomes idle before shutting it
        /// down.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=525600)]
        public int? IdleTimeoutInMinutes
        {
            get { return this._idleTimeoutInMinutes; }
            set { this._idleTimeoutInMinutes = value; }
        }

        // Check to see if IdleTimeoutInMinutes property is set
        internal bool IsSetIdleTimeoutInMinutes()
        {
            return this._idleTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleManagement. 
        /// <para>
        /// Indicates whether idle shutdown is activated for the application type.
        /// </para>
        /// </summary>
        public LifecycleManagement LifecycleManagement
        {
            get { return this._lifecycleManagement; }
            set { this._lifecycleManagement = value; }
        }

        // Check to see if LifecycleManagement property is set
        internal bool IsSetLifecycleManagement()
        {
            return this._lifecycleManagement != null;
        }

        /// <summary>
        /// Gets and sets the property MaxIdleTimeoutInMinutes. 
        /// <para>
        /// The maximum value in minutes that custom idle shutdown can be set to by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=525600)]
        public int? MaxIdleTimeoutInMinutes
        {
            get { return this._maxIdleTimeoutInMinutes; }
            set { this._maxIdleTimeoutInMinutes = value; }
        }

        // Check to see if MaxIdleTimeoutInMinutes property is set
        internal bool IsSetMaxIdleTimeoutInMinutes()
        {
            return this._maxIdleTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIdleTimeoutInMinutes. 
        /// <para>
        /// The minimum value in minutes that custom idle shutdown can be set to by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=525600)]
        public int? MinIdleTimeoutInMinutes
        {
            get { return this._minIdleTimeoutInMinutes; }
            set { this._minIdleTimeoutInMinutes = value; }
        }

        // Check to see if MinIdleTimeoutInMinutes property is set
        internal bool IsSetMinIdleTimeoutInMinutes()
        {
            return this._minIdleTimeoutInMinutes.HasValue; 
        }

    }
}