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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Thing group metadata.
    /// </summary>
    public partial class ThingGroupMetadata
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UNIX timestamp of when the thing group was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ParentGroupName. 
        /// <para>
        /// The parent thing group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParentGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ParentGroupName property is set.
        /// </summary>
        internal bool IsSetParentGroupName() => this.ParentGroupName != null;

        /// <summary>
        /// Gets and sets the property RootToParentThingGroups. 
        /// <para>
        /// The root parent thing group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupNameAndArn> RootToParentThingGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupNameAndArn>() : null;

        /// <summary>
        /// Checks to see if the RootToParentThingGroups property is set.
        /// </summary>
        internal bool IsSetRootToParentThingGroups() => this.RootToParentThingGroups != null && (this.RootToParentThingGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
