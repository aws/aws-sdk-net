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

namespace Amazon.PcaConnectorScep.Model
{
    /// <summary>
    /// Lists the Amazon Web Services Private CA SCEP connectors belonging to your Amazon
    /// Web Services account.
    /// </summary>
    public partial class ConnectorSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector's associated certificate authority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the challenge was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connector's HTTPS public SCEP URL.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property MobileDeviceManagement. 
        /// <para>
        /// Contains settings relevant to the mobile device management system that you chose for
        /// the connector. If you didn't configure <c>MobileDeviceManagement</c>, then the connector
        /// is for general-purpose use and this object is empty.
        /// </para>
        /// </summary>
        public MobileDeviceManagement MobileDeviceManagement { get; set; }

        /// <summary>
        /// Checks to see if the MobileDeviceManagement property is set.
        /// </summary>
        internal bool IsSetMobileDeviceManagement() => this.MobileDeviceManagement != null;

        /// <summary>
        /// Gets and sets the property OpenIdConfiguration. 
        /// <para>
        /// Contains OpenID Connect (OIDC) parameters for use with Microsoft Intune.
        /// </para>
        /// </summary>
        public OpenIdConfiguration OpenIdConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenIdConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenIdConfiguration() => this.OpenIdConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The connector's status. Status can be creating, active, deleting, or failed.
        /// </para>
        /// </summary>
        public ConnectorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why connector creation failed, if status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ConnectorStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The connector type.
        /// </para>
        /// </summary>
        public ConnectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the challenge was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
