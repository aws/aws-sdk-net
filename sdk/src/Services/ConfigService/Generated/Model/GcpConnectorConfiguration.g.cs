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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The configuration details for connecting to Google Cloud.
    /// </summary>
    public partial class GcpConnectorConfiguration
    {
        /// <summary>
        /// Gets and sets the property GcpOrganizationId. 
        /// <para>
        /// The ID of the Google Cloud organization that contains the connector's management project,
        /// which is the project of the service account in <c>serviceAccountEmail</c>.
        /// </para>
        ///  
        /// <para>
        /// Required if the management project belongs to an organization. A connector needs an
        /// organization ID to record an entire organization or more than one project. Omit it
        /// only if the management project doesn't belong to an organization. In that case, the
        /// connector can record only the management project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string GcpOrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the GcpOrganizationId property is set.
        /// </summary>
        internal bool IsSetGcpOrganizationId() => this.GcpOrganizationId != null;

        /// <summary>
        /// Gets and sets the property ServiceAccountEmail. 
        /// <para>
        /// The email address of the Google Cloud service account that Config uses to access your
        /// Google Cloud resources. The format is <c>SERVICE_ACCOUNT_NAME@PROJECT_ID.iam.gserviceaccount.com</c>.
        /// </para>
        ///  
        /// <para>
        /// The project that contains this service account is the connector's management project.
        /// If the connector has no <c>gcpOrganizationId</c>, it can record only the management
        /// project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountEmail property is set.
        /// </summary>
        internal bool IsSetServiceAccountEmail() => this.ServiceAccountEmail != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityPoolProvider. 
        /// <para>
        /// The full resource name of the Google Cloud workload identity pool provider that trusts
        /// Config. The format is <c>projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID/providers/PROVIDER_ID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string WorkloadIdentityPoolProvider { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityPoolProvider property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityPoolProvider() => this.WorkloadIdentityPoolProvider != null;
    }
}
