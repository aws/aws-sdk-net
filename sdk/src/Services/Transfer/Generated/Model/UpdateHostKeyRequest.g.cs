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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHostKey operation. Updates the description
    /// for the host key that's specified by the <c>ServerId</c> and <c>HostKeyId</c> parameters.
    /// </summary>
    public partial class UpdateHostKeyRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description for the host key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HostKeyId. 
        /// <para>
        /// The identifier of the host key that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 25, Max = 25)]
        public string HostKeyId { get; set; }

        /// <summary>
        /// Checks to see if the HostKeyId property is set.
        /// </summary>
        internal bool IsSetHostKeyId() => this.HostKeyId != null;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// The identifier of the server that contains the host key that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string ServerId { get; set; }

        /// <summary>
        /// Checks to see if the ServerId property is set.
        /// </summary>
        internal bool IsSetServerId() => this.ServerId != null;
    }
}
