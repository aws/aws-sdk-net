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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the TestPayloadStructure operation. This example operation
    /// serializes a payload targeting a structure. This enforces the same requirements as
    /// TestBodyStructure but with the body specified by the @httpPayload trait.
    /// </summary>
    public partial class TestPayloadStructureRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property PayloadConfig.
        /// </summary>
        public PayloadConfig PayloadConfig { get; set; }

        /// <summary>
        /// Checks to see if the PayloadConfig property is set.
        /// </summary>
        internal bool IsSetPayloadConfig() => this.PayloadConfig != null;

        /// <summary>
        /// Gets and sets the property TestId.
        /// </summary>
        public string TestId { get; set; }

        /// <summary>
        /// Checks to see if the TestId property is set.
        /// </summary>
        internal bool IsSetTestId() => this.TestId != null;
    }
}
