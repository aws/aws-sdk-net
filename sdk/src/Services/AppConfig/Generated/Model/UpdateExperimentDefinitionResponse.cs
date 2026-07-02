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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Describes an experiment definition, including the target audience, feature flag, treatments,
    /// and current status.
    /// </summary>
    public partial class UpdateExperimentDefinitionResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private string _audienceDescription;
        private string _audienceRule;
        private string _configurationProfileId;
        private Treatment _control;
        private DateTime? _createdAt;
        private string _environmentId;
        private string _flagKey;
        private string _hypothesis;
        private string _id;
        private string _kmsKeyIdentifier;
        private string _launchCriteria;
        private string _name;
        private ExperimentDefinitionStatus _status;
        private List<Treatment> _treatments = AWSConfigs.InitializeCollections ? new List<Treatment>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AudienceDescription. 
        /// <para>
        /// A description of the intended audience for the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AudienceDescription
        {
            get { return this._audienceDescription; }
            set { this._audienceDescription = value; }
        }

        // Check to see if AudienceDescription property is set
        internal bool IsSetAudienceDescription()
        {
            return this._audienceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AudienceRule. 
        /// <para>
        /// The rule that defines which users are eligible to be assigned to treatments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string AudienceRule
        {
            get { return this._audienceRule; }
            set { this._audienceRule = value; }
        }

        // Check to see if AudienceRule property is set
        internal bool IsSetAudienceRule()
        {
            return this._audienceRule != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The configuration profile ID associated with the experiment.
        /// </para>
        /// </summary>
        public string ConfigurationProfileId
        {
            get { return this._configurationProfileId; }
            set { this._configurationProfileId = value; }
        }

        // Check to see if ConfigurationProfileId property is set
        internal bool IsSetConfigurationProfileId()
        {
            return this._configurationProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// The control treatment used as the baseline for comparison.
        /// </para>
        /// </summary>
        public Treatment Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the experiment definition was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The environment ID where the experiment runs.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property FlagKey. 
        /// <para>
        /// The key of the feature flag used by the experiment.
        /// </para>
        /// </summary>
        public string FlagKey
        {
            get { return this._flagKey; }
            set { this._flagKey = value; }
        }

        // Check to see if FlagKey property is set
        internal bool IsSetFlagKey()
        {
            return this._flagKey != null;
        }

        /// <summary>
        /// Gets and sets the property Hypothesis. 
        /// <para>
        /// The hypothesis that the experiment is designed to validate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Hypothesis
        {
            get { return this._hypothesis; }
            set { this._hypothesis = value; }
        }

        // Check to see if Hypothesis property is set
        internal bool IsSetHypothesis()
        {
            return this._hypothesis != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The experiment definition ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt experiment data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchCriteria. 
        /// <para>
        /// The conditions under which the winning treatment should be launched.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LaunchCriteria
        {
            get { return this._launchCriteria; }
            set { this._launchCriteria = value; }
        }

        // Check to see if LaunchCriteria property is set
        internal bool IsSetLaunchCriteria()
        {
            return this._launchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the experiment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the experiment definition. Valid values: <c>ACTIVE</c>, <c>IDLE</c>,
        /// <c>ARCHIVED</c>.
        /// </para>
        /// </summary>
        public ExperimentDefinitionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Treatments. 
        /// <para>
        /// The list of treatments defined for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<Treatment> Treatments
        {
            get { return this._treatments; }
            set { this._treatments = value; }
        }

        // Check to see if Treatments property is set
        internal bool IsSetTreatments()
        {
            return this._treatments != null && (this._treatments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the experiment definition was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}