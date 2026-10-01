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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that describes the details of a topic, such as its name, description,
    /// and associated data sets.
    /// </summary>
    public partial class TopicDetails
    {
        /// <summary>
        /// Gets and sets the property ConfigOptions. 
        /// <para>
        /// Configuration options for a <c>Topic</c>.
        /// </para>
        /// </summary>
        public TopicConfigOptions ConfigOptions { get; set; }

        /// <summary>
        /// Checks to see if the ConfigOptions property is set.
        /// </summary>
        internal bool IsSetConfigOptions() => this.ConfigOptions != null;

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// The data sets that the topic is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatasetMetadata> DataSets { get; set; } = AWSConfigs.InitializeCollections ? new List<DatasetMetadata>() : null;

        /// <summary>
        /// Checks to see if the DataSets property is set.
        /// </summary>
        internal bool IsSetDataSets() => this.DataSets != null && (this.DataSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UserExperienceVersion. 
        /// <para>
        /// The user experience version of a topic.
        /// </para>
        /// </summary>
        public TopicUserExperienceVersion UserExperienceVersion { get; set; }

        /// <summary>
        /// Checks to see if the UserExperienceVersion property is set.
        /// </summary>
        internal bool IsSetUserExperienceVersion() => this.UserExperienceVersion != null;
    }
}
