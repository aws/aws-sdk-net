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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the StartAutonomousDatabaseRefresh operation. Starts
    /// a refresh of the specified refreshable clone Autonomous Database with data from its
    /// source database. The refresh runs asynchronously. To track its progress, check the
    /// <c>refreshableStatus</c> of the Autonomous Database.
    /// </summary>
    public partial class StartAutonomousDatabaseRefreshRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the refreshable clone Autonomous Database to refresh.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string AutonomousDatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseId property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseId() => this.AutonomousDatabaseId != null;

        /// <summary>
        /// Gets and sets the property TimeOfRefreshCutoff. 
        /// <para>
        /// The date and time up to which the refreshable clone Autonomous Database is refreshed
        /// from its source database. Data committed on the source database after this time isn't
        /// applied to the refreshable clone. The time must be at least 1 minute and at most 7
        /// days in the past, and later than the clone's last refresh point.
        /// </para>
        /// </summary>
        public DateTime? TimeOfRefreshCutoff { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfRefreshCutoff property is set.
        /// </summary>
        internal bool IsSetTimeOfRefreshCutoff() => this.TimeOfRefreshCutoff.HasValue;
    }
}
