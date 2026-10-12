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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about an Oracle Cloud Infrastructure (OCI) identity domain configuration.
    /// </summary>
    public partial class OciIdentityDomain
    {
        /// <summary>
        /// Gets and sets the property AccountSetupCloudFormationUrl. 
        /// <para>
        /// The Amazon Web Services CloudFormation URL for setting up the account integration
        /// with the OCI identity domain.
        /// </para>
        /// </summary>
        public string AccountSetupCloudFormationUrl { get; set; }

        /// <summary>
        /// Checks to see if the AccountSetupCloudFormationUrl property is set.
        /// </summary>
        internal bool IsSetAccountSetupCloudFormationUrl() => this.AccountSetupCloudFormationUrl != null;

        /// <summary>
        /// Gets and sets the property OciIdentityDomainId. 
        /// <para>
        /// The unique identifier of the OCI identity domain.
        /// </para>
        /// </summary>
        public string OciIdentityDomainId { get; set; }

        /// <summary>
        /// Checks to see if the OciIdentityDomainId property is set.
        /// </summary>
        internal bool IsSetOciIdentityDomainId() => this.OciIdentityDomainId != null;

        /// <summary>
        /// Gets and sets the property OciIdentityDomainResourceUrl. 
        /// <para>
        /// The resource URL for accessing the OCI identity domain.
        /// </para>
        /// </summary>
        public string OciIdentityDomainResourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciIdentityDomainResourceUrl property is set.
        /// </summary>
        internal bool IsSetOciIdentityDomainResourceUrl() => this.OciIdentityDomainResourceUrl != null;

        /// <summary>
        /// Gets and sets the property OciIdentityDomainUrl. 
        /// <para>
        /// The URL of the OCI identity domain.
        /// </para>
        /// </summary>
        public string OciIdentityDomainUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciIdentityDomainUrl property is set.
        /// </summary>
        internal bool IsSetOciIdentityDomainUrl() => this.OciIdentityDomainUrl != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the OCI identity domain.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the OCI identity domain, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
