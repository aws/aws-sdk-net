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
    /// Container for the parameters to the UpdateDataAutomationLibrary operation. Updates
    /// an existing Amazon Bedrock Data Automation Library
    /// </summary>
    public partial class UpdateDataAutomationLibraryRequest : AmazonBedrockDataAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property LibraryArn. ARN generated at the server side when a DataAutomationLibrary
        /// is created
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string LibraryArn { get; set; }

        /// <summary>
        /// Checks to see if the LibraryArn property is set.
        /// </summary>
        internal bool IsSetLibraryArn() => this.LibraryArn != null;

        /// <summary>
        /// Gets and sets the property LibraryDescription.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 300)]
        public string LibraryDescription { get; set; }

        /// <summary>
        /// Checks to see if the LibraryDescription property is set.
        /// </summary>
        internal bool IsSetLibraryDescription() => this.LibraryDescription != null;
    }
}
