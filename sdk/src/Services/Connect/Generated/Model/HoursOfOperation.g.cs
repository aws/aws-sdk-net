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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about of the hours of operation.
    /// </summary>
    public partial class HoursOfOperation
    {
        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// Configuration information for the hours of operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<HoursOfOperationConfig> Config { get; set; } = AWSConfigs.InitializeCollections ? new List<HoursOfOperationConfig>() : null;

        /// <summary>
        /// Checks to see if the Config property is set.
        /// </summary>
        internal bool IsSetConfig() => this.Config != null && (this.Config.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationArn property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationArn() => this.HoursOfOperationArn != null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationId() => this.HoursOfOperationId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentHoursOfOperations. 
        /// <para>
        /// Information about parent hours of operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HoursOfOperationsIdentifier> ParentHoursOfOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<HoursOfOperationsIdentifier>() : null;

        /// <summary>
        /// Checks to see if the ParentHoursOfOperations property is set.
        /// </summary>
        internal bool IsSetParentHoursOfOperations() => this.ParentHoursOfOperations != null && (this.ParentHoursOfOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone for the hours of operation.
        /// </para>
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;
    }
}
