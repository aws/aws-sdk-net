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

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountConfiguration operation. Use to update
    /// the encryption configuration for an account.
    /// </summary>
    public partial class UpdateAccountConfigurationRequest : AmazonCodeGuruSecurityRequest
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The customer-managed KMS key ARN you want to use for encryption. If not specified,
        /// CodeGuru Security will use an AWS-managed key for encryption. If you previously specified
        /// a customer-managed KMS key and want CodeGuru Security to use an AWS-managed key for
        /// encryption instead, pass nothing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfig property is set.
        /// </summary>
        internal bool IsSetEncryptionConfig() => this.EncryptionConfig != null;
    }
}
