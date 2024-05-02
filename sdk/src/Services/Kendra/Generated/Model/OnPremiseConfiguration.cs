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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to GitHub Enterprise Server (on
    /// premises).
    /// </summary>
    public partial class OnPremiseConfiguration
    {
        private string _hostUrl;
        private string _organizationName;
        private S3Path _sslCertificateS3Path;

        /// <summary>
        /// Gets and sets the property HostUrl. 
        /// <para>
        /// The GitHub host URL or API endpoint URL. For example, <i>https://on-prem-host-url/api/v3/</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string HostUrl
        {
            get { return this._hostUrl; }
            set { this._hostUrl = value; }
        }

        // Check to see if HostUrl property is set
        internal bool IsSetHostUrl()
        {
            return this._hostUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// The name of the organization of the GitHub Enterprise Server (on-premises) account
        /// you want to connect to. You can find your organization name by logging into GitHub
        /// desktop and selecting <b>Your organizations</b> under your profile picture dropdown.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string OrganizationName
        {
            get { return this._organizationName; }
            set { this._organizationName = value; }
        }

        // Check to see if OrganizationName property is set
        internal bool IsSetOrganizationName()
        {
            return this._organizationName != null;
        }

        /// <summary>
        /// Gets and sets the property SslCertificateS3Path. 
        /// <para>
        /// The path to the SSL certificate stored in an Amazon S3 bucket. You use this to connect
        /// to GitHub if you require a secure SSL connection.
        /// </para>
        ///  
        /// <para>
        /// You can simply generate a self-signed X509 certificate on any computer using OpenSSL.
        /// For an example of using OpenSSL to create an X509 certificate, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/configuring-https-ssl.html">Create
        /// and sign an X509 certificate</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Path SslCertificateS3Path
        {
            get { return this._sslCertificateS3Path; }
            set { this._sslCertificateS3Path = value; }
        }

        // Check to see if SslCertificateS3Path property is set
        internal bool IsSetSslCertificateS3Path()
        {
            return this._sslCertificateS3Path != null;
        }

    }
}