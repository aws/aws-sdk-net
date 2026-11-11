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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the CreateCustomDomainAssociation operation.
    /// </summary>
    public partial class CreateCustomDomainAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster that the custom domain is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property CustomDomainCertExpiryTime. 
        /// <para>
        /// The expiration time for the certificate for the custom domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CustomDomainCertExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainCertExpiryTime property is set.
        /// </summary>
        internal bool IsSetCustomDomainCertExpiryTime() => this.CustomDomainCertExpiryTime != null;

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate associated with the custom domain
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomDomainCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainCertificateArn property is set.
        /// </summary>
        internal bool IsSetCustomDomainCertificateArn() => this.CustomDomainCertificateArn != null;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name for the association result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;
    }
}
