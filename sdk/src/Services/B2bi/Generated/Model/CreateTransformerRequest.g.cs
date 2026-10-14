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
    /// Container for the parameters to the CreateTransformer operation. Creates a transformer.
    /// Amazon Web Services B2B Data Interchange currently supports two scenarios: <ul> <li>
    /// <para> <i>Inbound EDI</i>: the Amazon Web Services customer receives an EDI file from
    /// their trading partner. Amazon Web Services B2B Data Interchange converts this EDI
    /// file into a JSON or XML file with a service-defined structure. A mapping template
    /// provided by the customer, in JSONata or XSLT format, is optionally applied to this
    /// file to produce a JSON or XML file with the structure the customer requires. </para>
    /// </li> <li> <para> <i>Outbound EDI</i>: the Amazon Web Services customer has a JSON
    /// or XML file containing data that they wish to use in an EDI file. A mapping template,
    /// provided by the customer (in either JSONata or XSLT format) is applied to this file
    /// to generate a JSON or XML file in the service-defined structure. This file is then
    /// converted to an EDI file. </para> </li> </ul> <note> <para> The following fields are
    /// provided for backwards compatibility only: <c>fileFormat</c>, <c>mappingTemplate</c>,
    /// <c>ediType</c>, and <c>sampleDocument</c>. </para> <ul> <li> <para> Use the <c>mapping</c>
    /// data type in place of <c>mappingTemplate</c> and <c>fileFormat</c> </para> </li> <li>
    /// <para> Use the <c>sampleDocuments</c> data type in place of <c>sampleDocument</c>
    /// </para> </li> <li> <para> Use either the <c>inputConversion</c> or <c>outputConversion</c>
    /// in place of <c>ediType</c> </para> </li> </ul> </note>
    /// </summary>
    public partial class CreateTransformerRequest : AmazonB2biRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EdiType. 
        /// <para>
        /// Specifies the details for the EDI standard that is being used for the transformer.
        /// Currently, only X12 is supported. X12 is a set of standards and corresponding messages
        /// that define specific business documents.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        public EdiType EdiType { get; set; }

        /// <summary>
        /// Checks to see if the EdiType property is set.
        /// </summary>
        internal bool IsSetEdiType() => this.EdiType != null;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Specifies that the currently supported file formats for EDI transformations are <c>JSON</c>
        /// and <c>XML</c>.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        public FileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property InputConversion. 
        /// <para>
        /// Specify the <c>InputConversion</c> object, which contains the format options for the
        /// inbound transformation.
        /// </para>
        /// </summary>
        public InputConversion InputConversion { get; set; }

        /// <summary>
        /// Checks to see if the InputConversion property is set.
        /// </summary>
        internal bool IsSetInputConversion() => this.InputConversion != null;

        /// <summary>
        /// Gets and sets the property Mapping. 
        /// <para>
        /// Specify the structure that contains the mapping template and its language (either
        /// XSLT or JSONATA).
        /// </para>
        /// </summary>
        public Mapping Mapping { get; set; }

        /// <summary>
        /// Checks to see if the Mapping property is set.
        /// </summary>
        internal bool IsSetMapping() => this.Mapping != null;

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
        [AWSProperty(Min = 0, Max = 350000)]
        public string MappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the MappingTemplate property is set.
        /// </summary>
        internal bool IsSetMappingTemplate() => this.MappingTemplate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the transformer, used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConversion. 
        /// <para>
        /// A structure that contains the <c>OutputConversion</c> object, which contains the format
        /// options for the outbound transformation.
        /// </para>
        /// </summary>
        public OutputConversion OutputConversion { get; set; }

        /// <summary>
        /// Checks to see if the OutputConversion property is set.
        /// </summary>
        internal bool IsSetOutputConversion() => this.OutputConversion != null;

        /// <summary>
        /// Gets and sets the property SampleDocument. 
        /// <para>
        /// Specifies a sample EDI document that is used by a transformer as a guide for processing
        /// the EDI data.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        [AWSProperty(Min = 0, Max = 1024)]
        public string SampleDocument { get; set; }

        /// <summary>
        /// Checks to see if the SampleDocument property is set.
        /// </summary>
        internal bool IsSetSampleDocument() => this.SampleDocument != null;

        /// <summary>
        /// Gets and sets the property SampleDocuments. 
        /// <para>
        /// Specify a structure that contains the Amazon S3 bucket and an array of the corresponding
        /// keys used to identify the location for your sample documents.
        /// </para>
        /// </summary>
        public SampleDocuments SampleDocuments { get; set; }

        /// <summary>
        /// Checks to see if the SampleDocuments property is set.
        /// </summary>
        internal bool IsSetSampleDocuments() => this.SampleDocuments != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs assigned to ARNs that you can use to group and search
        /// for resources by type. You can attach this metadata to resources (capabilities, partnerships,
        /// and so on) for any purpose.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
