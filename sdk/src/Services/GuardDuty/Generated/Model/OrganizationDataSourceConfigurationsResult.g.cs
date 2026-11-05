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
    /// An object that contains information on which data sources are automatically enabled
    /// for new members within the organization.
    /// </summary>
    public partial class OrganizationDataSourceConfigurationsResult
    {
        /// <summary>
        /// Gets and sets the property Kubernetes. 
        /// <para>
        /// Describes the configuration of Kubernetes data sources.
        /// </para>
        /// </summary>
        public OrganizationKubernetesConfigurationResult Kubernetes { get; set; }

        /// <summary>
        /// Checks to see if the Kubernetes property is set.
        /// </summary>
        internal bool IsSetKubernetes() => this.Kubernetes != null;

        /// <summary>
        /// Gets and sets the property MalwareProtection. 
        /// <para>
        /// Describes the configuration of Malware Protection data source for an organization.
        /// </para>
        /// </summary>
        public OrganizationMalwareProtectionConfigurationResult MalwareProtection { get; set; }

        /// <summary>
        /// Checks to see if the MalwareProtection property is set.
        /// </summary>
        internal bool IsSetMalwareProtection() => this.MalwareProtection != null;

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        /// Describes whether S3 data event logs are enabled as a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationS3LogsConfigurationResult S3Logs { get; set; }

        /// <summary>
        /// Checks to see if the S3Logs property is set.
        /// </summary>
        internal bool IsSetS3Logs() => this.S3Logs != null;
    }
}
