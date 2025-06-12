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
    /// Container for the parameters to the UpdateThingGroupsForThing operation.
    /// Updates the groups to which the thing belongs.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThingGroupsForThing</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateThingGroupsForThingRequest : AmazonIoTRequest
    {
        private bool? _overrideDynamicGroups;
        private List<string> _thingGroupsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _thingGroupsToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property OverrideDynamicGroups. 
        /// <para>
        /// Override dynamic thing groups with static thing groups when 10-group limit is reached.
        /// If a thing belongs to 10 thing groups, and one or more of those groups are dynamic
        /// thing groups, adding a thing to a static group removes the thing from the last dynamic
        /// group.
        /// </para>
        /// </summary>
        public bool? OverrideDynamicGroups
        {
            get { return this._overrideDynamicGroups; }
            set { this._overrideDynamicGroups = value; }
        }

        // Check to see if OverrideDynamicGroups property is set
        internal bool IsSetOverrideDynamicGroups()
        {
            return this._overrideDynamicGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingGroupsToAdd. 
        /// <para>
        /// The groups to which the thing will be added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ThingGroupsToAdd
        {
            get { return this._thingGroupsToAdd; }
            set { this._thingGroupsToAdd = value; }
        }

        // Check to see if ThingGroupsToAdd property is set
        internal bool IsSetThingGroupsToAdd()
        {
            return this._thingGroupsToAdd != null && (this._thingGroupsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingGroupsToRemove. 
        /// <para>
        /// The groups from which the thing will be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ThingGroupsToRemove
        {
            get { return this._thingGroupsToRemove; }
            set { this._thingGroupsToRemove = value; }
        }

        // Check to see if ThingGroupsToRemove property is set
        internal bool IsSetThingGroupsToRemove()
        {
            return this._thingGroupsToRemove != null && (this._thingGroupsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The thing whose group memberships will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}