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
    /// Container for the parameters to the CopyBlueprintStage operation.
    /// Copies a Blueprint from one stage to another
    /// </summary>
    public partial class CopyBlueprintStageRequest : AmazonBedrockDataAutomationRequest
    {
        private string _blueprintArn;
        private string _clientToken;
        private BlueprintStage _sourceStage;
        private BlueprintStage _targetStage;

        /// <summary>
        /// Gets and sets the property BlueprintArn. 
        /// <para>
        /// Blueprint to be copied
        /// </para>
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Client token for idempotency
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property SourceStage. 
        /// <para>
        /// Source stage to copy from
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlueprintStage SourceStage
        {
            get { return this._sourceStage; }
            set { this._sourceStage = value; }
        }

        // Check to see if SourceStage property is set
        internal bool IsSetSourceStage()
        {
            return this._sourceStage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetStage. 
        /// <para>
        /// Target stage to copy to
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlueprintStage TargetStage
        {
            get { return this._targetStage; }
            set { this._targetStage = value; }
        }

        // Check to see if TargetStage property is set
        internal bool IsSetTargetStage()
        {
            return this._targetStage != null;
        }

    }
}