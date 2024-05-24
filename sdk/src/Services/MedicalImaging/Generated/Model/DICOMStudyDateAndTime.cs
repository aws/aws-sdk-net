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
    /// The aggregated structure to store DICOM study date and study time for search capabilities.
    /// </summary>
    public partial class DICOMStudyDateAndTime
    {
        private string _dicomStudyDate;
        private string _dicomStudyTime;

        /// <summary>
        /// Gets and sets the property DICOMStudyDate. 
        /// <para>
        /// The DICOM study date provided in <c>yyMMdd</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=18)]
        public string DICOMStudyDate
        {
            get { return this._dicomStudyDate; }
            set { this._dicomStudyDate = value; }
        }

        // Check to see if DICOMStudyDate property is set
        internal bool IsSetDICOMStudyDate()
        {
            return this._dicomStudyDate != null;
        }

        /// <summary>
        /// Gets and sets the property DICOMStudyTime. 
        /// <para>
        /// The DICOM study time provided in <c>HHmmss.FFFFFF</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=28)]
        public string DICOMStudyTime
        {
            get { return this._dicomStudyTime; }
            set { this._dicomStudyTime = value; }
        }

        // Check to see if DICOMStudyTime property is set
        internal bool IsSetDICOMStudyTime()
        {
            return this._dicomStudyTime != null;
        }

    }
}