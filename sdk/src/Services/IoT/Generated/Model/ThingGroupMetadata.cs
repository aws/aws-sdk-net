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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Thing group metadata.
    /// </summary>
    public partial class ThingGroupMetadata
    {
        private DateTime? _creationDate;
        private string _parentGroupName;
        private List<GroupNameAndArn> _rootToParentThingGroups = AWSConfigs.InitializeCollections ? new List<GroupNameAndArn>() : null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UNIX timestamp of when the thing group was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentGroupName. 
        /// <para>
        /// The parent thing group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParentGroupName
        {
            get { return this._parentGroupName; }
            set { this._parentGroupName = value; }
        }

        // Check to see if ParentGroupName property is set
        internal bool IsSetParentGroupName()
        {
            return this._parentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RootToParentThingGroups. 
        /// <para>
        /// The root parent thing group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupNameAndArn> RootToParentThingGroups
        {
            get { return this._rootToParentThingGroups; }
            set { this._rootToParentThingGroups = value; }
        }

        // Check to see if RootToParentThingGroups property is set
        internal bool IsSetRootToParentThingGroups()
        {
            return this._rootToParentThingGroups != null && (this._rootToParentThingGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}