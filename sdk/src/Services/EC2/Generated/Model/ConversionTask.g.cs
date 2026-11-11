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
    /// Describes a conversion task.
    /// </summary>
    public partial class ConversionTask
    {
        /// <summary>
        /// Gets and sets the property ConversionTaskId. 
        /// <para>
        /// The ID of the conversion task.
        /// </para>
        /// </summary>
        public string ConversionTaskId { get; set; }

        /// <summary>
        /// Checks to see if the ConversionTaskId property is set.
        /// </summary>
        internal bool IsSetConversionTaskId() => this.ConversionTaskId != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time when the task expires. If the upload isn't complete before the expiration
        /// time, we automatically cancel the task.
        /// </para>
        /// </summary>
        public string ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime != null;

        /// <summary>
        /// Gets and sets the property ImportInstance. 
        /// <para>
        /// If the task is for importing an instance, this contains information about the import
        /// instance task.
        /// </para>
        /// </summary>
        public ImportInstanceTaskDetails ImportInstance { get; set; }

        /// <summary>
        /// Checks to see if the ImportInstance property is set.
        /// </summary>
        internal bool IsSetImportInstance() => this.ImportInstance != null;

        /// <summary>
        /// Gets and sets the property ImportVolume. 
        /// <para>
        /// If the task is for importing a volume, this contains information about the import
        /// volume task.
        /// </para>
        /// </summary>
        public ImportVolumeTaskDetails ImportVolume { get; set; }

        /// <summary>
        /// Checks to see if the ImportVolume property is set.
        /// </summary>
        internal bool IsSetImportVolume() => this.ImportVolume != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the conversion task.
        /// </para>
        /// </summary>
        public ConversionTaskState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message related to the conversion task.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the task.
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
    }
}
