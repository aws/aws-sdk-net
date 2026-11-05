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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Details about the Kubernetes workload involved in a Kubernetes finding.
    /// </summary>
    public partial class KubernetesWorkloadDetails
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// Containers running as part of the Kubernetes workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Container> Containers { get; set; } = AWSConfigs.InitializeCollections ? new List<Container>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HostIPC. 
        /// <para>
        /// Whether the host IPC flag is enabled for the pods in the workload.
        /// </para>
        /// </summary>
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Checks to see if the HostIPC property is set.
        /// </summary>
        internal bool IsSetHostIPC() => this.HostIPC.HasValue;

        /// <summary>
        /// Gets and sets the property HostNetwork. 
        /// <para>
        /// Whether the hostNetwork flag is enabled for the pods included in the workload.
        /// </para>
        /// </summary>
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Checks to see if the HostNetwork property is set.
        /// </summary>
        internal bool IsSetHostNetwork() => this.HostNetwork.HasValue;

        /// <summary>
        /// Gets and sets the property HostPID. 
        /// <para>
        /// Whether the host PID flag is enabled for the pods in the workload. 
        /// </para>
        /// </summary>
        public bool? HostPID { get; set; }

        /// <summary>
        /// Checks to see if the HostPID property is set.
        /// </summary>
        internal bool IsSetHostPID() => this.HostPID.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Kubernetes workload name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Kubernetes namespace that the workload is part of.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property ServiceAccountName. 
        /// <para>
        /// The service account name that is associated with a Kubernetes workload.
        /// </para>
        /// </summary>
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountName property is set.
        /// </summary>
        internal bool IsSetServiceAccountName() => this.ServiceAccountName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Kubernetes workload type (e.g. Pod, Deployment, etc.).
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// Kubernetes workload ID.
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Volumes used by the Kubernetes workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Volume> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
