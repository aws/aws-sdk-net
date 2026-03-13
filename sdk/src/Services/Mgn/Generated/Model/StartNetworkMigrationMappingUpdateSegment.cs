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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A segment update to apply during a mapping update operation.
    /// </summary>
    public partial class StartNetworkMigrationMappingUpdateSegment
    {
        private Dictionary<string, string> _scopeTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _segmentid;
        private string _targetAccount;

        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// The updated scope tags for the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=40)]
        public Dictionary<string, string> ScopeTags
        {
            get { return this._scopeTags; }
            set { this._scopeTags = value; }
        }

        // Check to see if ScopeTags property is set
        internal bool IsSetScopeTags()
        {
            return this._scopeTags != null && (this._scopeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The ID of the segment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SegmentID
        {
            get { return this._segmentid; }
            set { this._segmentid = value; }
        }

        // Check to see if SegmentID property is set
        internal bool IsSetSegmentID()
        {
            return this._segmentid != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccount. 
        /// <para>
        /// The updated target AWS account for the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string TargetAccount
        {
            get { return this._targetAccount; }
            set { this._targetAccount = value; }
        }

        // Check to see if TargetAccount property is set
        internal bool IsSetTargetAccount()
        {
            return this._targetAccount != null;
        }

    }
}