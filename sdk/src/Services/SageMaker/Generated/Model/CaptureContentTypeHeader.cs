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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CaptureContentTypeHeader
    {
        private List<string> _csvContentTypes = new List<string>();
        private List<string> _jsonContentTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property CsvContentTypes.
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
            return this._csvContentTypes != null && this._csvContentTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JsonContentTypes.
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
            return this._jsonContentTypes != null && this._jsonContentTypes.Count > 0; 
        }

    }
}