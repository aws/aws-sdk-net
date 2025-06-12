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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The event window.
    /// </summary>
    public partial class InstanceEventWindow
    {
        private InstanceEventWindowAssociationTarget _associationTarget;
        private string _cronExpression;
        private string _instanceEventWindowId;
        private string _name;
        private InstanceEventWindowState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<InstanceEventWindowTimeRange> _timeRanges = AWSConfigs.InitializeCollections ? new List<InstanceEventWindowTimeRange>() : null;

        /// <summary>
        /// Gets and sets the property AssociationTarget. 
        /// <para>
        /// One or more targets associated with the event window.
        /// </para>
        /// </summary>
        public InstanceEventWindowAssociationTarget AssociationTarget
        {
            get { return this._associationTarget; }
            set { this._associationTarget = value; }
        }

        // Check to see if AssociationTarget property is set
        internal bool IsSetAssociationTarget()
        {
            return this._associationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The cron expression defined for the event window.
        /// </para>
        /// </summary>
        public string CronExpression
        {
            get { return this._cronExpression; }
            set { this._cronExpression = value; }
        }

        // Check to see if CronExpression property is set
        internal bool IsSetCronExpression()
        {
            return this._cronExpression != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceEventWindowId. 
        /// <para>
        /// The ID of the event window.
        /// </para>
        /// </summary>
        public string InstanceEventWindowId
        {
            get { return this._instanceEventWindowId; }
            set { this._instanceEventWindowId = value; }
        }

        // Check to see if InstanceEventWindowId property is set
        internal bool IsSetInstanceEventWindowId()
        {
            return this._instanceEventWindowId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event window.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the event window.
        /// </para>
        /// </summary>
        public InstanceEventWindowState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The instance tags associated with the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeRanges. 
        /// <para>
        /// One or more time ranges defined for the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceEventWindowTimeRange> TimeRanges
        {
            get { return this._timeRanges; }
            set { this._timeRanges = value; }
        }

        // Check to see if TimeRanges property is set
        internal bool IsSetTimeRanges()
        {
            return this._timeRanges != null && (this._timeRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}