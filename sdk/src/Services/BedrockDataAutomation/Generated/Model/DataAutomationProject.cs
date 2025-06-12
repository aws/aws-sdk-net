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
    /// Contains the information of a DataAutomationProject.
    /// </summary>
    public partial class DataAutomationProject
    {
        private DateTime? _creationTime;
        private CustomOutputConfiguration _customOutputConfiguration;
        private Dictionary<string, string> _kmsEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _kmsKeyId;
        private DateTime? _lastModifiedTime;
        private OverrideConfiguration _overrideConfiguration;
        private string _projectArn;
        private string _projectDescription;
        private string _projectName;
        private DataAutomationProjectStage _projectStage;
        private StandardOutputConfiguration _standardOutputConfiguration;
        private DataAutomationProjectStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

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
        /// Gets and sets the property KmsEncryptionContext.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, string> KmsEncryptionContext
        {
            get { return this._kmsEncryptionContext; }
            set { this._kmsEncryptionContext = value; }
        }

        // Check to see if KmsEncryptionContext property is set
        internal bool IsSetKmsEncryptionContext()
        {
            return this._kmsEncryptionContext != null && (this._kmsEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
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
        /// Gets and sets the property ProjectName.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
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

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required=true)]
        public DataAutomationProjectStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}