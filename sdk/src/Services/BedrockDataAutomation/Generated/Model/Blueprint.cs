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
    /// Contains the information of a Blueprint.
    /// </summary>
    public partial class Blueprint
    {
        private string _blueprintArn;
        private string _blueprintName;
        private BlueprintStage _blueprintStage;
        private string _blueprintVersion;
        private DateTime? _creationTime;
        private Dictionary<string, string> _kmsEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _kmsKeyId;
        private DateTime? _lastModifiedTime;
        private string _schema;
        private Type _type;

        /// <summary>
        /// Gets and sets the property BlueprintArn.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string BlueprintArn
        {
            get { return this._blueprintArn; }
            set { this._blueprintArn = value; }
        }

        // Check to see if BlueprintArn property is set
        internal bool IsSetBlueprintArn()
        {
            return this._blueprintArn != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintName.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string BlueprintName
        {
            get { return this._blueprintName; }
            set { this._blueprintName = value; }
        }

        // Check to see if BlueprintName property is set
        internal bool IsSetBlueprintName()
        {
            return this._blueprintName != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintStage.
        /// </summary>
        public BlueprintStage BlueprintStage
        {
            get { return this._blueprintStage; }
            set { this._blueprintStage = value; }
        }

        // Check to see if BlueprintStage property is set
        internal bool IsSetBlueprintStage()
        {
            return this._blueprintStage != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintVersion.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BlueprintVersion
        {
            get { return this._blueprintVersion; }
            set { this._blueprintVersion = value; }
        }

        // Check to see if BlueprintVersion property is set
        internal bool IsSetBlueprintVersion()
        {
            return this._blueprintVersion != null;
        }

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
        /// Gets and sets the property Schema.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100000)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}