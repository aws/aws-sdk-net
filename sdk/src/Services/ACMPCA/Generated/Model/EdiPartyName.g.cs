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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Describes an Electronic Data Interchange (EDI) entity as described in as defined in
    /// <a href="https://datatracker.ietf.org/doc/html/rfc5280">Subject Alternative Name</a>
    /// in RFC 5280.
    /// </summary>
    public partial class EdiPartyName
    {
        /// <summary>
        /// Gets and sets the property NameAssigner. 
        /// <para>
        /// Specifies the name assigner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NameAssigner { get; set; }

        /// <summary>
        /// Checks to see if the NameAssigner property is set.
        /// </summary>
        internal bool IsSetNameAssigner() => this.NameAssigner != null;

        /// <summary>
        /// Gets and sets the property PartyName. 
        /// <para>
        /// Specifies the party name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string PartyName { get; set; }

        /// <summary>
        /// Checks to see if the PartyName property is set.
        /// </summary>
        internal bool IsSetPartyName() => this.PartyName != null;
    }
}
