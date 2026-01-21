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
    /// A group of elements within a sheet layout.
    /// </summary>
    public partial class SheetLayoutGroup
    {
        private string _id;
        private List<SheetLayoutGroupMember> _members = AWSConfigs.InitializeCollections ? new List<SheetLayoutGroupMember>() : null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The members of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=430)]
        public List<SheetLayoutGroupMember> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && (this._members.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}