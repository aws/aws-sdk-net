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
    /// Container for the parameters to the CreateRestoreTestingPlan operation. Creates a
    /// restore testing plan. <para> The first of two steps to create a restore testing plan.
    /// After this request is successful, finish the procedure using CreateRestoreTestingSelection.
    /// </para>
    /// </summary>
    public partial class CreateRestoreTestingPlanRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is a unique string that identifies the request and allows failed requests to
        /// be retriedwithout the risk of running the operation twice. This parameter is optional.
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlan. 
        /// <para>
        /// A restore testing plan must contain a unique <c>RestoreTestingPlanName</c> string
        /// you create and must contain a <c>ScheduleExpression</c> cron. You may optionally include
        /// a <c>StartWindowHours</c> integer and a <c>CreatorRequestId</c> string.
        /// </para>
        ///  
        /// <para>
        /// The <c>RestoreTestingPlanName</c> is a unique string that is the name of the restore
        /// testing plan. This cannot be changed after creation, and it must consist of only alphanumeric
        /// characters and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RestoreTestingPlanForCreate RestoreTestingPlan { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlan property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlan() => this.RestoreTestingPlan != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the restore testing plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
