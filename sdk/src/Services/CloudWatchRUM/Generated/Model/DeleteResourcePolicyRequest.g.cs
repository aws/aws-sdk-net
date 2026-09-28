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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourcePolicy operation. Removes the association
    /// of a resource-based policy from an app monitor.
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonCloudWatchRUMRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The app monitor that you want to remove the resource policy from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// Specifies a specific policy revision to delete. Provide a <c>PolicyRevisionId</c>
        /// to ensure an atomic delete operation. If the revision ID that you provide doesn't
        /// match the latest policy revision ID, the request will be rejected with an <c>InvalidPolicyRevisionIdException</c>
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PolicyRevisionId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRevisionId property is set.
        /// </summary>
        internal bool IsSetPolicyRevisionId() => this.PolicyRevisionId != null;
    }
}
