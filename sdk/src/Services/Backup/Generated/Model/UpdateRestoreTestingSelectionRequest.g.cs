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
    /// Container for the parameters to the UpdateRestoreTestingSelection operation. Updates
    /// the specified restore testing selection. <para> Most elements except the <c>RestoreTestingSelectionName</c>
    /// can be updated with this request. </para> <para> You can use either protected resource
    /// ARNs or conditions, but not both. </para>
    /// </summary>
    public partial class UpdateRestoreTestingSelectionRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The restore testing plan name is required to update the indicated testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanName() => this.RestoreTestingPlanName != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingSelection. 
        /// <para>
        /// To update your restore testing selection, you can use either protected resource ARNs
        /// or conditions, but not both. That is, if your selection has <c>ProtectedResourceArns</c>,
        /// requesting an update with the parameter <c>ProtectedResourceConditions</c> will be
        /// unsuccessful.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RestoreTestingSelectionForUpdate RestoreTestingSelection { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingSelection property is set.
        /// </summary>
        internal bool IsSetRestoreTestingSelection() => this.RestoreTestingSelection != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingSelectionName. 
        /// <para>
        /// The required restore testing selection name of the restore testing selection you wish
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingSelectionName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingSelectionName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingSelectionName() => this.RestoreTestingSelectionName != null;
    }
}
