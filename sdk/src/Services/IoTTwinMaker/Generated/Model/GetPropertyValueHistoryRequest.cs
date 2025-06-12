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
    /// Container for the parameters to the GetPropertyValueHistory operation.
    /// Retrieves information about the history of a time series property value for a component,
    /// component type, entity, or workspace.
    /// 
    ///  
    /// <para>
    /// You must specify a value for <c>workspaceId</c>. For entity-specific queries, specify
    /// values for <c>componentName</c> and <c>entityId</c>. For cross-entity quries, specify
    /// a value for <c>componentTypeId</c>.
    /// </para>
    /// </summary>
    public partial class GetPropertyValueHistoryRequest : AmazonIoTTwinMakerRequest
    {
        private string _componentName;
        private string _componentPath;
        private string _componentTypeId;
        private DateTime? _endDateTime;
        private string _endTime;
        private string _entityId;
        private InterpolationParameters _interpolation;
        private int? _maxResults;
        private string _nextToken;
        private OrderByTime _orderByTime;
        private List<PropertyFilter> _propertyFilters = AWSConfigs.InitializeCollections ? new List<PropertyFilter>() : null;
        private List<string> _selectedProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startDateTime;
        private string _startTime;
        private string _workspaceId;

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
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time of the latest property value to return.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and will throw an error in the future. Use endTime instead.")]
        public DateTime? EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The ISO8601 DateTime of the latest property value to return.
        /// </para>
        ///  
        /// <para>
        /// For more information about the ISO8601 DateTime format, see the data type <a href="https://docs.aws.amazon.com/iot-twinmaker/latest/apireference/API_PropertyValue.html">PropertyValue</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=35)]
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity.
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
        /// Gets and sets the property Interpolation. 
        /// <para>
        /// An object that specifies the interpolation type and the interval over which to interpolate
        /// data.
        /// </para>
        /// </summary>
        public InterpolationParameters Interpolation
        {
            get { return this._interpolation; }
            set { this._interpolation = value; }
        }

        // Check to see if Interpolation property is set
        internal bool IsSetInterpolation()
        {
            return this._interpolation != null;
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
        /// Gets and sets the property OrderByTime. 
        /// <para>
        /// The time direction to use in the result order.
        /// </para>
        /// </summary>
        public OrderByTime OrderByTime
        {
            get { return this._orderByTime; }
            set { this._orderByTime = value; }
        }

        // Check to see if OrderByTime property is set
        internal bool IsSetOrderByTime()
        {
            return this._orderByTime != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// A list of objects that filter the property value history request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<PropertyFilter> PropertyFilters
        {
            get { return this._propertyFilters; }
            set { this._propertyFilters = value; }
        }

        // Check to see if PropertyFilters property is set
        internal bool IsSetPropertyFilters()
        {
            return this._propertyFilters != null && (this._propertyFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectedProperties. 
        /// <para>
        /// A list of properties whose value histories the request retrieves.
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
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time of the earliest property value to return.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated and will throw an error in the future. Use startTime instead.")]
        public DateTime? StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The ISO8601 DateTime of the earliest property value to return.
        /// </para>
        ///  
        /// <para>
        /// For more information about the ISO8601 DateTime format, see the data type <a href="https://docs.aws.amazon.com/iot-twinmaker/latest/apireference/API_PropertyValue.html">PropertyValue</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=35)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace.
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