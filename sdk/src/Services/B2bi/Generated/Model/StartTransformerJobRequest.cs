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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
    /// Container for the parameters to the StartTransformerJob operation.
    /// Runs a job, using a transformer, to parse input EDI (electronic data interchange)
    /// file into the output structures used by Amazon Web Services B2B Data Interchange.
    /// 
    ///  
    /// <para>
    /// If you only want to transform EDI (electronic data interchange) documents, you don't
    /// need to create profiles, partnerships or capabilities. Just create and configure a
    /// transformer, and then run the <c>StartTransformerJob</c> API to process your files.
    /// </para>
    ///  <note> 
    /// <para>
    /// The system stores transformer jobs for 30 days. During that period, you can run <a
    /// href="https://docs.aws.amazon.com/b2bi/latest/APIReference/API_GetTransformerJob.html">GetTransformerJob</a>
    /// and supply its <c>transformerId</c> and <c>transformerJobId</c> to return details
    /// of the job.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartTransformerJobRequest : AmazonB2biRequest
    {
        private string _clientToken;
        private S3Location _inputFile;
        private S3Location _outputLocation;
        private string _transformerId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InputFile. 
        /// <para>
        /// Specifies the location of the input file for the transformation. The location consists
        /// of an Amazon S3 bucket and prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location InputFile
        {
            get { return this._inputFile; }
            set { this._inputFile = value; }
        }

        // Check to see if InputFile property is set
        internal bool IsSetInputFile()
        {
            return this._inputFile != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Specifies the location of the output file for the transformation. The location consists
        /// of an Amazon S3 bucket and prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TransformerId. 
        /// <para>
        /// Specifies the system-assigned unique identifier for the transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TransformerId
        {
            get { return this._transformerId; }
            set { this._transformerId = value; }
        }

        // Check to see if TransformerId property is set
        internal bool IsSetTransformerId()
        {
            return this._transformerId != null;
        }

    }
}