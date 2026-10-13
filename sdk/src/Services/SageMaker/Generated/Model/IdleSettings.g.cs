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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property IdleTimeoutInMinutes. 
        /// <para>
        /// The time that SageMaker waits after the application becomes idle before shutting it
        /// down.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 525600)]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetIdleTimeoutInMinutes() => this.IdleTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleManagement. 
        /// <para>
        /// Indicates whether idle shutdown is activated for the application type.
        /// </para>
        /// </summary>
        public LifecycleManagement LifecycleManagement { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleManagement property is set.
        /// </summary>
        internal bool IsSetLifecycleManagement() => this.LifecycleManagement != null;

        /// <summary>
        /// Gets and sets the property MaxIdleTimeoutInMinutes. 
        /// <para>
        /// The maximum value in minutes that custom idle shutdown can be set to by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 525600)]
        public int? MaxIdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the MaxIdleTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetMaxIdleTimeoutInMinutes() => this.MaxIdleTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property MinIdleTimeoutInMinutes. 
        /// <para>
        /// The minimum value in minutes that custom idle shutdown can be set to by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 525600)]
        public int? MinIdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the MinIdleTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetMinIdleTimeoutInMinutes() => this.MinIdleTimeoutInMinutes.HasValue;
    }
}
