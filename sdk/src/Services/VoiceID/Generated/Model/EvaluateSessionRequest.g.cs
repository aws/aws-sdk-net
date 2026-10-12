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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the EvaluateSession operation. Evaluates a specified
    /// session based on audio data accumulated during a streaming Amazon Connect Voice ID
    /// call.
    /// </summary>
    public partial class EvaluateSessionRequest : AmazonVoiceIDRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain where the session started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property SessionNameOrId. 
        /// <para>
        /// The session identifier, or name of the session, that you want to evaluate. In Voice
        /// ID integration, this is the Contact-Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string SessionNameOrId { get; set; }

        /// <summary>
        /// Checks to see if the SessionNameOrId property is set.
        /// </summary>
        internal bool IsSetSessionNameOrId() => this.SessionNameOrId != null;
    }
}
