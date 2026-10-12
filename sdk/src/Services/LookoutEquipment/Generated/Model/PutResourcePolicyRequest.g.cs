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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation. Creates a resource
    /// control policy for a given resource.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. If you do not set the client request token, Amazon
        /// Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// A unique identifier for a revision of the resource policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string PolicyRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRevisionId property is set.
        /// </summary>
        internal bool IsSetPolicyRevisionId() => this.PolicyRevisionId != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource for which the policy is being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// The JSON-formatted resource policy to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20000)]
        public string ResourcePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePolicy property is set.
        /// </summary>
        internal bool IsSetResourcePolicy() => this.ResourcePolicy != null;
    }
}
