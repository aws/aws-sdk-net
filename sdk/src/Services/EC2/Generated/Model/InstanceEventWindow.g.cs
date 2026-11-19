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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The event window.
    /// </summary>
    public partial class InstanceEventWindow
    {
        /// <summary>
        /// Gets and sets the property AssociationTarget. 
        /// <para>
        /// One or more targets associated with the event window.
        /// </para>
        /// </summary>
        public InstanceEventWindowAssociationTarget AssociationTarget { get; set; }

        /// <summary>
        /// Checks to see if the AssociationTarget property is set.
        /// </summary>
        internal bool IsSetAssociationTarget() => this.AssociationTarget != null;

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The cron expression defined for the event window.
        /// </para>
        /// </summary>
        public string CronExpression { get; set; }

        /// <summary>
        /// Checks to see if the CronExpression property is set.
        /// </summary>
        internal bool IsSetCronExpression() => this.CronExpression != null;

        /// <summary>
        /// Gets and sets the property InstanceEventWindowId. 
        /// <para>
        /// The ID of the event window.
        /// </para>
        /// </summary>
        public string InstanceEventWindowId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceEventWindowId property is set.
        /// </summary>
        internal bool IsSetInstanceEventWindowId() => this.InstanceEventWindowId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event window.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the event window.
        /// </para>
        /// </summary>
        public InstanceEventWindowState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The instance tags associated with the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeRanges. 
        /// <para>
        /// One or more time ranges defined for the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceEventWindowTimeRange> TimeRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceEventWindowTimeRange>() : null;

        /// <summary>
        /// Checks to see if the TimeRanges property is set.
        /// </summary>
        internal bool IsSetTimeRanges() => this.TimeRanges != null && (this.TimeRanges.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
