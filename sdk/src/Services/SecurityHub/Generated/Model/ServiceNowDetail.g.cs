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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a ServiceNow ITSM integration.
    /// </summary>
    public partial class ServiceNowDetail
    {
        /// <summary>
        /// Gets and sets the property AuthStatus. 
        /// <para>
        /// The status of the authorization between ServiceNow and the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorAuthStatus AuthStatus { get; set; }

        /// <summary>
        /// Checks to see if the AuthStatus property is set.
        /// </summary>
        internal bool IsSetAuthStatus() => this.AuthStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The instanceName of ServiceNow ITSM.
        /// </para>
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// contains the ServiceNow credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;
    }
}
