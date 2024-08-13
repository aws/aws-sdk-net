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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// This is the response object from the CreateCustomDomainAssociation operation.
    /// </summary>
    public partial class CreateCustomDomainAssociationResponse : AmazonWebServiceResponse
    {
        private string _customDomainCertificateArn;
        private DateTime? _customDomainCertificateExpiryTime;
        private string _customDomainName;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The custom domain name’s certificate Amazon resource name (ARN).
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
        /// Gets and sets the property CustomDomainCertificateExpiryTime. 
        /// <para>
        /// The expiration time for the certificate.
        /// </para>
        /// </summary>
        public DateTime? CustomDomainCertificateExpiryTime
        {
            get { return this._customDomainCertificateExpiryTime; }
            set { this._customDomainCertificateExpiryTime = value; }
        }

        // Check to see if CustomDomainCertificateExpiryTime property is set
        internal bool IsSetCustomDomainCertificateExpiryTime()
        {
            return this._customDomainCertificateExpiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name to associate with the workgroup.
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

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup associated with the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}