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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The description of the server-side encryption status on the specified table.
    /// </summary>
    public partial class SSEDescription
    {
        /// <summary>
        /// Gets and sets the property InaccessibleEncryptionDateTime. 
        /// <para>
        /// Indicates the time, in UNIX epoch date format, when DynamoDB detected that the table's
        /// KMS key was inaccessible. This attribute will automatically be cleared when DynamoDB
        /// detects that the table's KMS key is accessible again. DynamoDB will initiate the table
        /// archival process when table's KMS key remains inaccessible for more than seven days
        /// from this date.
        /// </para>
        /// </summary>
        public DateTime? InaccessibleEncryptionDateTime { get; set; }

        /// <summary>
        /// Checks to see if the InaccessibleEncryptionDateTime property is set.
        /// </summary>
        internal bool IsSetInaccessibleEncryptionDateTime() => this.InaccessibleEncryptionDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property KMSMasterKeyArn. 
        /// <para>
        /// The KMS key ARN used for the KMS encryption.
        /// </para>
        /// </summary>
        public string KMSMasterKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KMSMasterKeyArn property is set.
        /// </summary>
        internal bool IsSetKMSMasterKeyArn() => this.KMSMasterKeyArn != null;

        /// <summary>
        /// Gets and sets the property SSEType. 
        /// <para>
        /// Server-side encryption type. The only supported value is:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KMS</c> - Server-side encryption that uses Key Management Service. The key is
        /// stored in your account and is managed by KMS (KMS charges apply).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SSEType SSEType { get; set; }

        /// <summary>
        /// Checks to see if the SSEType property is set.
        /// </summary>
        internal bool IsSetSSEType() => this.SSEType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents the current state of server-side encryption. The only supported values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> - Server-side encryption is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - Server-side encryption is being updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SSEStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
