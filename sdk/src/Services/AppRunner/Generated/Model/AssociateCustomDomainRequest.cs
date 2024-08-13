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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateCustomDomain operation.
    /// Associate your own domain name with the App Runner subdomain URL of your App Runner
    /// service.
    /// 
    ///  
    /// <para>
    /// After you call <c>AssociateCustomDomain</c> and receive a successful response, use
    /// the information in the <a>CustomDomain</a> record that's returned to add CNAME records
    /// to your Domain Name System (DNS). For each mapped domain name, add a mapping to the
    /// target App Runner subdomain and one or more certificate validation records. App Runner
    /// then performs DNS validation to verify that you own or control the domain name that
    /// you associated. App Runner tracks domain validity in a certificate stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS
    /// Certificate Manager (ACM)</a>.
    /// </para>
    /// </summary>
    public partial class AssociateCustomDomainRequest : AmazonAppRunnerRequest
    {
        private string _domainName;
        private bool? _enableWWWSubdomain;
        private string _serviceArn;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A custom domain endpoint to associate. Specify a root domain (for example, <c>example.com</c>),
        /// a subdomain (for example, <c>login.example.com</c> or <c>admin.login.example.com</c>),
        /// or a wildcard (for example, <c>*.example.com</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableWWWSubdomain. 
        /// <para>
        /// Set to <c>true</c> to associate the subdomain <c>www.<i>DomainName</i> </c> with the
        /// App Runner service in addition to the base domain.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? EnableWWWSubdomain
        {
            get { return this._enableWWWSubdomain; }
            set { this._enableWWWSubdomain = value; }
        }

        // Check to see if EnableWWWSubdomain property is set
        internal bool IsSetEnableWWWSubdomain()
        {
            return this._enableWWWSubdomain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner service that you want to associate
        /// a custom domain name with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

    }
}