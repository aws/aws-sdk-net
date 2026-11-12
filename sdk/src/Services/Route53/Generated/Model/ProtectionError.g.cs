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
    /// Describes one entry in a <c>CreateResourceRecordSetProtections</c> or <c>DeleteResourceRecordSetProtections</c>
    /// request that Route 53 couldn't process.
    /// </summary>
    public partial class ProtectionError
    {
        /// <summary>
        /// Gets and sets the property RecordName. 
        /// <para>
        /// The name in the failing entry.
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
        /// The record type in the failing entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RRType RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The reason that the entry failed. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InvalidInput</c> means that the entry isn't valid. For example, the name isn't
        /// a valid DNS name, the name isn't in the hosted zone, the record type can't be protected,
        /// or the same name and type appear more than once in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProtectionAlreadyExists</c> means that a protection already exists for the name
        /// and type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProtectionNotFound</c> means that no protection exists for the name and type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that explains why Route 53 couldn't process the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
