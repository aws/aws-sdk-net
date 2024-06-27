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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Information about the Active Directory config.
    /// </summary>
    public partial class ActiveDirectoryConfig
    {
        private string _domainName;
        private string _serviceAccountSecretArn;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ServiceAccountSecretArn. 
        /// <para>
        /// Indicates the secret ARN on the service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceAccountSecretArn
        {
            get { return this._serviceAccountSecretArn; }
            set { this._serviceAccountSecretArn = value; }
        }

        // Check to see if ServiceAccountSecretArn property is set
        internal bool IsSetServiceAccountSecretArn()
        {
            return this._serviceAccountSecretArn != null;
        }

    }
}