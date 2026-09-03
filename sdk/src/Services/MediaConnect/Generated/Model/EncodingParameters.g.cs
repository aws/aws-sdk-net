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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A collection of parameters that determine how MediaConnect will convert the content.
    /// These fields only apply to outputs on flows that have a CDI source.
    /// </summary>
    public partial class EncodingParameters
    {
        /// <summary>
        /// Gets and sets the property CompressionFactor. 
        /// <para>
        ///  A value that is used to calculate compression for an output. The bitrate of the output
        /// is calculated as follows: Output bitrate = (1 / compressionFactor) * (source bitrate)
        /// This property only applies to outputs that use the ST 2110 JPEG XS protocol, with
        /// a flow source that uses the CDI protocol. Valid values are floating point numbers
        /// in the range of 3.0 to 10.0, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? CompressionFactor { get; set; }

        /// <summary>
        /// Checks to see if the CompressionFactor property is set.
        /// </summary>
        internal bool IsSetCompressionFactor() => this.CompressionFactor.HasValue;

        /// <summary>
        /// Gets and sets the property EncoderProfile. 
        /// <para>
        ///  A setting on the encoder that drives compression settings. This property only applies
        /// to video media streams associated with outputs that use the ST 2110 JPEG XS protocol,
        /// with a flow source that uses the CDI protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncoderProfile EncoderProfile { get; set; }

        /// <summary>
        /// Checks to see if the EncoderProfile property is set.
        /// </summary>
        internal bool IsSetEncoderProfile() => this.EncoderProfile != null;
    }
}
