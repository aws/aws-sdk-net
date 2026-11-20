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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Server-generated DNS-01 challenge the caller must publish to prove ownership.
    /// </summary>
    public partial class DomainChallenge
    {
        /// <summary>
        /// Gets and sets the property RecordName. The name of the DNS TXT record to create, such
        /// as `_acme-challenge.example.com`.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string RecordName { get; set; }

        /// <summary>
        /// Checks to see if the RecordName property is set.
        /// </summary>
        internal bool IsSetRecordName() => this.RecordName != null;

        /// <summary>
        /// Gets and sets the property RecordValue. The value to publish in the DNS TXT record.
        /// A new value is issued each time verification restarts, and earlier values no longer
        /// verify the domain.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string RecordValue { get; set; }

        /// <summary>
        /// Checks to see if the RecordValue property is set.
        /// </summary>
        internal bool IsSetRecordValue() => this.RecordValue != null;
    }
}
