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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A protection for the resource record sets in a hosted zone that have the specified
    /// name and type. While the protection exists, Route 53 rejects <c>ChangeResourceRecordSets</c>
    /// requests that create, update, or delete those resource record sets.
    /// </summary>
    public partial class ResourceRecordSetProtection
    {
        /// <summary>
        /// Gets and sets the property RecordName. 
        /// <para>
        /// The name of the protected resource record sets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string RecordName { get; set; }

        /// <summary>
        /// Checks to see if the RecordName property is set.
        /// </summary>
        internal bool IsSetRecordName() => this.RecordName != null;

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The DNS record type of the protected resource record sets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RRType RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment that was specified when the protection was created, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;
    }
}
