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

namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnection operation. Modifies an existing
    /// connection. Currently we support modifications to the connection's description and/or
    /// bandwidth.
    /// </summary>
    public partial class UpdateConnectionRequest : AmazonInterconnectRequest
    {
        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// Request a new bandwidth size on the given <a>Connection</a>.
        /// </para>
        ///  
        /// <para>
        /// Note that changes to the size may be subject to additional policy, and does require
        /// the remote partner provider to acknowledge and permit this new bandwidth size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidth property is set.
        /// </summary>
        internal bool IsSetBandwidth() => this.Bandwidth != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token used for the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description to apply to the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the <a>Connection</a> that should be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
