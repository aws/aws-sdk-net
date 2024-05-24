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
    /// Container for the parameters to the CreateRestoreTestingSelection operation.
    /// This request can be sent after CreateRestoreTestingPlan request returns successfully.
    /// This is the second part of creating a resource testing plan, and it must be completed
    /// sequentially.
    /// 
    ///  
    /// <para>
    /// This consists of <c>RestoreTestingSelectionName</c>, <c>ProtectedResourceType</c>,
    /// and one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ProtectedResourceArns</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ProtectedResourceConditions</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each protected resource type can have one single value.
    /// </para>
    ///  
    /// <para>
    /// A restore testing selection can include a wildcard value ("*") for <c>ProtectedResourceArns</c>
    /// along with <c>ProtectedResourceConditions</c>. Alternatively, you can include up to
    /// 30 specific protected resource ARNs in <c>ProtectedResourceArns</c>.
    /// </para>
    ///  
    /// <para>
    /// Cannot select by both protected resource types AND specific ARNs. Request will fail
    /// if both are included.
    /// </para>
    /// </summary>
    public partial class CreateRestoreTestingSelectionRequest : AmazonBackupRequest
    {
        private string _creatorRequestId;
        private string _restoreTestingPlanName;
        private RestoreTestingSelectionForCreate _restoreTestingSelection;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is an optional unique string that identifies the request and allows failed requests
        /// to be retried without the risk of running the operation twice. If used, this parameter
        /// must contain 1 to 50 alphanumeric or '-_.' characters.
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
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// Input the restore testing plan name that was returned from the related CreateRestoreTestingPlan
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingPlanName
        {
            get { return this._restoreTestingPlanName; }
            set { this._restoreTestingPlanName = value; }
        }

        // Check to see if RestoreTestingPlanName property is set
        internal bool IsSetRestoreTestingPlanName()
        {
            return this._restoreTestingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreTestingSelection. 
        /// <para>
        /// This consists of <c>RestoreTestingSelectionName</c>, <c>ProtectedResourceType</c>,
        /// and one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProtectedResourceArns</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProtectedResourceConditions</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each protected resource type can have one single value.
        /// </para>
        ///  
        /// <para>
        /// A restore testing selection can include a wildcard value ("*") for <c>ProtectedResourceArns</c>
        /// along with <c>ProtectedResourceConditions</c>. Alternatively, you can include up to
        /// 30 specific protected resource ARNs in <c>ProtectedResourceArns</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RestoreTestingSelectionForCreate RestoreTestingSelection
        {
            get { return this._restoreTestingSelection; }
            set { this._restoreTestingSelection = value; }
        }

        // Check to see if RestoreTestingSelection property is set
        internal bool IsSetRestoreTestingSelection()
        {
            return this._restoreTestingSelection != null;
        }

    }
}