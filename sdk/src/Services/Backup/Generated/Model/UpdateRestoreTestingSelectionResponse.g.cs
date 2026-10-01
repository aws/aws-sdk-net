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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the UpdateRestoreTestingSelection operation.
    /// </summary>
    public partial class UpdateRestoreTestingSelectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the resource testing selection was updated successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanArn. 
        /// <para>
        /// Unique string that is the name of the restore testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanArn property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanArn() => this.RestoreTestingPlanArn != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The restore testing plan with which the updated restore testing selection is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanName() => this.RestoreTestingPlanName != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingSelectionName. 
        /// <para>
        /// The returned restore testing selection name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingSelectionName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingSelectionName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingSelectionName() => this.RestoreTestingSelectionName != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the update completed for the restore testing selection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
