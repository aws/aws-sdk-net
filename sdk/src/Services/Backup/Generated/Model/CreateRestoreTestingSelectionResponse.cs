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
    /// This is the response object from the CreateRestoreTestingSelection operation.
    /// </summary>
    public partial class CreateRestoreTestingSelectionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _restoreTestingPlanArn;
        private string _restoreTestingPlanName;
        private string _restoreTestingSelectionName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the resource testing selection was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanArn. 
        /// <para>
        /// The ARN of the restore testing plan with which the restore testing selection is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingPlanArn
        {
            get { return this._restoreTestingPlanArn; }
            set { this._restoreTestingPlanArn = value; }
        }

        // Check to see if RestoreTestingPlanArn property is set
        internal bool IsSetRestoreTestingPlanArn()
        {
            return this._restoreTestingPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The name of the restore testing plan.
        /// </para>
        ///  
        /// <para>
        /// The name cannot be changed after creation. The name consists of only alphanumeric
        /// characters and underscores. Maximum length is 50.
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
        /// Gets and sets the property RestoreTestingSelectionName. 
        /// <para>
        /// The name of the restore testing selection for the related restore testing plan.
        /// </para>
        ///  
        /// <para>
        /// The name cannot be changed after creation. The name consists of only alphanumeric
        /// characters and underscores. Maximum length is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingSelectionName
        {
            get { return this._restoreTestingSelectionName; }
            set { this._restoreTestingSelectionName = value; }
        }

        // Check to see if RestoreTestingSelectionName property is set
        internal bool IsSetRestoreTestingSelectionName()
        {
            return this._restoreTestingSelectionName != null;
        }

    }
}