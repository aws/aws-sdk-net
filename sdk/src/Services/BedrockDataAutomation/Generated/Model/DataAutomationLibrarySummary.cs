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
    /// Summary of a DataAutomationLibrary
    /// </summary>
    public partial class DataAutomationLibrarySummary
    {
        private DateTime? _creationTime;
        private string _libraryArn;
        private string _libraryName;

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
        /// Gets and sets the property LibraryArn.
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
        /// Gets and sets the property LibraryName.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string LibraryName
        {
            get { return this._libraryName; }
            set { this._libraryName = value; }
        }

        // Check to see if LibraryName property is set
        internal bool IsSetLibraryName()
        {
            return this._libraryName != null;
        }

    }
}