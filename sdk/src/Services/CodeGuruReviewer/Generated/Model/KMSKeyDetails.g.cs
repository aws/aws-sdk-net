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

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// An object that contains:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The encryption option for a repository association. It is either owned by Amazon Web
    /// Services Key Management Service (KMS) (<c>AWS_OWNED_CMK</c>) or customer managed (<c>CUSTOMER_MANAGED_CMK</c>).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The ID of the Amazon Web Services KMS key that is associated with a repository association.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class KMSKeyDetails
    {
        /// <summary>
        /// Gets and sets the property EncryptionOption. 
        /// <para>
        /// The encryption option for a repository association. It is either owned by Amazon Web
        /// Services Key Management Service (KMS) (<c>AWS_OWNED_CMK</c>) or customer managed (<c>CUSTOMER_MANAGED_CMK</c>).
        /// </para>
        /// </summary>
        public EncryptionOption EncryptionOption { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionOption property is set.
        /// </summary>
        internal bool IsSetEncryptionOption() => this.EncryptionOption != null;

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services KMS key that is associated with a repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyId property is set.
        /// </summary>
        internal bool IsSetKMSKeyId() => this.KMSKeyId != null;
    }
}
