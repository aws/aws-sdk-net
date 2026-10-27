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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// A resource in the organization that's available to be associated with a Firewall Manager
    /// resource set.
    /// </summary>
    public partial class DiscoveredResource
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the discovered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the discovered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the discovered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property URI. 
        /// <para>
        /// The universal resource identifier (URI) of the discovered resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string URI { get; set; }

        /// <summary>
        /// Checks to see if the URI property is set.
        /// </summary>
        internal bool IsSetURI() => this.URI != null;
    }
}
