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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Summarizes the resource sets used in a policy.
    /// </summary>
    public partial class ResourceSetSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the resource set. This ID is returned in the responses to
        /// create and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The last time that the resource set was changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the resource set. You can't change the name of a resource
        /// set after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceSetStatus. 
        /// <para>
        /// Indicates whether the resource set is in or out of an admin's Region scope.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The administrator can manage and delete the resource set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUT_OF_ADMIN_SCOPE</c> - The administrator can view the resource set, but they
        /// can't edit or delete the resource set. Existing protections stay in place. Any new
        /// resource that come into scope of the resource set won't be protected.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceSetStatus ResourceSetStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSetStatus property is set.
        /// </summary>
        internal bool IsSetResourceSetStatus() => this.ResourceSetStatus != null;
    }
}
