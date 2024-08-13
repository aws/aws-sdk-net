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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Statistics about the Identity Resolution Job.
    /// </summary>
    public partial class JobStats
    {
        private long? _numberOfMatchesFound;
        private long? _numberOfMergesDone;
        private long? _numberOfProfilesReviewed;

        /// <summary>
        /// Gets and sets the property NumberOfMatchesFound. 
        /// <para>
        /// The number of matches found.
        /// </para>
        /// </summary>
        public long? NumberOfMatchesFound
        {
            get { return this._numberOfMatchesFound; }
            set { this._numberOfMatchesFound = value; }
        }

        // Check to see if NumberOfMatchesFound property is set
        internal bool IsSetNumberOfMatchesFound()
        {
            return this._numberOfMatchesFound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfMergesDone. 
        /// <para>
        /// The number of merges completed.
        /// </para>
        /// </summary>
        public long? NumberOfMergesDone
        {
            get { return this._numberOfMergesDone; }
            set { this._numberOfMergesDone = value; }
        }

        // Check to see if NumberOfMergesDone property is set
        internal bool IsSetNumberOfMergesDone()
        {
            return this._numberOfMergesDone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfProfilesReviewed. 
        /// <para>
        /// The number of profiles reviewed.
        /// </para>
        /// </summary>
        public long? NumberOfProfilesReviewed
        {
            get { return this._numberOfProfilesReviewed; }
            set { this._numberOfProfilesReviewed = value; }
        }

        // Check to see if NumberOfProfilesReviewed property is set
        internal bool IsSetNumberOfProfilesReviewed()
        {
            return this._numberOfProfilesReviewed.HasValue; 
        }

    }
}