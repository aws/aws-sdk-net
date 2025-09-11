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
    /// A structure that contains information on the anonymous user configuration.
    /// </summary>
    public partial class SnapshotAnonymousUser
    {
        private List<SessionTag> _rowLevelPermissionTags = AWSConfigs.InitializeCollections ? new List<SessionTag>() : null;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionTags. 
        /// <para>
        /// The tags to be used for row-level security (RLS). Make sure that the relevant datasets
        /// have RLS tags configured before you start a snapshot export job. You can configure
        /// the RLS tags of a dataset with a <c>DataSet$RowLevelPermissionTagConfiguration</c>
        /// API call.
        /// </para>
        ///  
        /// <para>
        /// These are not the tags that are used for Amazon Web Services resource tagging. For
        /// more information on row level security in QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-rls-tags.html">Using
        /// Row-Level Security (RLS) with Tags</a>in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<SessionTag> RowLevelPermissionTags
        {
            get { return this._rowLevelPermissionTags; }
            set { this._rowLevelPermissionTags = value; }
        }

        // Check to see if RowLevelPermissionTags property is set
        internal bool IsSetRowLevelPermissionTags()
        {
            return this._rowLevelPermissionTags != null && (this._rowLevelPermissionTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}