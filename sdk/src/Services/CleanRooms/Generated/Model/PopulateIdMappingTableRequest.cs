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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the PopulateIdMappingTable operation.
    /// Defines the information that's necessary to populate an ID mapping table.
    /// </summary>
    public partial class PopulateIdMappingTableRequest : AmazonCleanRoomsRequest
    {
        private string _idMappingTableIdentifier;
        private JobType _jobType;
        private string _membershipIdentifier;

        /// <summary>
        /// Gets and sets the property IdMappingTableIdentifier. 
        /// <para>
        /// The unique identifier of the ID mapping table that you want to populate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IdMappingTableIdentifier
        {
            get { return this._idMappingTableIdentifier; }
            set { this._idMappingTableIdentifier = value; }
        }

        // Check to see if IdMappingTableIdentifier property is set
        internal bool IsSetIdMappingTableIdentifier()
        {
            return this._idMappingTableIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The job type of the rule-based ID mapping job. Valid values include:
        /// </para>
        ///  
        /// <para>
        ///  <c>INCREMENTAL</c>: Processes only new or changed data since the last job run. This
        /// is the default job type if the ID mapping workflow was created in Entity Resolution
        /// with <c>incrementalRunConfig</c> specified.
        /// </para>
        ///  
        /// <para>
        ///  <c>BATCH</c>: Processes all data from the input source, regardless of previous job
        /// runs. This is the default job type if the ID mapping workflow was created in Entity
        /// Resolution but <c>incrementalRunConfig</c> wasn't specified.
        /// </para>
        ///  
        /// <para>
        ///  <c>DELETE_ONLY</c>: Processes only deletion requests from <c>BatchDeleteUniqueId</c>,
        /// which is set in Entity Resolution.
        /// </para>
        ///  
        /// <para>
        /// For more information about <c>incrementalRunConfig</c> and <c>BatchDeleteUniqueId</c>,
        /// see the <a href="https://docs.aws.amazon.com/entityresolution/latest/apireference/Welcome.html">Entity
        /// Resolution API Reference</a>.
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the ID mapping table that you
        /// want to populate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

    }
}