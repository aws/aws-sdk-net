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
    /// Container for the parameters to the ActivateKeySigningKey operation. Activates a key-signing
    /// key (KSK) so that it can be used for signing by DNSSEC. This operation changes the
    /// KSK status to <c>ACTIVE</c>.
    /// </summary>
    public partial class ActivateKeySigningKeyRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// A unique string used to identify a hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string used to identify a key-signing key (KSK). <c>Name</c> can include numbers,
        /// letters, and underscores (_). <c>Name</c> must be unique for each key-signing key
        /// in the same hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
