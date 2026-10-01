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
    /// Container for the parameters to the GetDataAutomationProject operation. Gets an existing
    /// Amazon Bedrock Data Automation Project
    /// </summary>
    public partial class GetDataAutomationProjectRequest : AmazonBedrockDataAutomationRequest
    {
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
        /// Gets and sets the property ProjectStage. Optional field to delete a specific DataAutomationProject
        /// stage
        /// </summary>
        public DataAutomationProjectStage ProjectStage { get; set; }

        /// <summary>
        /// Checks to see if the ProjectStage property is set.
        /// </summary>
        internal bool IsSetProjectStage() => this.ProjectStage != null;
    }
}
