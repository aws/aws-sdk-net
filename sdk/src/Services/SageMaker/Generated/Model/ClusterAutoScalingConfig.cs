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
    /// Specifies the autoscaling configuration for a HyperPod cluster.
    /// </summary>
    public partial class ClusterAutoScalingConfig
    {
        private ClusterAutoScalerType _autoScalerType;
        private ClusterAutoScalingMode _mode;

        /// <summary>
        /// Gets and sets the property AutoScalerType. 
        /// <para>
        /// The type of autoscaler to use. Currently supported value is <c>Karpenter</c>.
        /// </para>
        /// </summary>
        public ClusterAutoScalerType AutoScalerType
        {
            get { return this._autoScalerType; }
            set { this._autoScalerType = value; }
        }

        // Check to see if AutoScalerType property is set
        internal bool IsSetAutoScalerType()
        {
            return this._autoScalerType != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Describes whether autoscaling is enabled or disabled for the cluster. Valid values
        /// are <c>Enable</c> and <c>Disable</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterAutoScalingMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}