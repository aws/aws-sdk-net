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
    /// This is the response object from the GetTransformer operation.
    /// </summary>
    public partial class GetTransformerResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private EdiType _ediType;
        private FileFormat _fileFormat;
        private InputConversion _inputConversion;
        private Mapping _mapping;
        private string _mappingTemplate;
        private DateTime? _modifiedAt;
        private string _name;
        private OutputConversion _outputConversion;
        private string _sampleDocument;
        private SampleDocuments _sampleDocuments;
        private TransformerStatus _status;
        private string _transformerArn;
        private string _transformerId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp for creation date and time of the transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdiType. 
        /// <para>
        /// Returns the details for the EDI standard that is being used for the transformer. Currently,
        /// only X12 is supported. X12 is a set of standards and corresponding messages that define
        /// specific business documents.
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
        /// Returns that the currently supported file formats for EDI transformations are <c>JSON</c>
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
        /// Returns the <c>InputConversion</c> object, which contains the format options for the
        /// inbound transformation.
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
        /// Returns the structure that contains the mapping template and its language (either
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
        /// Returns the mapping template for the transformer. This template is used to map the
        /// parsed EDI file using JSONata or XSLT.
        /// </para>
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// Returns a timestamp for last time the transformer was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Returns the name of the transformer, used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=254)]
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
        /// Returns the <c>OutputConversion</c> object, which contains the format options for
        /// the outbound transformation.
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
        /// Returns a sample EDI document that is used by a transformer as a guide for processing
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
        /// Returns a structure that contains the Amazon S3 bucket and an array of the corresponding
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
        /// Returns the state of the newly created transformer. The transformer can be either
        /// <c>active</c> or <c>inactive</c>. For the transformer to be used in a capability,
        /// its status must <c>active</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TransformerArn. 
        /// <para>
        /// Returns an Amazon Resource Name (ARN) for a specific Amazon Web Services resource,
        /// such as a capability, partnership, profile, or transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TransformerArn
        {
            get { return this._transformerArn; }
            set { this._transformerArn = value; }
        }

        // Check to see if TransformerArn property is set
        internal bool IsSetTransformerArn()
        {
            return this._transformerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TransformerId. 
        /// <para>
        /// Returns the system-assigned unique identifier for the transformer.
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