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
    /// An object that contains information on which data sources will be configured to be
    /// automatically enabled for new members within the organization.
    /// </summary>
    public partial class OrganizationDataSourceConfigurations
    {
        private OrganizationKubernetesConfiguration _kubernetes;
        private OrganizationMalwareProtectionConfiguration _malwareProtection;
        private OrganizationS3LogsConfiguration _s3Logs;

        /// <summary>
        /// Gets and sets the property Kubernetes. 
        /// <para>
        /// Describes the configuration of Kubernetes data sources for new members of the organization.
        /// </para>
        /// </summary>
        public OrganizationKubernetesConfiguration Kubernetes
        {
            get { return this._kubernetes; }
            set { this._kubernetes = value; }
        }

        // Check to see if Kubernetes property is set
        internal bool IsSetKubernetes()
        {
            return this._kubernetes != null;
        }

        /// <summary>
        /// Gets and sets the property MalwareProtection. 
        /// <para>
        /// Describes the configuration of Malware Protection for new members of the organization.
        /// </para>
        /// </summary>
        public OrganizationMalwareProtectionConfiguration MalwareProtection
        {
            get { return this._malwareProtection; }
            set { this._malwareProtection = value; }
        }

        // Check to see if MalwareProtection property is set
        internal bool IsSetMalwareProtection()
        {
            return this._malwareProtection != null;
        }

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        /// Describes whether S3 data event logs are enabled for new members of the organization.
        /// </para>
        /// </summary>
        public OrganizationS3LogsConfiguration S3Logs
        {
            get { return this._s3Logs; }
            set { this._s3Logs = value; }
        }

        // Check to see if S3Logs property is set
        internal bool IsSetS3Logs()
        {
            return this._s3Logs != null;
        }

    }
}