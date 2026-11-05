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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUsagePlanKey operation. Creates a usage
    /// plan key for adding an existing API key to a usage plan.
    /// </summary>
    public partial class CreateUsagePlanKeyRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of a UsagePlanKey resource for a plan customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The type of a UsagePlanKey resource for a plan customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyType { get; set; }

        /// <summary>
        /// Checks to see if the KeyType property is set.
        /// </summary>
        internal bool IsSetKeyType() => this.KeyType != null;

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// The Id of the UsagePlan resource representing the usage plan containing the to-be-created
        /// UsagePlanKey resource representing a plan customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UsagePlanId { get; set; }

        /// <summary>
        /// Checks to see if the UsagePlanId property is set.
        /// </summary>
        internal bool IsSetUsagePlanId() => this.UsagePlanId != null;
    }
}
