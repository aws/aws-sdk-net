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
    /// Container for the parameters to the UpdateDataAutomationLibrary operation.
    /// Updates an existing Amazon Bedrock Data Automation Library
    /// </summary>
    public partial class UpdateDataAutomationLibraryRequest : AmazonBedrockDataAutomationRequest
    {
        private string _clientToken;
        private string _libraryArn;
        private string _libraryDescription;

        /// <summary>
        /// Gets and sets the property ClientToken.
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
        /// Gets and sets the property LibraryArn. 
        /// <para>
        /// ARN generated at the server side when a DataAutomationLibrary is created
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string LibraryArn
        {
            get { return this._libraryArn; }
            set { this._libraryArn = value; }
        }

        // Check to see if LibraryArn property is set
        internal bool IsSetLibraryArn()
        {
            return this._libraryArn != null;
        }

        /// <summary>
        /// Gets and sets the property LibraryDescription.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=300)]
        public string LibraryDescription
        {
            get { return this._libraryDescription; }
            set { this._libraryDescription = value; }
        }

        // Check to see if LibraryDescription property is set
        internal bool IsSetLibraryDescription()
        {
            return this._libraryDescription != null;
        }

    }
}