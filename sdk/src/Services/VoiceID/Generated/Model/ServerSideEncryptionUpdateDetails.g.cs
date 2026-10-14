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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Details about the most recent server-side encryption configuration update. When the
    /// server-side encryption configuration is changed, dependency on the old KMS key is
    /// removed through an asynchronous process. When this update is complete, the domain’s
    /// data can only be accessed using the new KMS key.
    /// </summary>
    public partial class ServerSideEncryptionUpdateDetails
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Message explaining the current UpdateStatus. When the UpdateStatus is FAILED, this
        /// message explains the cause of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OldKmsKeyId. 
        /// <para>
        /// The previous KMS key ID the domain was encrypted with, before ServerSideEncryptionConfiguration
        /// was updated to a new KMS key ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string OldKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the OldKmsKeyId property is set.
        /// </summary>
        internal bool IsSetOldKmsKeyId() => this.OldKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// Status of the server-side encryption update. During an update, if there is an issue
        /// with the domain's current or old KMS key ID, such as an inaccessible or disabled key,
        /// then the status is FAILED. In order to resolve this, the key needs to be made accessible,
        /// and then an UpdateDomain call with the existing server-side encryption configuration
        /// will re-attempt this update process.
        /// </para>
        /// </summary>
        public ServerSideEncryptionUpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}
