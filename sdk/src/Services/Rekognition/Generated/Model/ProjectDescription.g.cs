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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A description of an Amazon Rekognition Custom Labels project. For more information,
    /// see <a>DescribeProjects</a>.
    /// </summary>
    public partial class ProjectDescription
    {
        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Indicates whether automatic retraining will be attempted for the versions of the project.
        /// Applies only to adapters. 
        /// </para>
        /// </summary>
        public ProjectAutoUpdate AutoUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpdate property is set.
        /// </summary>
        internal bool IsSetAutoUpdate() => this.AutoUpdate != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix timestamp for the date and time that the project was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Datasets. 
        /// <para>
        ///  Information about the training and test datasets in the project. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatasetMetadata> Datasets { get; set; } = AWSConfigs.InitializeCollections ? new List<DatasetMetadata>() : null;

        /// <summary>
        /// Checks to see if the Datasets property is set.
        /// </summary>
        internal bool IsSetDatasets() => this.Datasets != null && (this.Datasets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// Specifies the project that is being customized.
        /// </para>
        /// </summary>
        public CustomizationFeature Feature { get; set; }

        /// <summary>
        /// Checks to see if the Feature property is set.
        /// </summary>
        internal bool IsSetFeature() => this.Feature != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the project.
        /// </para>
        /// </summary>
        public ProjectStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
