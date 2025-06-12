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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
        private string _algorithmArn;
        private AlgorithmImage _algorithmImage;
        private DateTime? _creationDateTime;
        private DefaultHyperParameterRanges _defaultHyperParameterRanges;
        private Dictionary<string, string> _defaultHyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _defaultResourceConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _lastUpdatedDateTime;
        private string _name;
        private string _roleArn;
        private string _trainingInputMode;

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AlgorithmArn
        {
            get { return this._algorithmArn; }
            set { this._algorithmArn = value; }
        }

        // Check to see if AlgorithmArn property is set
        internal bool IsSetAlgorithmArn()
        {
            return this._algorithmArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlgorithmImage. 
        /// <para>
        /// The URI of the Docker container for the algorithm image.
        /// </para>
        /// </summary>
        public AlgorithmImage AlgorithmImage
        {
            get { return this._algorithmImage; }
            set { this._algorithmImage = value; }
        }

        // Check to see if AlgorithmImage property is set
        internal bool IsSetAlgorithmImage()
        {
            return this._algorithmImage != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the algorithm was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultHyperParameterRanges. 
        /// <para>
        /// Specifies the default hyperparameters, their ranges, and whether they are tunable.
        /// A tunable hyperparameter can have its value determined during hyperparameter optimization
        /// (HPO).
        /// </para>
        /// </summary>
        public DefaultHyperParameterRanges DefaultHyperParameterRanges
        {
            get { return this._defaultHyperParameterRanges; }
            set { this._defaultHyperParameterRanges = value; }
        }

        // Check to see if DefaultHyperParameterRanges property is set
        internal bool IsSetDefaultHyperParameterRanges()
        {
            return this._defaultHyperParameterRanges != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultHyperParameters. 
        /// <para>
        /// Specifies the default hyperparameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> DefaultHyperParameters
        {
            get { return this._defaultHyperParameters; }
            set { this._defaultHyperParameters = value; }
        }

        // Check to see if DefaultHyperParameters property is set
        internal bool IsSetDefaultHyperParameters()
        {
            return this._defaultHyperParameters != null && (this._defaultHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultResourceConfig. 
        /// <para>
        /// Specifies the default maximum number of training jobs and parallel training jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> DefaultResourceConfig
        {
            get { return this._defaultResourceConfig; }
            set { this._defaultResourceConfig = value; }
        }

        // Check to see if DefaultResourceConfig property is set
        internal bool IsSetDefaultResourceConfig()
        {
            return this._defaultResourceConfig != null && (this._defaultResourceConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the algorithm was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingInputMode. 
        /// <para>
        /// The training input mode.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TrainingInputMode
        {
            get { return this._trainingInputMode; }
            set { this._trainingInputMode = value; }
        }

        // Check to see if TrainingInputMode property is set
        internal bool IsSetTrainingInputMode()
        {
            return this._trainingInputMode != null;
        }

    }
}