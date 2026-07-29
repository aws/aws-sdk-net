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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVirtualCluster operation.
    /// Updates a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
    /// You can create, update, describe, list and delete virtual clusters. They do not consume
    /// any additional resource in your system. A single virtual cluster maps to a single
    /// Kubernetes namespace. Given this relationship, you can model virtual clusters the
    /// same way you model Kubernetes namespaces to meet your requirements.
    /// </summary>
    public partial class UpdateVirtualClusterRequest : AmazonEMRContainersRequest
    {
        private string _clientToken;
        private string _id;
        private SchedulerConfiguration _schedulerConfiguration;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If this token matches a previous request, the service
        /// ignores the request, but does not return an error.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the virtual cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulerConfiguration. 
        /// <para>
        /// The scheduler configuration to apply to the virtual cluster. The new configuration
        /// fully replaces the existing one. If you omit a field, the corresponding limit is removed.
        /// </para>
        /// </summary>
        public SchedulerConfiguration SchedulerConfiguration
        {
            get { return this._schedulerConfiguration; }
            set { this._schedulerConfiguration = value; }
        }

        // Check to see if SchedulerConfiguration property is set
        internal bool IsSetSchedulerConfiguration()
        {
            return this._schedulerConfiguration != null;
        }

    }
}