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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector.html">CreateConnector</a>.
        /// 
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
        /// The Amazon Resource Name (ARN) of the certificate authority being used. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property CertificateEnrollmentPolicyServerEndpoint. 
        /// <para>
        /// Certificate enrollment endpoint for Active Directory domain-joined objects reach out
        /// to when requesting certificates.
        /// </para>
        /// </summary>
        public string CertificateEnrollmentPolicyServerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CertificateEnrollmentPolicyServerEndpoint property is set.
        /// </summary>
        internal bool IsSetCertificateEnrollmentPolicyServerEndpoint() => this.CertificateEnrollmentPolicyServerEndpoint != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the connector was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Active Directory.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the connector. Status can be creating, active, deleting, or failed.
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
        /// Additional information about the connector status if the status is failed.
        /// </para>
        /// </summary>
        public ConnectorStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the connector was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VpcInformation. 
        /// <para>
        /// Information of the VPC and security group(s) used with the connector.
        /// </para>
        /// </summary>
        public VpcInformation VpcInformation { get; set; }

        /// <summary>
        /// Checks to see if the VpcInformation property is set.
        /// </summary>
        internal bool IsSetVpcInformation() => this.VpcInformation != null;
    }
}
