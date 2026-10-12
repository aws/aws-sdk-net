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
    /// This is the response object from the PutResourcePolicy operation.
    /// </summary>
    public partial class PutResourcePolicyResponse : AmazonWebServiceResponse
    {
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
        /// The Amazon Resource Name (ARN) of the resource for which the policy was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
