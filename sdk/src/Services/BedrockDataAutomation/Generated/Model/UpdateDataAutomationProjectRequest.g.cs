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
    /// Container for the parameters to the UpdateDataAutomationProject operation. Updates
    /// an existing Amazon Bedrock Data Automation Project
    /// </summary>
    public partial class UpdateDataAutomationProjectRequest : AmazonBedrockDataAutomationRequest
    {
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
        /// Gets and sets the property EncryptionConfiguration.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property OverrideConfiguration.
        /// </summary>
        public OverrideConfiguration OverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetOverrideConfiguration() => this.OverrideConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. ARN generated at the server side when a DataAutomationProject
        /// is created
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
        /// Gets and sets the property ProjectStage.
        /// </summary>
        public DataAutomationProjectStage ProjectStage { get; set; }

        /// <summary>
        /// Checks to see if the ProjectStage property is set.
        /// </summary>
        internal bool IsSetProjectStage() => this.ProjectStage != null;

        /// <summary>
        /// Gets and sets the property StandardOutputConfiguration.
        /// </summary>
        [AWSProperty(Required = true)]
        public StandardOutputConfiguration StandardOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StandardOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetStandardOutputConfiguration() => this.StandardOutputConfiguration != null;
    }
}
