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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the CreateService operation.
    /// </summary>
    public partial class CreateServiceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of IAM policy.
        /// </para>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property DnsEntry. 
        /// <para>
        /// The public DNS name of the service.
        /// </para>
        /// </summary>
        public DnsEntry DnsEntry { get; set; }

        /// <summary>
        /// Checks to see if the DnsEntry property is set.
        /// </summary>
        internal bool IsSetDnsEntry() => this.DnsEntry != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IdleTimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, that a connection can remain idle before VPC Lattice
        /// closes it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 600)]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetIdleTimeoutSeconds() => this.IdleTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status. If the status is <c>CREATE_FAILED</c>, you must delete and recreate the
        /// service.
        /// </para>
        /// </summary>
        public ServiceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
