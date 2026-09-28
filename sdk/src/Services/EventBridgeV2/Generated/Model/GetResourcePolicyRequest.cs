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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
    /// Container for the parameters to the GetResourcePolicy operation.
    /// Returns the named resource policy attached to an event bus. Fails with ResourceNotFoundException
    /// when the event bus or the named policy does not exist.
    /// </summary>
    public partial class GetResourcePolicyRequest : AmazonEventBridgeV2Request
    {
        private string _policyName;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Which named policy to read. Defaults to &quot;default&quot; when omitted (a read AWS
        /// Resource Access Manager makes on the owner's behalf resolves to &quot;AWS_RAM&quot;
        /// instead). Unlike writing, neither name is reserved on a read: the bus owner can read
        /// both. There is no fallback between the two, so a bus shared only through Resource
        /// Access Manager fails with ResourceNotFoundException until &quot;AWS_RAM&quot; is named
        /// explicitly. A well-formed name that is neither of the two fails with InvalidInputException.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}