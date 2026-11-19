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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The access details and targets for connecting to a Google Cloud Platform (GCP) environment,
    /// including the workload identity pool provider and service account used for authentication
    /// and the projects to target.
    /// </summary>
    public partial class GcpConfiguration
    {
        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the GCP organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property ServiceAccountEmail. 
        /// <para>
        /// The email address of the GCP service account used for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountEmail property is set.
        /// </summary>
        internal bool IsSetServiceAccountEmail() => this.ServiceAccountEmail != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The target GCP projects for the cloud connector.
        /// </para>
        /// </summary>
        public GcpConfigurationTargets Targets { get; set; }

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityPoolProvider. 
        /// <para>
        /// The full resource name of the GCP workload identity pool provider used for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string WorkloadIdentityPoolProvider { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityPoolProvider property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityPoolProvider() => this.WorkloadIdentityPoolProvider != null;
    }
}
