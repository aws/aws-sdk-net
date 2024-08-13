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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Amazon Web Services Private CA Connector for Active Directory is a service that links
    /// your Active Directory with Amazon Web Services Private CA. The connector brokers the
    /// exchange of certificates from Amazon Web Services Private CA to domain-joined users
    /// and machines managed with Active Directory.
    /// </summary>
    public partial class Connector
    {
        private string _arn;
        private string _certificateAuthorityArn;
        private string _certificateEnrollmentPolicyServerEndpoint;
        private DateTime? _createdAt;
        private string _directoryId;
        private ConnectorStatus _status;
        private ConnectorStatusReason _statusReason;
        private DateTime? _updatedAt;
        private VpcInformation _vpcInformation;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector.html">CreateConnector</a>.
        /// 
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
        /// The Amazon Resource Name (ARN) of the certificate authority being used. 
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
        /// Gets and sets the property CertificateEnrollmentPolicyServerEndpoint. 
        /// <para>
        /// Certificate enrollment endpoint for Active Directory domain-joined objects reach out
        /// to when requesting certificates.
        /// </para>
        /// </summary>
        public string CertificateEnrollmentPolicyServerEndpoint
        {
            get { return this._certificateEnrollmentPolicyServerEndpoint; }
            set { this._certificateEnrollmentPolicyServerEndpoint = value; }
        }

        // Check to see if CertificateEnrollmentPolicyServerEndpoint property is set
        internal bool IsSetCertificateEnrollmentPolicyServerEndpoint()
        {
            return this._certificateEnrollmentPolicyServerEndpoint != null;
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
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Active Directory.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the connector. Status can be creating, active, deleting, or failed.
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
        /// Additional information about the connector status if the status is failed.
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

        /// <summary>
        /// Gets and sets the property VpcInformation. 
        /// <para>
        /// Information of the VPC and security group(s) used with the connector.
        /// </para>
        /// </summary>
        public VpcInformation VpcInformation
        {
            get { return this._vpcInformation; }
            set { this._vpcInformation = value; }
        }

        // Check to see if VpcInformation property is set
        internal bool IsSetVpcInformation()
        {
            return this._vpcInformation != null;
        }

    }
}