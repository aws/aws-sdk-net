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
    /// The thing group search index document.
    /// </summary>
    public partial class ThingGroupDocument
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _parentGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _thingGroupDescription;
        private string _thingGroupId;
        private string _thingGroupName;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The thing group attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentGroupNames. 
        /// <para>
        /// Parent group names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParentGroupNames
        {
            get { return this._parentGroupNames; }
            set { this._parentGroupNames = value; }
        }

        // Check to see if ParentGroupNames property is set
        internal bool IsSetParentGroupNames()
        {
            return this._parentGroupNames != null && (this._parentGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingGroupDescription. 
        /// <para>
        /// The thing group description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string ThingGroupDescription
        {
            get { return this._thingGroupDescription; }
            set { this._thingGroupDescription = value; }
        }

        // Check to see if ThingGroupDescription property is set
        internal bool IsSetThingGroupDescription()
        {
            return this._thingGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupId. 
        /// <para>
        /// The thing group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingGroupId
        {
            get { return this._thingGroupId; }
            set { this._thingGroupId = value; }
        }

        // Check to see if ThingGroupId property is set
        internal bool IsSetThingGroupId()
        {
            return this._thingGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// The thing group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingGroupName
        {
            get { return this._thingGroupName; }
            set { this._thingGroupName = value; }
        }

        // Check to see if ThingGroupName property is set
        internal bool IsSetThingGroupName()
        {
            return this._thingGroupName != null;
        }

    }
}