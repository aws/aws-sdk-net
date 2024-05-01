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
    /// How the auto-merging process should resolve conflicts between different profiles.
    /// </summary>
    public partial class ConflictResolution
    {
        private ConflictResolvingModel _conflictResolvingModel;
        private string _sourceName;

        /// <summary>
        /// Gets and sets the property ConflictResolvingModel. 
        /// <para>
        /// How the auto-merging process should resolve conflicts between different profiles.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RECENCY</c>: Uses the data that was most recently updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SOURCE</c>: Uses the data from a specific source. For example, if a company has
        /// been aquired or two departments have merged, data from the specified source is used.
        /// If two duplicate profiles are from the same source, then <c>RECENCY</c> is used again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConflictResolvingModel ConflictResolvingModel
        {
            get { return this._conflictResolvingModel; }
            set { this._conflictResolvingModel = value; }
        }

        // Check to see if ConflictResolvingModel property is set
        internal bool IsSetConflictResolvingModel()
        {
            return this._conflictResolvingModel != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The <c>ObjectType</c> name that is used to resolve profile merging conflicts when
        /// choosing <c>SOURCE</c> as the <c>ConflictResolvingModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

    }
}