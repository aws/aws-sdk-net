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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifySnapshotSchedule operation.
    /// Modifies a snapshot schedule. Any schedule associated with a cluster is modified asynchronously.
    /// </summary>
    public partial class ModifySnapshotScheduleRequest : AmazonRedshiftRequest
    {
        private List<string> _scheduleDefinitions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scheduleIdentifier;

        /// <summary>
        /// Gets and sets the property ScheduleDefinitions. 
        /// <para>
        /// An updated list of schedule definitions. A schedule definition is made up of schedule
        /// expressions, for example, "cron(30 12 *)" or "rate(12 hours)".
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ScheduleDefinitions
        {
            get { return this._scheduleDefinitions; }
            set { this._scheduleDefinitions = value; }
        }

        // Check to see if ScheduleDefinitions property is set
        internal bool IsSetScheduleDefinitions()
        {
            return this._scheduleDefinitions != null && (this._scheduleDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// A unique alphanumeric identifier of the schedule to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ScheduleIdentifier
        {
            get { return this._scheduleIdentifier; }
            set { this._scheduleIdentifier = value; }
        }

        // Check to see if ScheduleIdentifier property is set
        internal bool IsSetScheduleIdentifier()
        {
            return this._scheduleIdentifier != null;
        }

    }
}