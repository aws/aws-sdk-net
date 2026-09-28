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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Contains the information of a DataAutomationProject.
    /// </summary>
    public partial class DataAutomationProject
    {
        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomOutputConfiguration.
        /// </summary>
        public CustomOutputConfiguration CustomOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomOutputConfiguration() => this.CustomOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataAutomationLibraryConfiguration.
        /// </summary>
        public DataAutomationLibraryConfiguration DataAutomationLibraryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataAutomationLibraryConfiguration property is set.
        /// </summary>
        internal bool IsSetDataAutomationLibraryConfiguration() => this.DataAutomationLibraryConfiguration != null;

        /// <summary>
        /// Gets and sets the property KmsEncryptionContext.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, string> KmsEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KmsEncryptionContext property is set.
        /// </summary>
        internal bool IsSetKmsEncryptionContext() => this.KmsEncryptionContext != null && (this.KmsEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OverrideConfiguration.
        /// </summary>
        public OverrideConfiguration OverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetOverrideConfiguration() => this.OverrideConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProjectArn.
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property ProjectDescription.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 300)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProjectDescription property is set.
        /// </summary>
        internal bool IsSetProjectDescription() => this.ProjectDescription != null;

        /// <summary>
        /// Gets and sets the property ProjectName.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property ProjectStage.
        /// </summary>
        public DataAutomationProjectStage ProjectStage { get; set; }

        /// <summary>
        /// Checks to see if the ProjectStage property is set.
        /// </summary>
        internal bool IsSetProjectStage() => this.ProjectStage != null;

        /// <summary>
        /// Gets and sets the property ProjectType.
        /// </summary>
        public DataAutomationProjectType ProjectType { get; set; }

        /// <summary>
        /// Checks to see if the ProjectType property is set.
        /// </summary>
        internal bool IsSetProjectType() => this.ProjectType != null;

        /// <summary>
        /// Gets and sets the property StandardOutputConfiguration.
        /// </summary>
        public StandardOutputConfiguration StandardOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StandardOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetStandardOutputConfiguration() => this.StandardOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required = true)]
        public DataAutomationProjectStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
