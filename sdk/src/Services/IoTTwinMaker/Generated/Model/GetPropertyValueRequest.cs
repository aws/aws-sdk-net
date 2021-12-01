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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the GetPropertyValue operation.
    /// Gets the property values for a component, component type, entity, or workspace.
    /// 
    ///  
    /// <para>
    /// You must specify a value for either <code>componentName</code>, <code>componentTypeId</code>,
    /// <code>entityId</code>, or <code>workspaceId</code>.
    /// </para>
    /// </summary>
    public partial class GetPropertyValueRequest : AmazonIoTTwinMakerRequest
    {
        private string _componentName;
        private string _componentTypeId;
        private string _entityId;
        private List<string> _selectedProperties = new List<string>();
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component whose property values the operation returns.
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
        /// The ID of the component type whose property values the operation returns.
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
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity whose property values the operation returns.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedProperties. 
        /// <para>
        /// The properties whose values the operation returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> SelectedProperties
        {
            get { return this._selectedProperties; }
            set { this._selectedProperties = value; }
        }

        // Check to see if SelectedProperties property is set
        internal bool IsSetSelectedProperties()
        {
            return this._selectedProperties != null && this._selectedProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace whose values the operation returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}