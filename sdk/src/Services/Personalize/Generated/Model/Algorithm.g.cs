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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes a custom algorithm.
    /// </summary>
    public partial class Algorithm
    {
        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AlgorithmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmArn property is set.
        /// </summary>
        internal bool IsSetAlgorithmArn() => this.AlgorithmArn != null;

        /// <summary>
        /// Gets and sets the property AlgorithmImage. 
        /// <para>
        /// The URI of the Docker container for the algorithm image.
        /// </para>
        /// </summary>
        public AlgorithmImage AlgorithmImage { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmImage property is set.
        /// </summary>
        internal bool IsSetAlgorithmImage() => this.AlgorithmImage != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the algorithm was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultHyperParameterRanges. 
        /// <para>
        /// Specifies the default hyperparameters, their ranges, and whether they are tunable.
        /// A tunable hyperparameter can have its value determined during hyperparameter optimization
        /// (HPO).
        /// </para>
        /// </summary>
        public DefaultHyperParameterRanges DefaultHyperParameterRanges { get; set; }

        /// <summary>
        /// Checks to see if the DefaultHyperParameterRanges property is set.
        /// </summary>
        internal bool IsSetDefaultHyperParameterRanges() => this.DefaultHyperParameterRanges != null;

        /// <summary>
        /// Gets and sets the property DefaultHyperParameters. 
        /// <para>
        /// Specifies the default hyperparameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> DefaultHyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DefaultHyperParameters property is set.
        /// </summary>
        internal bool IsSetDefaultHyperParameters() => this.DefaultHyperParameters != null && (this.DefaultHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultResourceConfig. 
        /// <para>
        /// Specifies the default maximum number of training jobs and parallel training jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> DefaultResourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DefaultResourceConfig property is set.
        /// </summary>
        internal bool IsSetDefaultResourceConfig() => this.DefaultResourceConfig != null && (this.DefaultResourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the algorithm was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TrainingInputMode. 
        /// <para>
        /// The training input mode.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrainingInputMode { get; set; }

        /// <summary>
        /// Checks to see if the TrainingInputMode property is set.
        /// </summary>
        internal bool IsSetTrainingInputMode() => this.TrainingInputMode != null;
    }
}
