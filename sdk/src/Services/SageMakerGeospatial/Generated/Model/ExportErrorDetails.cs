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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure for returning the export error details in a GetEarthObservationJob.
    /// </summary>
    public partial class ExportErrorDetails
    {
        private ExportErrorDetailsOutput _exportResults;
        private ExportErrorDetailsOutput _exportSourceImages;

        /// <summary>
        /// Gets and sets the property ExportResults.
        /// </summary>
        public ExportErrorDetailsOutput ExportResults
        {
            get { return this._exportResults; }
            set { this._exportResults = value; }
        }

        // Check to see if ExportResults property is set
        internal bool IsSetExportResults()
        {
            return this._exportResults != null;
        }

        /// <summary>
        /// Gets and sets the property ExportSourceImages.
        /// </summary>
        public ExportErrorDetailsOutput ExportSourceImages
        {
            get { return this._exportSourceImages; }
            set { this._exportSourceImages = value; }
        }

        // Check to see if ExportSourceImages property is set
        internal bool IsSetExportSourceImages()
        {
            return this._exportSourceImages != null;
        }

    }
}