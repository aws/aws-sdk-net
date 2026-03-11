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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private string _accountSetupCloudFormationUrl;
        private string _ociIdentityDomainId;
        private string _ociIdentityDomainResourceUrl;
        private string _ociIdentityDomainUrl;
        private ResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AccountSetupCloudFormationUrl. 
        /// <para>
        /// The Amazon Web Services CloudFormation URL for setting up the account integration
        /// with the OCI identity domain.
        /// </para>
        /// </summary>
        public string AccountSetupCloudFormationUrl
        {
            get { return this._accountSetupCloudFormationUrl; }
            set { this._accountSetupCloudFormationUrl = value; }
        }

        // Check to see if AccountSetupCloudFormationUrl property is set
        internal bool IsSetAccountSetupCloudFormationUrl()
        {
            return this._accountSetupCloudFormationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OciIdentityDomainId. 
        /// <para>
        /// The unique identifier of the OCI identity domain.
        /// </para>
        /// </summary>
        public string OciIdentityDomainId
        {
            get { return this._ociIdentityDomainId; }
            set { this._ociIdentityDomainId = value; }
        }

        // Check to see if OciIdentityDomainId property is set
        internal bool IsSetOciIdentityDomainId()
        {
            return this._ociIdentityDomainId != null;
        }

        /// <summary>
        /// Gets and sets the property OciIdentityDomainResourceUrl. 
        /// <para>
        /// The resource URL for accessing the OCI identity domain.
        /// </para>
        /// </summary>
        public string OciIdentityDomainResourceUrl
        {
            get { return this._ociIdentityDomainResourceUrl; }
            set { this._ociIdentityDomainResourceUrl = value; }
        }

        // Check to see if OciIdentityDomainResourceUrl property is set
        internal bool IsSetOciIdentityDomainResourceUrl()
        {
            return this._ociIdentityDomainResourceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OciIdentityDomainUrl. 
        /// <para>
        /// The URL of the OCI identity domain.
        /// </para>
        /// </summary>
        public string OciIdentityDomainUrl
        {
            get { return this._ociIdentityDomainUrl; }
            set { this._ociIdentityDomainUrl = value; }
        }

        // Check to see if OciIdentityDomainUrl property is set
        internal bool IsSetOciIdentityDomainUrl()
        {
            return this._ociIdentityDomainUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the OCI identity domain.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the OCI identity domain, if applicable.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}