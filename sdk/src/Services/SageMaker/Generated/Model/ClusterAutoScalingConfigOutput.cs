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
    /// The autoscaling configuration and status information for a HyperPod cluster.
    /// </summary>
    public partial class ClusterAutoScalingConfigOutput
    {
        private ClusterAutoScalerType _autoScalerType;
        private string _failureMessage;
        private ClusterAutoScalingMode _mode;
        private ClusterAutoScalingStatus _status;

        /// <summary>
        /// Gets and sets the property AutoScalerType. 
        /// <para>
        /// The type of autoscaler configured for the cluster.
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
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If the autoscaling status is <c>Failed</c>, this field contains a message describing
        /// the failure.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Describes whether autoscaling is enabled or disabled for the cluster.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the autoscaling configuration. Valid values are <c>InService</c>,
        /// <c>Failed</c>, <c>Creating</c>, and <c>Deleting</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterAutoScalingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}