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
    /// Container for the parameters to the DisassociateCustomDomain operation.
    /// Disassociate a custom domain name from an App Runner service.
    /// 
    ///  
    /// <para>
    /// Certificates tracking domain validity are associated with a custom domain and are
    /// stored in <a href="https://docs.aws.amazon.com/acm/latest/userguide">AWS Certificate
    /// Manager (ACM)</a>. These certificates aren't deleted as part of this action. App Runner
    /// delays certificate deletion for 30 days after a domain is disassociated from your
    /// service.
    /// </para>
    /// </summary>
    public partial class DisassociateCustomDomainRequest : AmazonAppRunnerRequest
    {
        private string _domainName;
        private string _serviceArn;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that you want to disassociate from the App Runner service.
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
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner service that you want to disassociate
        /// a custom domain name from.
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