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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The cost allocation tag backfill request structure that contains metadata and details
    /// of a certain backfill.
    /// </summary>
    public partial class CostAllocationTagBackfillRequest
    {
        private string _backfillFrom;
        private CostAllocationTagBackfillStatus _backfillStatus;
        private string _completedAt;
        private string _lastUpdatedAt;
        private string _requestedAt;

        /// <summary>
        /// Gets and sets the property BackfillFrom. 
        /// <para>
        ///  The date the backfill starts from. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string BackfillFrom
        {
            get { return this._backfillFrom; }
            set { this._backfillFrom = value; }
        }

        // Check to see if BackfillFrom property is set
        internal bool IsSetBackfillFrom()
        {
            return this._backfillFrom != null;
        }

        /// <summary>
        /// Gets and sets the property BackfillStatus. 
        /// <para>
        ///  The status of the cost allocation tag backfill request. 
        /// </para>
        /// </summary>
        public CostAllocationTagBackfillStatus BackfillStatus
        {
            get { return this._backfillStatus; }
            set { this._backfillStatus = value; }
        }

        // Check to see if BackfillStatus property is set
        internal bool IsSetBackfillStatus()
        {
            return this._backfillStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        ///  The backfill completion time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  The time when the backfill status was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        ///  The time when the backfill was requested. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string RequestedAt
        {
            get { return this._requestedAt; }
            set { this._requestedAt = value; }
        }

        // Check to see if RequestedAt property is set
        internal bool IsSetRequestedAt()
        {
            return this._requestedAt != null;
        }

    }
}