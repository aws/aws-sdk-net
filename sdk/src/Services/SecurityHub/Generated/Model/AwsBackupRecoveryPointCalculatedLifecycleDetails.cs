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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies how long in days before a recovery point transitions to cold storage or
    /// is deleted.
    /// </summary>
    public partial class AwsBackupRecoveryPointCalculatedLifecycleDetails
    {
        private string _deleteAt;
        private string _moveToColdStorageAt;

        /// <summary>
        /// Gets and sets the property DeleteAt. 
        /// <para>
        /// Specifies the number of days after creation that a recovery point is deleted. Must
        /// be greater than 90 days plus <c>MoveToColdStorageAfterDays</c>. 
        /// </para>
        /// </summary>
        public string DeleteAt
        {
            get { return this._deleteAt; }
            set { this._deleteAt = value; }
        }

        // Check to see if DeleteAt property is set
        internal bool IsSetDeleteAt()
        {
            return this._deleteAt != null;
        }

        /// <summary>
        /// Gets and sets the property MoveToColdStorageAt. 
        /// <para>
        /// Specifies the number of days after creation that a recovery point is moved to cold
        /// storage. 
        /// </para>
        /// </summary>
        public string MoveToColdStorageAt
        {
            get { return this._moveToColdStorageAt; }
            set { this._moveToColdStorageAt = value; }
        }

        // Check to see if MoveToColdStorageAt property is set
        internal bool IsSetMoveToColdStorageAt()
        {
            return this._moveToColdStorageAt != null;
        }

    }
}