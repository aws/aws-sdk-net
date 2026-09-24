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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Defines the Amazon Web Services Region and KMS key to add to the replication set.
    /// </summary>
    public partial class AddRegionAction
    {
        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region name to add to the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property SseKmsKeyId. 
        /// <para>
        /// The KMS key ID to use to encrypt your replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetSseKmsKeyId() => this.SseKmsKeyId != null;
    }
}
