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
    /// Container for the parameters to the GetPropertyValue operation.
    /// Gets the property values for a component, component type, entity, or workspace.
    /// 
    ///  
    /// <para>
    /// You must specify a value for either <c>componentName</c>, <c>componentTypeId</c>,
    /// <c>entityId</c>, or <c>workspaceId</c>.
    /// </para>
    /// </summary>
    public partial class GetPropertyValueRequest : AmazonIoTTwinMakerRequest
    {
        private string _componentName;
        private string _componentPath;
        private string _componentTypeId;
        private string _entityId;
        private int? _maxResults;
        private string _nextToken;
        private string _propertyGroupName;
        private List<string> _selectedProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TabularConditions _tabularConditions;
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
        /// Gets and sets the property ComponentPath. 
        /// <para>
        /// This string specifies the path to the composite component, starting from the top-level
        /// component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ComponentPath
        {
            get { return this._componentPath; }
            set { this._componentPath = value; }
        }

        // Check to see if ComponentPath property is set
        internal bool IsSetComponentPath()
        {
            return this._componentPath != null;
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time. The default is 25.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 1. Maximum value of 250.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=17880)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyGroupName. 
        /// <para>
        /// The property group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PropertyGroupName
        {
            get { return this._propertyGroupName; }
            set { this._propertyGroupName = value; }
        }

        // Check to see if PropertyGroupName property is set
        internal bool IsSetPropertyGroupName()
        {
            return this._propertyGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedProperties. 
        /// <para>
        /// The properties whose values the operation returns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._selectedProperties != null && (this._selectedProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TabularConditions. 
        /// <para>
        /// The tabular conditions.
        /// </para>
        /// </summary>
        public TabularConditions TabularConditions
        {
            get { return this._tabularConditions; }
            set { this._tabularConditions = value; }
        }

        // Check to see if TabularConditions property is set
        internal bool IsSetTabularConditions()
        {
            return this._tabularConditions != null;
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