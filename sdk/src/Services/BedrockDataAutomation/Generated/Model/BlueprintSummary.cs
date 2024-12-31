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
    /// Summary of a Blueprint
    /// </summary>
    public partial class BlueprintSummary
    {
        private string _blueprintArn;
        private string _blueprintName;
        private BlueprintStage _blueprintStage;
        private string _blueprintVersion;
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;

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
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property LastModifiedTime.
        /// </summary>
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

    }
}