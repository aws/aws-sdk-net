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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Maps DCM files to their metadata.
    /// </summary>
    public partial class DicomMetadataMapping
    {
        private string _metadataFilePath;
        private string _seriesInstanceUID;
        private string _studyInstanceUID;

        /// <summary>
        /// Gets and sets the property MetadataFilePath. 
        /// <para>
        /// The path to the JSON metadata file relative to inputS3Uri.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string MetadataFilePath
        {
            get { return this._metadataFilePath; }
            set { this._metadataFilePath = value; }
        }

        // Check to see if MetadataFilePath property is set
        internal bool IsSetMetadataFilePath()
        {
            return this._metadataFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property SeriesInstanceUID. 
        /// <para>
        /// The Series Instance UID that identifies the series. This parameter is optional because
        /// the mapping might be at the study level.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=512)]
        public string SeriesInstanceUID
        {
            get { return this._seriesInstanceUID; }
            set { this._seriesInstanceUID = value; }
        }

        // Check to see if SeriesInstanceUID property is set
        internal bool IsSetSeriesInstanceUID()
        {
            return this._seriesInstanceUID != null;
        }

        /// <summary>
        /// Gets and sets the property StudyInstanceUID. 
        /// <para>
        /// The Study Instance UID that identifies the study.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=512)]
        public string StudyInstanceUID
        {
            get { return this._studyInstanceUID; }
            set { this._studyInstanceUID = value; }
        }

        // Check to see if StudyInstanceUID property is set
        internal bool IsSetStudyInstanceUID()
        {
            return this._studyInstanceUID != null;
        }

    }
}