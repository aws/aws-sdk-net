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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCustomActionType operation. Marks a custom
    /// action as deleted. <c>PollForJobs</c> for the custom action fails after the action
    /// is marked for deletion. Used for custom actions only. <important> <para> To re-create
    /// a custom action after it has been deleted you must use a string in the version field
    /// that has never been used before. This string can be an incremented version number,
    /// for example. To restore a deleted custom action, use a JSON file that is identical
    /// to the deleted action, including the original string in the version field. </para>
    /// </important>
    /// </summary>
    public partial class DeleteCustomActionTypeRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the custom action that you want to delete, such as source or deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the service used in the custom action, such as CodeDeploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 35)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the custom action to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 9)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
