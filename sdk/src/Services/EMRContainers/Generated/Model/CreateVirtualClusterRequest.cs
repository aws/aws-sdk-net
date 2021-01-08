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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualCluster operation.
    /// Creates a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
    /// You can create, describe, list and delete virtual clusters. They do not consume any
    /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
    /// namespace. Given this relationship, you can model virtual clusters the same way you
    /// model Kubernetes namespaces to meet your requirements.
    /// </summary>
    public partial class CreateVirtualClusterRequest : AmazonEMRContainersRequest
    {
        private string _clientToken;
        private ContainerProvider _containerProvider;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProvider. 
        /// <para>
        /// The container provider of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerProvider ContainerProvider
        {
            get { return this._containerProvider; }
            set { this._containerProvider = value; }
        }

        // Check to see if ContainerProvider property is set
        internal bool IsSetContainerProvider()
        {
            return this._containerProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The specified name of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}