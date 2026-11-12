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
    /// A protection to create for the resource record sets in a hosted zone that have the
    /// specified name and type.
    /// </summary>
    public partial class ResourceRecordSetProtectionConfig
    {
        /// <summary>
        /// Gets and sets the property RecordName. 
        /// <para>
        /// The name of the resource record sets to protect, for example, <c>www.example.com</c>.
        /// The name must be the name of the hosted zone or a subdomain of it.
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
        /// The DNS record type of the resource record sets to protect. You can't protect records
        /// of type <c>DNAME</c> or of the DNSSEC record types that Route 53 manages.
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
        /// An optional comment about the protection, for example, the reason that the resource
        /// record sets are protected. The comment can be up to 256 characters long. If you don't
        /// specify a comment, the protection doesn't have a comment. When Route 53 rejects a
        /// <c>ChangeResourceRecordSets</c> request because of this protection, the error message
        /// includes the comment, so don't include sensitive information.
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
