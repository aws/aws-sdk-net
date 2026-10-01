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
    /// Container for the parameters to the CopyBlueprintStage operation. Copies a Blueprint
    /// from one stage to another
    /// </summary>
    public partial class CopyBlueprintStageRequest : AmazonBedrockDataAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property BlueprintArn. Blueprint to be copied
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string BlueprintArn { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintArn property is set.
        /// </summary>
        internal bool IsSetBlueprintArn() => this.BlueprintArn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. Client token for idempotency
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property SourceStage. Source stage to copy from
        /// </summary>
        [AWSProperty(Required = true)]
        public BlueprintStage SourceStage { get; set; }

        /// <summary>
        /// Checks to see if the SourceStage property is set.
        /// </summary>
        internal bool IsSetSourceStage() => this.SourceStage != null;

        /// <summary>
        /// Gets and sets the property TargetStage. Target stage to copy to
        /// </summary>
        [AWSProperty(Required = true)]
        public BlueprintStage TargetStage { get; set; }

        /// <summary>
        /// Checks to see if the TargetStage property is set.
        /// </summary>
        internal bool IsSetTargetStage() => this.TargetStage != null;
    }
}
