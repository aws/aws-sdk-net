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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFleetAdvisorDatabases operation.
    /// Deletes the specified Fleet Advisor collector databases.
    /// </summary>
    public partial class DeleteFleetAdvisorDatabasesRequest : AmazonDatabaseMigrationServiceRequest
    {
        private List<string> _databaseIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DatabaseIds. 
        /// <para>
        /// The IDs of the Fleet Advisor collector databases to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DatabaseIds
        {
            get { return this._databaseIds; }
            set { this._databaseIds = value; }
        }

        // Check to see if DatabaseIds property is set
        internal bool IsSetDatabaseIds()
        {
            return this._databaseIds != null && (this._databaseIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}