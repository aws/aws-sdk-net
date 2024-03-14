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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains the details for a transformer object. A transformer describes how to process
    /// the incoming EDI documents and extract the necessary information to the output file.
    /// </summary>
    public partial class TransformerSummary
    {
        private DateTime? _createdAt;
        private EdiType _ediType;
        private FileFormat _fileFormat;
        private string _mappingTemplate;
        private DateTime? _modifiedAt;
        private string _name;
        private string _sampleDocument;
        private TransformerStatus _status;
        private string _transformerId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp indicating when the transformer was created. For example, <c>2023-07-20T19:58:44.624Z</c>.
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MappingTemplate. 
        /// <para>
        /// Returns the name of the mapping template for the transformer. This template is used
        /// to convert the input document into the correct set of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=350000)]
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
        /// Returns a timestamp representing the date and time for the most recent change for
        /// the transformer object.
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
        /// Returns the descriptive name for the transformer.
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
        /// Gets and sets the property SampleDocument. 
        /// <para>
        /// Returns a sample EDI document that is used by a transformer as a guide for processing
        /// the EDI data.
        /// </para>
        /// </summary>
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