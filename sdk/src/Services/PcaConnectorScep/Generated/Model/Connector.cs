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
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
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
    /// Connector for SCEP is a service that links Amazon Web Services Private Certificate
    /// Authority to your SCEP-enabled devices. The connector brokers the exchange of certificates
    /// from Amazon Web Services Private CA to your SCEP-enabled devices and mobile device
    /// management systems. The connector is a complex type that contains the connector's
    /// configuration settings.
    /// </summary>
    public partial class Connector
    {
        private string _arn;
        private string _certificateAuthorityArn;
        private DateTime? _createdAt;
        private string _endpoint;
        private MobileDeviceManagement _mobileDeviceManagement;
        private OpenIdConfiguration _openIdConfiguration;
        private ConnectorStatus _status;
        private ConnectorStatusReason _statusReason;
        private ConnectorType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=200)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate authority associated with the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=200)]
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the connector was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connector's HTTPS public SCEP URL.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property MobileDeviceManagement. 
        /// <para>
        /// Contains settings relevant to the mobile device management system that you chose for
        /// the connector. If you didn't configure <c>MobileDeviceManagement</c>, then the connector
        /// is for general-purpose use and this object is empty.
        /// </para>
        /// </summary>
        public MobileDeviceManagement MobileDeviceManagement
        {
            get { return this._mobileDeviceManagement; }
            set { this._mobileDeviceManagement = value; }
        }

        // Check to see if MobileDeviceManagement property is set
        internal bool IsSetMobileDeviceManagement()
        {
            return this._mobileDeviceManagement != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIdConfiguration. 
        /// <para>
        /// Contains OpenID Connect (OIDC) parameters for use with Connector for SCEP for Microsoft
        /// Intune. For more information about using Connector for SCEP for Microsoft Intune,
        /// see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-intune.html">Using
        /// Connector for SCEP for Microsoft Intune</a>.
        /// </para>
        /// </summary>
        public OpenIdConfiguration OpenIdConfiguration
        {
            get { return this._openIdConfiguration; }
            set { this._openIdConfiguration = value; }
        }

        // Check to see if OpenIdConfiguration property is set
        internal bool IsSetOpenIdConfiguration()
        {
            return this._openIdConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The connector's status.
        /// </para>
        /// </summary>
        public ConnectorStatus Status
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
        /// Information about why connector creation failed, if status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ConnectorStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The connector type.
        /// </para>
        /// </summary>
        public ConnectorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the connector was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}