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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The horizontal pod autoscaler controller configuration for the Kubernetes controller
    /// manager.
    /// </summary>
    public partial class HorizontalPodAutoscalerControllerConfigResponse
    {
        private string _horizontalPodAutoscalerSyncPeriod;

        /// <summary>
        /// Gets and sets the property HorizontalPodAutoscalerSyncPeriod. 
        /// <para>
        /// The interval between each sync of the horizontal pod autoscaler.
        /// </para>
        /// </summary>
        public string HorizontalPodAutoscalerSyncPeriod
        {
            get { return this._horizontalPodAutoscalerSyncPeriod; }
            set { this._horizontalPodAutoscalerSyncPeriod = value; }
        }

        // Check to see if HorizontalPodAutoscalerSyncPeriod property is set
        internal bool IsSetHorizontalPodAutoscalerSyncPeriod()
        {
            return this._horizontalPodAutoscalerSyncPeriod != null;
        }

    }
}