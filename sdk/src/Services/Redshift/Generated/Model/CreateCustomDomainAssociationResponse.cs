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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private string _clusterIdentifier;
        private string _customDomainCertExpiryTime;
        private string _customDomainCertificateArn;
        private string _customDomainName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster that the custom domain is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertExpiryTime. 
        /// <para>
        /// The expiration time for the certificate for the custom domain.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CustomDomainCertExpiryTime
        {
            get { return this._customDomainCertExpiryTime; }
            set { this._customDomainCertExpiryTime = value; }
        }

        // Check to see if CustomDomainCertExpiryTime property is set
        internal bool IsSetCustomDomainCertExpiryTime()
        {
            return this._customDomainCertExpiryTime != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate associated with the custom domain
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomDomainCertificateArn
        {
            get { return this._customDomainCertificateArn; }
            set { this._customDomainCertificateArn = value; }
        }

        // Check to see if CustomDomainCertificateArn property is set
        internal bool IsSetCustomDomainCertificateArn()
        {
            return this._customDomainCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name for the association result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string CustomDomainName
        {
            get { return this._customDomainName; }
            set { this._customDomainName = value; }
        }

        // Check to see if CustomDomainName property is set
        internal bool IsSetCustomDomainName()
        {
            return this._customDomainName != null;
        }

    }
}