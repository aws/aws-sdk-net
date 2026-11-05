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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The service account credentials used for Google Workspace domain-wide delegation.
    /// Use this structure when you authenticate a data source connection using domain-wide
    /// delegation across your Google Workspace domain.
    /// </summary>
    public partial class ServiceAccountCredentials
    {
        /// <summary>
        /// Gets and sets the property AdminAccountEmail. 
        /// <para>
        /// The email address of the Google Workspace administrator account that the service account
        /// impersonates through domain-wide delegation. This field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AdminAccountEmail { get; set; }

        /// <summary>
        /// Checks to see if the AdminAccountEmail property is set.
        /// </summary>
        internal bool IsSetAdminAccountEmail() => this.AdminAccountEmail != null;

        /// <summary>
        /// Gets and sets the property ClientEmail. 
        /// <para>
        /// The client email address of the Google service account used for domain-wide delegation.
        /// This field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Checks to see if the ClientEmail property is set.
        /// </summary>
        internal bool IsSetClientEmail() => this.ClientEmail != null;

        /// <summary>
        /// Gets and sets the property ServiceAccountPrivateKey. 
        /// <para>
        /// The private key of the Google service account used for domain-wide delegation. This
        /// field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1600, Max = 8000)]
        public string ServiceAccountPrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountPrivateKey property is set.
        /// </summary>
        internal bool IsSetServiceAccountPrivateKey() => this.ServiceAccountPrivateKey != null;
    }
}
