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
    /// Parameters used when defining a mitigation action that move a set of things to a thing
    /// group.
    /// </summary>
    public partial class AddThingsToThingGroupParams
    {
        private bool? _overrideDynamicGroups;
        private List<string> _thingGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property OverrideDynamicGroups. 
        /// <para>
        /// Specifies if this mitigation action can move the things that triggered the mitigation
        /// action even if they are part of one or more dynamic thing groups.
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
        /// Gets and sets the property ThingGroupNames. 
        /// <para>
        /// The list of groups to which you want to add the things that triggered the mitigation
        /// action. You can add a thing to a maximum of 10 groups, but you can't add a thing to
        /// more than one group in the same hierarchy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ThingGroupNames
        {
            get { return this._thingGroupNames; }
            set { this._thingGroupNames = value; }
        }

        // Check to see if ThingGroupNames property is set
        internal bool IsSetThingGroupNames()
        {
            return this._thingGroupNames != null && (this._thingGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}