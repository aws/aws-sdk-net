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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
    /// Container for the parameters to the UpdateDataAutomationProject operation.
    /// Updates an existing Amazon Bedrock Data Automation Project
    /// </summary>
    public partial class UpdateDataAutomationProjectRequest : AmazonBedrockDataAutomationRequest
    {
        private CustomOutputConfiguration _customOutputConfiguration;
        private EncryptionConfiguration _encryptionConfiguration;
        private OverrideConfiguration _overrideConfiguration;
        private string _projectArn;
        private string _projectDescription;
        private DataAutomationProjectStage _projectStage;
        private StandardOutputConfiguration _standardOutputConfiguration;

        /// <summary>
        /// Gets and sets the property CustomOutputConfiguration.
        /// </summary>
        public CustomOutputConfiguration CustomOutputConfiguration
        {
            get { return this._customOutputConfiguration; }
            set { this._customOutputConfiguration = value; }
        }

        // Check to see if CustomOutputConfiguration property is set
        internal bool IsSetCustomOutputConfiguration()
        {
            return this._customOutputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideConfiguration.
        /// </summary>
        public OverrideConfiguration OverrideConfiguration
        {
            get { return this._overrideConfiguration; }
            set { this._overrideConfiguration = value; }
        }

        // Check to see if OverrideConfiguration property is set
        internal bool IsSetOverrideConfiguration()
        {
            return this._overrideConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// ARN generated at the server side when a DataAutomationProject is created
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectDescription.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=300)]
        public string ProjectDescription
        {
            get { return this._projectDescription; }
            set { this._projectDescription = value; }
        }

        // Check to see if ProjectDescription property is set
        internal bool IsSetProjectDescription()
        {
            return this._projectDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectStage.
        /// </summary>
        public DataAutomationProjectStage ProjectStage
        {
            get { return this._projectStage; }
            set { this._projectStage = value; }
        }

        // Check to see if ProjectStage property is set
        internal bool IsSetProjectStage()
        {
            return this._projectStage != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutputConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public StandardOutputConfiguration StandardOutputConfiguration
        {
            get { return this._standardOutputConfiguration; }
            set { this._standardOutputConfiguration = value; }
        }

        // Check to see if StandardOutputConfiguration property is set
        internal bool IsSetStandardOutputConfiguration()
        {
            return this._standardOutputConfiguration != null;
        }

    }
}