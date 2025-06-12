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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration specifying how to treat different headers. If no headers are specified
    /// Amazon SageMaker AI will by default base64 encode when capturing the data.
    /// </summary>
    public partial class CaptureContentTypeHeader
    {
        private List<string> _csvContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _jsonContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CsvContentTypes. 
        /// <para>
        /// The list of all content type headers that Amazon SageMaker AI will treat as CSV and
        /// capture accordingly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> CsvContentTypes
        {
            get { return this._csvContentTypes; }
            set { this._csvContentTypes = value; }
        }

        // Check to see if CsvContentTypes property is set
        internal bool IsSetCsvContentTypes()
        {
            return this._csvContentTypes != null && (this._csvContentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JsonContentTypes. 
        /// <para>
        /// The list of all content type headers that SageMaker AI will treat as JSON and capture
        /// accordingly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> JsonContentTypes
        {
            get { return this._jsonContentTypes; }
            set { this._jsonContentTypes = value; }
        }

        // Check to see if JsonContentTypes property is set
        internal bool IsSetJsonContentTypes()
        {
            return this._jsonContentTypes != null && (this._jsonContentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}