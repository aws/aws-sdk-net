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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Specifies configuration information for the input data for the inference, including
    /// Amazon S3 location of input data..
    /// </summary>
    public partial class InferenceInputConfiguration
    {
        private InferenceInputNameConfiguration _inferenceInputNameConfiguration;
        private string _inputTimeZoneOffset;
        private InferenceS3InputConfiguration _s3InputConfiguration;

        /// <summary>
        /// Gets and sets the property InferenceInputNameConfiguration. 
        /// <para>
        /// Specifies configuration information for the input data for the inference, including
        /// timestamp format and delimiter. 
        /// </para>
        /// </summary>
        public InferenceInputNameConfiguration InferenceInputNameConfiguration
        {
            get { return this._inferenceInputNameConfiguration; }
            set { this._inferenceInputNameConfiguration = value; }
        }

        // Check to see if InferenceInputNameConfiguration property is set
        internal bool IsSetInferenceInputNameConfiguration()
        {
            return this._inferenceInputNameConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InputTimeZoneOffset. 
        /// <para>
        /// Indicates the difference between your time zone and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public string InputTimeZoneOffset
        {
            get { return this._inputTimeZoneOffset; }
            set { this._inputTimeZoneOffset = value; }
        }

        // Check to see if InputTimeZoneOffset property is set
        internal bool IsSetInputTimeZoneOffset()
        {
            return this._inputTimeZoneOffset != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputConfiguration. 
        /// <para>
        ///  Specifies configuration information for the input data for the inference, including
        /// Amazon S3 location of input data.
        /// </para>
        /// </summary>
        public InferenceS3InputConfiguration S3InputConfiguration
        {
            get { return this._s3InputConfiguration; }
            set { this._s3InputConfiguration = value; }
        }

        // Check to see if S3InputConfiguration property is set
        internal bool IsSetS3InputConfiguration()
        {
            return this._s3InputConfiguration != null;
        }

    }
}