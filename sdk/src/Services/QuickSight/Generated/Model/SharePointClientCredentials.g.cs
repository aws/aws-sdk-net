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
    /// The client credentials for connecting to a Microsoft SharePoint data source using
    /// two-legged OAuth (2LO) certificate-based authentication. SharePoint connections access
    /// documents stored in SharePoint sites and libraries. The tenant ID and client ID are
    /// supplied through <c>SharePointParameters</c>.
    /// </summary>
    public partial class SharePointClientCredentials
    {
        /// <summary>
        /// Gets and sets the property CertThumbprint. 
        /// <para>
        /// The thumbprint of the certificate used for two-legged OAuth (2LO) authentication to
        /// SharePoint. This field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string CertThumbprint { get; set; }

        /// <summary>
        /// Checks to see if the CertThumbprint property is set.
        /// </summary>
        internal bool IsSetCertThumbprint() => this.CertThumbprint != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Key Management Service (AWS KMS) key used
        /// to encrypt the SharePoint certificate credentials. This field is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
