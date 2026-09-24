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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// A class for modeling different type of tasks. Task implementation varies based on
    /// the <c>TaskType</c>.
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// Gets and sets the property ConnectorOperator. 
        /// <para>
        ///  The operation to be performed on the provided source fields. 
        /// </para>
        /// </summary>
        public ConnectorOperator ConnectorOperator { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperator property is set.
        /// </summary>
        internal bool IsSetConnectorOperator() => this.ConnectorOperator != null;

        /// <summary>
        /// Gets and sets the property DestinationField. 
        /// <para>
        ///  A field in a destination connector, or a field value against which Amazon AppFlow
        /// validates a source field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DestinationField { get; set; }

        /// <summary>
        /// Checks to see if the DestinationField property is set.
        /// </summary>
        internal bool IsSetDestinationField() => this.DestinationField != null;

        /// <summary>
        /// Gets and sets the property SourceFields. 
        /// <para>
        ///  The source fields to which a particular task is applied. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SourceFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceFields property is set.
        /// </summary>
        internal bool IsSetSourceFields() => this.SourceFields != null && (this.SourceFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskProperties. 
        /// <para>
        ///  A map used to store task-related information. The execution service looks for particular
        /// information based on the <c>TaskType</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TaskProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TaskProperties property is set.
        /// </summary>
        internal bool IsSetTaskProperties() => this.TaskProperties != null && (this.TaskProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        ///  Specifies the particular task implementation that Amazon AppFlow performs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// Checks to see if the TaskType property is set.
        /// </summary>
        internal bool IsSetTaskType() => this.TaskType != null;
    }
}
