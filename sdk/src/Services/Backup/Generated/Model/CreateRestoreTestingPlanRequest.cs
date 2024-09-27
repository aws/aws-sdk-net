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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
    /// Container for the parameters to the CreateRestoreTestingPlan operation.
    /// Creates a restore testing plan.
    /// 
    ///  
    /// <para>
    /// The first of two steps to create a restore testing plan. After this request is successful,
    /// finish the procedure using CreateRestoreTestingSelection.
    /// </para>
    /// </summary>
    public partial class CreateRestoreTestingPlanRequest : AmazonBackupRequest
    {
        private string _creatorRequestId;
        private RestoreTestingPlanForCreate _restoreTestingPlan;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is a unique string that identifies the request and allows failed requests to
        /// be retriedwithout the risk of running the operation twice. This parameter is optional.
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

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
        [AWSProperty(Required=true)]
        public RestoreTestingPlanForCreate RestoreTestingPlan
        {
            get { return this._restoreTestingPlan; }
            set { this._restoreTestingPlan = value; }
        }

        // Check to see if RestoreTestingPlan property is set
        internal bool IsSetRestoreTestingPlan()
        {
            return this._restoreTestingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the restore testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}