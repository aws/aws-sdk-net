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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Controls detection and redaction of sensitive data, such as personally identifiable
    /// information (PII), in the output.
    /// </summary>
    public partial class SensitiveDataConfiguration
    {
        /// <summary>
        /// Gets and sets the property DetectionMode. 
        /// <para>
        /// The detection mode. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DETECTION</c> - Only detects sensitive data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DETECTION_AND_REDACTION</c> - Detects and redacts sensitive data in the output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - Does not detect sensitive data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SensitiveDataDetectionMode DetectionMode { get; set; }

        /// <summary>
        /// Checks to see if the DetectionMode property is set.
        /// </summary>
        internal bool IsSetDetectionMode() => this.DetectionMode != null;

        /// <summary>
        /// Gets and sets the property PiiEntitiesConfiguration. 
        /// <para>
        /// The configuration that specifies which PII entity types to detect and how to mask
        /// them. If you omit it, Amazon Textract detects all PII entity types (<c>ALL</c>) and
        /// masks them with <c>ENTITY_TYPE</c>.
        /// </para>
        /// </summary>
        public PIIEntitiesConfiguration PiiEntitiesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PiiEntitiesConfiguration property is set.
        /// </summary>
        internal bool IsSetPiiEntitiesConfiguration() => this.PiiEntitiesConfiguration != null;
    }
}
