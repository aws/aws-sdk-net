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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// A migration-task progress update.
    /// </summary>
    public partial class MigrationTaskUpdate
    {
        private Task _migrationTaskState;
        private DateTime? _updateDateTime;
        private UpdateType _updateType;

        /// <summary>
        /// Gets and sets the property MigrationTaskState.
        /// </summary>
        public Task MigrationTaskState
        {
            get { return this._migrationTaskState; }
            set { this._migrationTaskState = value; }
        }

        // Check to see if MigrationTaskState property is set
        internal bool IsSetMigrationTaskState()
        {
            return this._migrationTaskState != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The timestamp for the update.
        /// </para>
        /// </summary>
        public DateTime? UpdateDateTime
        {
            get { return this._updateDateTime; }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        /// The type of the update.
        /// </para>
        /// </summary>
        public UpdateType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}