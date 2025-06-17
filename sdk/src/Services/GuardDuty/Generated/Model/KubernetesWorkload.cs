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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about Kubernetes workloads involved in a GuardDuty finding, including
    /// pods, deployments, and other Kubernetes resources.
    /// </summary>
    public partial class KubernetesWorkload
    {
        private List<string> _containerUids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private KubernetesResourcesTypes _kubernetesResourcesTypes;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property ContainerUids. 
        /// <para>
        /// A list of unique identifiers for the containers that are part of the Kubernetes workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContainerUids
        {
            get { return this._containerUids; }
            set { this._containerUids = value; }
        }

        // Check to see if ContainerUids property is set
        internal bool IsSetContainerUids()
        {
            return this._containerUids != null && (this._containerUids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KubernetesResourcesTypes. 
        /// <para>
        /// The types of Kubernetes resources involved in the workload.
        /// </para>
        /// </summary>
        public KubernetesResourcesTypes KubernetesResourcesTypes
        {
            get { return this._kubernetesResourcesTypes; }
            set { this._kubernetesResourcesTypes = value; }
        }

        // Check to see if KubernetesResourcesTypes property is set
        internal bool IsSetKubernetesResourcesTypes()
        {
            return this._kubernetesResourcesTypes != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Kubernetes namespace in which the workload is running, providing logical isolation
        /// within the cluster.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}