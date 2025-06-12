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
    /// Details about the Kubernetes workload involved in a Kubernetes finding.
    /// </summary>
    public partial class KubernetesWorkloadDetails
    {
        private List<Container> _containers = AWSConfigs.InitializeCollections ? new List<Container>() : null;
        private bool? _hostIPC;
        private bool? _hostNetwork;
        private bool? _hostPID;
        private string _name;
        private string _awsNamespace;
        private string _serviceAccountName;
        private string _type;
        private string _uid;
        private List<Volume> _volumes = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// Containers running as part of the Kubernetes workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Container> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && (this._containers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HostIPC. 
        /// <para>
        /// Whether the host IPC flag is enabled for the pods in the workload.
        /// </para>
        /// </summary>
        public bool? HostIPC
        {
            get { return this._hostIPC; }
            set { this._hostIPC = value; }
        }

        // Check to see if HostIPC property is set
        internal bool IsSetHostIPC()
        {
            return this._hostIPC.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostNetwork. 
        /// <para>
        /// Whether the hostNetwork flag is enabled for the pods included in the workload.
        /// </para>
        /// </summary>
        public bool? HostNetwork
        {
            get { return this._hostNetwork; }
            set { this._hostNetwork = value; }
        }

        // Check to see if HostNetwork property is set
        internal bool IsSetHostNetwork()
        {
            return this._hostNetwork.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostPID. 
        /// <para>
        /// Whether the host PID flag is enabled for the pods in the workload. 
        /// </para>
        /// </summary>
        public bool? HostPID
        {
            get { return this._hostPID; }
            set { this._hostPID = value; }
        }

        // Check to see if HostPID property is set
        internal bool IsSetHostPID()
        {
            return this._hostPID.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Kubernetes workload name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Kubernetes namespace that the workload is part of.
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

        /// <summary>
        /// Gets and sets the property ServiceAccountName. 
        /// <para>
        /// The service account name that is associated with a Kubernetes workload.
        /// </para>
        /// </summary>
        public string ServiceAccountName
        {
            get { return this._serviceAccountName; }
            set { this._serviceAccountName = value; }
        }

        // Check to see if ServiceAccountName property is set
        internal bool IsSetServiceAccountName()
        {
            return this._serviceAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Kubernetes workload type (e.g. Pod, Deployment, etc.).
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// Kubernetes workload ID.
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// Volumes used by the Kubernetes workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}