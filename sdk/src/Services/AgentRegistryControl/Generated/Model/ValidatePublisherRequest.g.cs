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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the ValidatePublisher operation. Restart domain verification
    /// for a publisher in FAILED or SUSPENDED. The publisher returns to ACTION_REQUIRED with
    /// a new domainChallenge, which the response includes. Update the DNS TXT record with
    /// the new recordValue; the previous value no longer verifies the domain. The request
    /// fails with ConflictException when the publisher is ACTIVE, verification is already
    /// in progress (ACTION_REQUIRED), or the publisher is being deleted.
    /// </summary>
    public partial class ValidatePublisherRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property PublisherArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PublisherArn { get; set; }

        /// <summary>
        /// Checks to see if the PublisherArn property is set.
        /// </summary>
        internal bool IsSetPublisherArn() => this.PublisherArn != null;
    }
}
