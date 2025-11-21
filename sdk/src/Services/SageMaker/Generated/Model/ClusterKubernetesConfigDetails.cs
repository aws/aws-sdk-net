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
    /// Detailed Kubernetes configuration showing both the current and desired state of labels
    /// and taints for cluster nodes.
    /// </summary>
    public partial class ClusterKubernetesConfigDetails
    {
        private Dictionary<string, string> _currentLabels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<ClusterKubernetesTaint> _currentTaints = AWSConfigs.InitializeCollections ? new List<ClusterKubernetesTaint>() : null;
        private Dictionary<string, string> _desiredLabels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<ClusterKubernetesTaint> _desiredTaints = AWSConfigs.InitializeCollections ? new List<ClusterKubernetesTaint>() : null;

        /// <summary>
        /// Gets and sets the property CurrentLabels. 
        /// <para>
        /// The current labels applied to cluster nodes of an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> CurrentLabels
        {
            get { return this._currentLabels; }
            set { this._currentLabels = value; }
        }

        // Check to see if CurrentLabels property is set
        internal bool IsSetCurrentLabels()
        {
            return this._currentLabels != null && (this._currentLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CurrentTaints. 
        /// <para>
        /// The current taints applied to cluster nodes of an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ClusterKubernetesTaint> CurrentTaints
        {
            get { return this._currentTaints; }
            set { this._currentTaints = value; }
        }

        // Check to see if CurrentTaints property is set
        internal bool IsSetCurrentTaints()
        {
            return this._currentTaints != null && (this._currentTaints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DesiredLabels. 
        /// <para>
        /// The desired labels to be applied to cluster nodes of an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> DesiredLabels
        {
            get { return this._desiredLabels; }
            set { this._desiredLabels = value; }
        }

        // Check to see if DesiredLabels property is set
        internal bool IsSetDesiredLabels()
        {
            return this._desiredLabels != null && (this._desiredLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DesiredTaints. 
        /// <para>
        /// The desired taints to be applied to cluster nodes of an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ClusterKubernetesTaint> DesiredTaints
        {
            get { return this._desiredTaints; }
            set { this._desiredTaints = value; }
        }

        // Check to see if DesiredTaints property is set
        internal bool IsSetDesiredTaints()
        {
            return this._desiredTaints != null && (this._desiredTaints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}