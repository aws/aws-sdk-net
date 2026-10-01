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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for an Amazon EBS volume snapshot. You can
    /// propose a configuration for a new Amazon EBS volume snapshot or an Amazon EBS volume
    /// snapshot that you own by specifying the user IDs, groups, and optional KMS encryption
    /// key. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifySnapshotAttribute.html">ModifySnapshotAttribute</a>.
    /// </summary>
    public partial class EbsSnapshotConfiguration
    {
        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The groups that have access to the Amazon EBS volume snapshot. If the value <c>all</c>
        /// is specified, then the Amazon EBS volume snapshot is public.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the configuration is for an existing Amazon EBS volume snapshot and you do not
        /// specify the <c>groups</c>, then the access preview uses the existing shared <c>groups</c>
        /// for the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the access preview is for a new resource and you do not specify the <c>groups</c>,
        /// then the access preview considers the snapshot without any <c>groups</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To propose deletion of existing shared <c>groups</c>, you can specify an empty list
        /// for <c>groups</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier for an encrypted Amazon EBS volume snapshot. The KMS key identifier
        /// is the key ARN, key ID, alias ARN, or alias name for the KMS key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the configuration is for an existing Amazon EBS volume snapshot and you do not
        /// specify the <c>kmsKeyId</c>, or you specify an empty string, then the access preview
        /// uses the existing <c>kmsKeyId</c> of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the access preview is for a new resource and you do not specify the <c>kmsKeyId</c>,
        /// the access preview considers the snapshot as unencrypted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The IDs of the Amazon Web Services accounts that have access to the Amazon EBS volume
        /// snapshot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the configuration is for an existing Amazon EBS volume snapshot and you do not
        /// specify the <c>userIds</c>, then the access preview uses the existing shared <c>userIds</c>
        /// for the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the access preview is for a new resource and you do not specify the <c>userIds</c>,
        /// then the access preview considers the snapshot without any <c>userIds</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To propose deletion of existing shared <c>accountIds</c>, you can specify an empty
        /// list for <c>userIds</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserIds property is set.
        /// </summary>
        internal bool IsSetUserIds() => this.UserIds != null && (this.UserIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
