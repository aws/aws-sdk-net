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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteScheduleAction operation. Deletes a schedule
    /// action from a feed. A deleted action never runs. <para> You can delete only an action
    /// whose status is PENDING. Deleting an action doesn't reverse changes that the action
    /// already made to the feed. When you delete or archive a feed, Elemental Inference deletes
    /// all the schedule actions on that feed. </para>
    /// </summary>
    public partial class DeleteScheduleActionRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the schedule action that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the feed that holds the schedule action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
