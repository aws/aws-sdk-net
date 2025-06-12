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
    /// Container for the parameters to the CreateTransformer operation.
    /// Creates a transformer. Amazon Web Services B2B Data Interchange currently supports
    /// two scenarios:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>Inbound EDI</i>: the Amazon Web Services customer receives an EDI file from their
    /// trading partner. Amazon Web Services B2B Data Interchange converts this EDI file into
    /// a JSON or XML file with a service-defined structure. A mapping template provided by
    /// the customer, in JSONata or XSLT format, is optionally applied to this file to produce
    /// a JSON or XML file with the structure the customer requires.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Outbound EDI</i>: the Amazon Web Services customer has a JSON or XML file containing
    /// data that they wish to use in an EDI file. A mapping template, provided by the customer
    /// (in either JSONata or XSLT format) is applied to this file to generate a JSON or XML
    /// file in the service-defined structure. This file is then converted to an EDI file.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The following fields are provided for backwards compatibility only: <c>fileFormat</c>,
    /// <c>mappingTemplate</c>, <c>ediType</c>, and <c>sampleDocument</c>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <c>mapping</c> data type in place of <c>mappingTemplate</c> and <c>fileFormat</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <c>sampleDocuments</c> data type in place of <c>sampleDocument</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use either the <c>inputConversion</c> or <c>outputConversion</c> in place of <c>ediType</c>
    /// 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateTransformerRequest : AmazonB2biRequest
    {
        private string _clientToken;
        private EdiType _ediType;
        private FileFormat _fileFormat;
        private InputConversion _inputConversion;
        private Mapping _mapping;
        private string _mappingTemplate;
        private string _name;
        private OutputConversion _outputConversion;
        private string _sampleDocument;
        private SampleDocuments _sampleDocuments;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Specify the <c>InputConversion</c> object, which contains the format options for the
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
        /// Specifies the name of the transformer, used to identify it.
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
        /// A structure that contains the <c>OutputConversion</c> object, which contains the format
        /// options for the outbound transformation.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs assigned to ARNs that you can use to group and search
        /// for resources by type. You can attach this metadata to resources (capabilities, partnerships,
        /// and so on) for any purpose.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}