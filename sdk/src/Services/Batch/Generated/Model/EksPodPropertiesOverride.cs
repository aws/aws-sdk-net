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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that contains overrides for the Kubernetes pod properties of a job.
    /// </summary>
    public partial class EksPodPropertiesOverride
    {
        private List<EksContainerOverride> _containers = AWSConfigs.InitializeCollections ? new List<EksContainerOverride>() : null;
        private List<EksContainerOverride> _initContainers = AWSConfigs.InitializeCollections ? new List<EksContainerOverride>() : null;
        private EksMetadata _metadata;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The overrides for the container that's used on the Amazon EKS pod.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainerOverride> Containers
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
        /// Gets and sets the property InitContainers. 
        /// <para>
        /// The overrides for the <c>initContainers</c> defined in the Amazon EKS pod. These containers
        /// run before application containers, always run to completion, and must complete successfully
        /// before the next container starts. These containers are registered with the Amazon
        /// EKS Connector agent and persists the registration information in the Kubernetes backend
        /// data store. For more information, see <a href="https://kubernetes.io/docs/concepts/workloads/pods/init-containers/">Init
        /// Containers</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainerOverride> InitContainers
        {
            get { return this._initContainers; }
            set { this._initContainers = value; }
        }

        // Check to see if InitContainers property is set
        internal bool IsSetInitContainers()
        {
            return this._initContainers != null && (this._initContainers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the overrides for the container that's used on the Amazon EKS pod.
        /// </para>
        /// </summary>
        public EksMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

    }
}