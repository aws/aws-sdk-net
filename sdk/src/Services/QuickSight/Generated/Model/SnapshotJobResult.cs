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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An object that provides information on the result of a snapshot job. This object provides
    /// information about the job, the job status, and the location of the generated file.
    /// </summary>
    public partial class SnapshotJobResult
    {
        private List<AnonymousUserSnapshotJobResult> _anonymousUsers = AWSConfigs.InitializeCollections ? new List<AnonymousUserSnapshotJobResult>() : null;

        /// <summary>
        /// Gets and sets the property AnonymousUsers. 
        /// <para>
        ///  A list of <c>AnonymousUserSnapshotJobResult</c> objects that contain information
        /// on anonymous users and their user configurations. This data provided by you when you
        /// make a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnonymousUserSnapshotJobResult> AnonymousUsers
        {
            get { return this._anonymousUsers; }
            set { this._anonymousUsers = value; }
        }

        // Check to see if AnonymousUsers property is set
        internal bool IsSetAnonymousUsers()
        {
            return this._anonymousUsers != null && (this._anonymousUsers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}