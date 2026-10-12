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
    /// This is the response object from the UpdateTransformer operation.
    /// </summary>
    public partial class UpdateTransformerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp for creation date and time of the transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EdiType. 
        /// <para>
        /// Returns the details for the EDI standard that is being used for the transformer. Currently,
        /// only X12 is supported. X12 is a set of standards and corresponding messages that define
        /// specific business documents.
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
        /// Returns that the currently supported file formats for EDI transformations are <c>JSON</c>
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
        /// Returns the <c>InputConversion</c> object, which contains the format options for the
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
        /// Returns the structure that contains the mapping template and its language (either
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
        /// Returns the mapping template for the transformer. This template is used to map the
        /// parsed EDI file using JSONata or XSLT.
        /// </para>
        /// </summary>
        [Obsolete("This is a legacy trait. Please use input-conversion or output-conversion.")]
        [AWSProperty(Min = 0, Max = 350000)]
        public string MappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the MappingTemplate property is set.
        /// </summary>
        internal bool IsSetMappingTemplate() => this.MappingTemplate != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// Returns a timestamp for last time the transformer was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Returns the name of the transformer.
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
        /// Returns the <c>OutputConversion</c> object, which contains the format options for
        /// the outbound transformation.
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
        /// Returns a sample EDI document that is used by a transformer as a guide for processing
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
        /// Returns a structure that contains the Amazon S3 bucket and an array of the corresponding
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
        /// Returns the state of the newly created transformer. The transformer can be either
        /// <c>active</c> or <c>inactive</c>. For the transformer to be used in a capability,
        /// its status must <c>active</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TransformerArn. 
        /// <para>
        /// Returns an Amazon Resource Name (ARN) for a specific Amazon Web Services resource,
        /// such as a capability, partnership, profile, or transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TransformerArn { get; set; }

        /// <summary>
        /// Checks to see if the TransformerArn property is set.
        /// </summary>
        internal bool IsSetTransformerArn() => this.TransformerArn != null;

        /// <summary>
        /// Gets and sets the property TransformerId. 
        /// <para>
        /// Returns the system-assigned unique identifier for the transformer.
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
