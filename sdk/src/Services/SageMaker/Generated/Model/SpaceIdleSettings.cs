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
    /// Settings related to idle shutdown of Studio applications in a space.
    /// </summary>
    public partial class SpaceIdleSettings
    {
        private int? _idleTimeoutInMinutes;

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

    }
}