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
    /// Settings that control the range in the number of instances that the endpoint provisions
    /// as it scales up or down to accommodate traffic.
    /// </summary>
    public partial class ProductionVariantManagedInstanceScaling
    {
        /// <summary>
        /// Gets and sets the property MaxInstanceCount. 
        /// <para>
        /// The maximum number of instances that the endpoint can provision when it scales up
        /// to accommodate an increase in traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstanceCount property is set.
        /// </summary>
        internal bool IsSetMaxInstanceCount() => this.MaxInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinInstanceCount. 
        /// <para>
        /// The minimum number of instances that the endpoint must retain when it scales down
        /// to accommodate a decrease in traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MinInstanceCount property is set.
        /// </summary>
        internal bool IsSetMinInstanceCount() => this.MinInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ScaleInPolicy. 
        /// <para>
        /// Configures the scale-in behavior for managed instance scaling.
        /// </para>
        /// </summary>
        public ProductionVariantManagedInstanceScalingScaleInPolicy ScaleInPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ScaleInPolicy property is set.
        /// </summary>
        internal bool IsSetScaleInPolicy() => this.ScaleInPolicy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether managed instance scaling is enabled.
        /// </para>
        /// </summary>
        public ManagedInstanceScalingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
