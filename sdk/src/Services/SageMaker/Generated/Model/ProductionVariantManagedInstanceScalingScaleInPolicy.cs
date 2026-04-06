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
    /// Configures the scale-in behavior for managed instance scaling.
    /// </summary>
    public partial class ProductionVariantManagedInstanceScalingScaleInPolicy
    {
        private int? _cooldownInMinutes;
        private int? _maximumStepSize;
        private ManagedInstanceScalingScaleInStrategy _strategy;

        /// <summary>
        /// Gets and sets the property CooldownInMinutes. 
        /// <para>
        /// The cooldown period, in minutes, after the last endpoint operation before the endpoint
        /// evaluates consolidation scale-in opportunities.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>20</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1440)]
        public int? CooldownInMinutes
        {
            get { return this._cooldownInMinutes; }
            set { this._cooldownInMinutes = value; }
        }

        // Check to see if CooldownInMinutes property is set
        internal bool IsSetCooldownInMinutes()
        {
            return this._cooldownInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumStepSize. 
        /// <para>
        /// The maximum number of instances that the endpoint can terminate at a time during a
        /// consolidation scale-in operation.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaximumStepSize
        {
            get { return this._maximumStepSize; }
            set { this._maximumStepSize = value; }
        }

        // Check to see if MaximumStepSize property is set
        internal bool IsSetMaximumStepSize()
        {
            return this._maximumStepSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The strategy for scaling in instances.
        /// </para>
        ///  <dl> <dt>IDLE_RELEASE</dt> <dd> 
        /// <para>
        /// Releases instances that have no hosted inference component copies.
        /// </para>
        ///  </dd> <dt>CONSOLIDATION</dt> <dd> 
        /// <para>
        /// Consolidates inference component copies onto fewer instances to release more instances.
        /// Consolidation honors the scheduling configuration of each inference component. For
        /// example, if an inference component specifies Availability Zone balance, consolidation
        /// only proceeds when the resulting distribution does not increase the imbalance.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedInstanceScalingScaleInStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}