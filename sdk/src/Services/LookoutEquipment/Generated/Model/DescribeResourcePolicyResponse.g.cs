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
    /// This is the response object from the DescribeResourcePolicy operation.
    /// </summary>
    public partial class DescribeResourcePolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the resource policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the resource policy was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// The resource policy in a JSON-formatted string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20000)]
        public string ResourcePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePolicy property is set.
        /// </summary>
        internal bool IsSetResourcePolicy() => this.ResourcePolicy != null;
    }
}
