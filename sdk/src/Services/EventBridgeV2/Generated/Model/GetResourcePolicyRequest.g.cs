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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourcePolicy operation. Returns the named
    /// resource policy attached to an event bus. Fails with ResourceNotFoundException when
    /// the event bus or the named policy does not exist.
    /// </summary>
    public partial class GetResourcePolicyRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property PolicyName. Which named policy to read. Defaults to "default"
        /// when omitted (a read AWS Resource Access Manager makes on the owner's behalf resolves
        /// to "AWS_RAM" instead). Unlike writing, neither name is reserved on a read: the bus
        /// owner can read both. There is no fallback between the two, so a bus shared only through
        /// Resource Access Manager fails with ResourceNotFoundException until "AWS_RAM" is named
        /// explicitly. A well-formed name that is neither of the two fails with InvalidInputException.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property ResourceArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
