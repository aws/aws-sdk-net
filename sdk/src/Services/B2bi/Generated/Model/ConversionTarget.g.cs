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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Provide a sample of what the output of the transformation should look like.
    /// </summary>
    public partial class ConversionTarget
    {
        /// <summary>
        /// Gets and sets the property AdvancedOptions.
        /// </summary>
        public AdvancedOptions AdvancedOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedOptions() => this.AdvancedOptions != null;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Currently, only X12 format is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConversionTargetFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property FormatDetails. 
        /// <para>
        /// A structure that contains the formatting details for the conversion target.
        /// </para>
        /// </summary>
        public ConversionTargetFormatDetails FormatDetails { get; set; }

        /// <summary>
        /// Checks to see if the FormatDetails property is set.
        /// </summary>
        internal bool IsSetFormatDetails() => this.FormatDetails != null;

        /// <summary>
        /// Gets and sets the property OutputSampleFile. Customer uses this to provide a sample
        /// on what should file look like after conversion X12 EDI use case around this would
        /// be discovering the file syntax
        /// </summary>
        public OutputSampleFileSource OutputSampleFile { get; set; }

        /// <summary>
        /// Checks to see if the OutputSampleFile property is set.
        /// </summary>
        internal bool IsSetOutputSampleFile() => this.OutputSampleFile != null;
    }
}
