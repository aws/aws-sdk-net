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
    /// Container for the parameters to the UpdateTransformer operation.
    /// Updates the specified parameters for a transformer. A transformer can take an EDI
    /// file as input and transform it into a JSON-or XML-formatted document. Alternatively,
    /// a transformer can take a JSON-or XML-formatted document as input and transform it
    /// into an EDI file.
    /// </summary>
    public partial class UpdateTransformerRequest : AmazonB2biRequest
    {
        private EdiType _ediType;
        private FileFormat _fileFormat;
        private InputConversion _inputConversion;
        private Mapping _mapping;
        private string _mappingTemplate;
        private string _name;
        private OutputConversion _outputConversion;
        private string _sampleDocument;
        private SampleDocuments _sampleDocuments;
        private TransformerStatus _status;
        private string _transformerId;

        /// <summary>
        /// Gets and sets the property EdiType. 
        /// <para>
        /// Specifies the details for the EDI standard that is being used for the transformer.
        /// Currently, only X12 is supported. X12 is a set of standards and corresponding messages
        /// that define specific business documents.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        public EdiType EdiType
        {
            get { return this._ediType; }
            set { this._ediType = value; }
        }

        // Check to see if EdiType property is set
        internal bool IsSetEdiType()
        {
            return this._ediType != null;
        }

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Specifies that the currently supported file formats for EDI transformations are <c>JSON</c>
        /// and <c>XML</c>.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        public FileFormat FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property InputConversion. 
        /// <para>
        /// To update, specify the <c>InputConversion</c> object, which contains the format options
        /// for the inbound transformation.
        /// </para>
        /// </summary>
        public InputConversion InputConversion
        {
            get { return this._inputConversion; }
            set { this._inputConversion = value; }
        }

        // Check to see if InputConversion property is set
        internal bool IsSetInputConversion()
        {
            return this._inputConversion != null;
        }

        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// Specify the structure that contains the mapping template and its language (either
        /// XSLT or JSONATA).
        /// </para>
        /// </summary>
        public Mapping Mapping
        {
            get { return this._mapping; }
            set { this._mapping = value; }
        }

        // Check to see if Mapping property is set
        internal bool IsSetMapping()
        {
            return this._mapping != null;
        }

        /// <summary>
        /// Gets and sets the property MappingTemplate. 
        /// <para>
        /// Specifies the mapping template for the transformer. This template is used to map the
        /// parsed EDI file using JSONata or XSLT.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is available for backwards compatibility. Use the <a href="https://docs.aws.amazon.com/b2bi/latest/APIReference/API_Mapping.html">Mapping</a>
        /// data type instead.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        [AWSProperty(Min=0, Max=350000)]
        public string MappingTemplate
        {
            get { return this._mappingTemplate; }
            set { this._mappingTemplate = value; }
        }

        // Check to see if MappingTemplate property is set
        internal bool IsSetMappingTemplate()
        {
            return this._mappingTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specify a new name for the transformer, if you want to update it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConversion. 
        /// <para>
        /// To update, specify the <c>OutputConversion</c> object, which contains the format options
        /// for the outbound transformation.
        /// </para>
        /// </summary>
        public OutputConversion OutputConversion
        {
            get { return this._outputConversion; }
            set { this._outputConversion = value; }
        }

        // Check to see if OutputConversion property is set
        internal bool IsSetOutputConversion()
        {
            return this._outputConversion != null;
        }

        /// <summary>
        /// Gets and sets the property SampleDocument. 
        /// <para>
        /// Specifies a sample EDI document that is used by a transformer as a guide for processing
        /// the EDI data.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        [AWSProperty(Min=0, Max=1024)]
        public string SampleDocument
        {
            get { return this._sampleDocument; }
            set { this._sampleDocument = value; }
        }

        // Check to see if SampleDocument property is set
        internal bool IsSetSampleDocument()
        {
            return this._sampleDocument != null;
        }

        /// <summary>
        /// Gets and sets the property SampleDocuments. 
        /// <para>
        /// Specify a structure that contains the Amazon S3 bucket and an array of the corresponding
        /// keys used to identify the location for your sample documents.
        /// </para>
        /// </summary>
        public SampleDocuments SampleDocuments
        {
            get { return this._sampleDocuments; }
            set { this._sampleDocuments = value; }
        }

        // Check to see if SampleDocuments property is set
        internal bool IsSetSampleDocuments()
        {
            return this._sampleDocuments != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the transformer's status. You can update the state of the transformer from
        /// <c>inactive</c> to <c>active</c>.
        /// </para>
        /// </summary>
        public TransformerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
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