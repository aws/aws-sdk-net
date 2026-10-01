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
    /// Container for the parameters to the UpdateRestoreTestingPlan operation. This request
    /// will send changes to your specified restore testing plan. <c>RestoreTestingPlanName</c>
    /// cannot be updated after it is created. <para> <c>RecoveryPointSelection</c> can contain:
    /// </para> <ul> <li> <para> <c>Algorithm</c> </para> </li> <li> <para> <c>ExcludeVaults</c>
    /// </para> </li> <li> <para> <c>IncludeVaults</c> </para> </li> <li> <para> <c>RecoveryPointTypes</c>
    /// </para> </li> <li> <para> <c>SelectionWindowDays</c> </para> </li> </ul>
    /// </summary>
    public partial class UpdateRestoreTestingPlanRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property RestoreTestingPlan. 
        /// <para>
        /// Specifies the body of a restore testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RestoreTestingPlanForUpdate RestoreTestingPlan { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlan property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlan() => this.RestoreTestingPlan != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The name of the restore testing plan name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanName() => this.RestoreTestingPlanName != null;
    }
}
