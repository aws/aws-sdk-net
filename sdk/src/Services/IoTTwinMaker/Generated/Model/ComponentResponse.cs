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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that returns information about a component type create or update request.
    /// </summary>
    public partial class ComponentResponse
    {
        private bool? _areAllCompositeComponentsReturned;
        private bool? _areAllPropertiesReturned;
        private string _componentName;
        private string _componentTypeId;
        private Dictionary<string, ComponentSummary> _compositeComponents = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentSummary>() : null;
        private string _definedIn;
        private string _description;
        private Dictionary<string, PropertyResponse> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyResponse>() : null;
        private Dictionary<string, ComponentPropertyGroupResponse> _propertyGroups = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentPropertyGroupResponse>() : null;
        private Status _status;
        private string _syncSource;

        /// <summary>
        /// Gets and sets the property AreAllCompositeComponentsReturned. 
        /// <para>
        /// This flag notes whether all <c>compositeComponents</c> are returned in the API response.
        /// </para>
        /// </summary>
        public bool? AreAllCompositeComponentsReturned
        {
            get { return this._areAllCompositeComponentsReturned; }
            set { this._areAllCompositeComponentsReturned = value; }
        }

        // Check to see if AreAllCompositeComponentsReturned property is set
        internal bool IsSetAreAllCompositeComponentsReturned()
        {
            return this._areAllCompositeComponentsReturned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AreAllPropertiesReturned. 
        /// <para>
        /// This flag notes whether all properties of the component are returned in the API response.
        /// The maximum number of properties returned is 800.
        /// </para>
        /// </summary>
        public bool? AreAllPropertiesReturned
        {
            get { return this._areAllPropertiesReturned; }
            set { this._areAllPropertiesReturned = value; }
        }

        // Check to see if AreAllPropertiesReturned property is set
        internal bool IsSetAreAllPropertiesReturned()
        {
            return this._areAllPropertiesReturned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ComponentTypeId
        {
            get { return this._componentTypeId; }
            set { this._componentTypeId = value; }
        }

        // Check to see if ComponentTypeId property is set
        internal bool IsSetComponentTypeId()
        {
            return this._componentTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property CompositeComponents. 
        /// <para>
        /// This lists objects that contain information about the <c>compositeComponents</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentSummary> CompositeComponents
        {
            get { return this._compositeComponents; }
            set { this._compositeComponents = value; }
        }

        // Check to see if CompositeComponents property is set
        internal bool IsSetCompositeComponents()
        {
            return this._compositeComponents != null && (this._compositeComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefinedIn. 
        /// <para>
        /// The name of the property definition set in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DefinedIn
        {
            get { return this._definedIn; }
            set { this._definedIn = value; }
        }

        // Check to see if DefinedIn property is set
        internal bool IsSetDefinedIn()
        {
            return this._definedIn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// An object that maps strings to the properties to set in the component type. Each string
        /// in the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyResponse> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// The property groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentPropertyGroupResponse> PropertyGroups
        {
            get { return this._propertyGroups; }
            set { this._propertyGroups = value; }
        }

        // Check to see if PropertyGroups property is set
        internal bool IsSetPropertyGroups()
        {
            return this._propertyGroups != null && (this._propertyGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the component type.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The syncSource of the sync job, if this entity was created by a sync job.
        /// </para>
        /// </summary>
        public string SyncSource
        {
            get { return this._syncSource; }
            set { this._syncSource = value; }
        }

        // Check to see if SyncSource property is set
        internal bool IsSetSyncSource()
        {
            return this._syncSource != null;
        }

    }
}