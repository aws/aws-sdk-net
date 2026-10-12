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
    /// Container for the parameters to the UpdateTransformer operation. Updates the specified
    /// parameters for a transformer. A transformer can take an EDI file as input and transform
    /// it into a JSON-or XML-formatted document. Alternatively, a transformer can take a
    /// JSON-or XML-formatted document as input and transform it into an EDI file.
    /// </summary>
    public partial class UpdateTransformerRequest : AmazonB2biRequest
    {
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
        /// To update, specify the <c>InputConversion</c> object, which contains the format options
        /// for the inbound transformation.
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
        /// Specify a new name for the transformer, if you want to update it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConversion. 
        /// <para>
        /// To update, specify the <c>OutputConversion</c> object, which contains the format options
        /// for the outbound transformation.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the transformer's status. You can update the state of the transformer from
        /// <c>inactive</c> to <c>active</c>.
        /// </para>
        /// </summary>
        public TransformerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TransformerId. 
        /// <para>
        /// Specifies the system-assigned unique identifier for the transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TransformerId { get; set; }

        /// <summary>
        /// Checks to see if the TransformerId property is set.
        /// </summary>
        internal bool IsSetTransformerId() => this.TransformerId != null;
    }
}
