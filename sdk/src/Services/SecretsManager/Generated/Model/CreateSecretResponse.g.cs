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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the CreateSecret operation.
    /// </summary>
    public partial class CreateSecretResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the new secret. The ARN includes the name of the secret followed by six
        /// random characters. This ensures that if you create a new secret with the same name
        /// as a deleted secret, then users with access to the old secret don't get access to
        /// the new secret because the ARNs are different.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// A list of the replicas of this secret and their status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Failed</c>, which indicates that the replica was not created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c>, which indicates that Secrets Manager is in the process of creating
        /// the replica.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InSync</c>, which indicates that the replica was created.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationStatusType> ReplicationStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationStatusType>() : null;

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null && (this.ReplicationStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The unique identifier associated with the version of the new secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 64)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
