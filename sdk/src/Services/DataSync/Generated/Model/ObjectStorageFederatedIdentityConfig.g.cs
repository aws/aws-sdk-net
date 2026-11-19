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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies federated identity parameters that allow DataSync to obtain OpenID Connect
    /// token for access to customer object storage. The token allows for temporary, short-term
    /// access to the storage. DataSync automatically refreshes the token to assure uninterrupted
    /// access to the storage.
    /// 
    ///  <note> 
    /// <para>
    /// Federated identity parameters are an alternative to the <c>AccessKey</c>/<c>SecretKey</c>
    /// credentials that are expected to be valid long-term (e.g. at least for the duration
    /// of DataSync task execution). Do not specify federated identity and the key parameters
    /// for the same object storage location. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ObjectStorageFederatedIdentityConfig
    {
        /// <summary>
        /// Gets and sets the property AwsIamRole. 
        /// <para>
        /// Specifies the ARN for an Amazon Web Services role that allows DataSync to invoke STS
        /// GetWebIdentityToken API on behalf of the customer account and to obtain Amazon Web
        /// Services STS JWT (web token).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AwsIamRole { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamRole property is set.
        /// </summary>
        internal bool IsSetAwsIamRole() => this.AwsIamRole != null;

        /// <summary>
        /// Gets and sets the property ExternalIdentity. 
        /// <para>
        /// Specifies cloud-provider-specific external identity parameters used when exchanging
        /// the Amazon Web Services web token for an OpenID Connect token at the object storage
        /// provider.
        /// </para>
        /// </summary>
        public ObjectStorageExternalIdentityConfig ExternalIdentity { get; set; }

        /// <summary>
        /// Checks to see if the ExternalIdentity property is set.
        /// </summary>
        internal bool IsSetExternalIdentity() => this.ExternalIdentity != null;
    }
}
