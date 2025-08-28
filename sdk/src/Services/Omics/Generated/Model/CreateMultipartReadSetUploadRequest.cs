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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMultipartReadSetUpload operation.
    /// Initiates a multipart read set upload for uploading partitioned source files into
    /// a sequence store. You can directly import source files from an EC2 instance and other
    /// local compute, or from an S3 bucket. To separate these source files into parts, use
    /// the <c>split</c> operation. Each part cannot be larger than 100 MB. If the operation
    /// is successful, it provides an <c>uploadId</c> which is required by the <c>UploadReadSetPart</c>
    /// API operation to upload parts into a sequence store.
    /// 
    ///  
    /// <para>
    /// To continue uploading a multipart read set into your sequence store, you must use
    /// the <c>UploadReadSetPart</c> API operation to upload each part individually following
    /// the steps below:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the <c>uploadId</c> obtained from the previous call to <c>CreateMultipartReadSetUpload</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Upload parts for that <c>uploadId</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you have finished uploading parts, use the <c>CompleteMultipartReadSetUpload</c>
    /// API to complete the multipart read set upload and to retrieve the final read set IDs
    /// in the response.
    /// </para>
    ///  
    /// <para>
    /// To learn more about creating parts and the <c>split</c> operation, see <a href="https://docs.aws.amazon.com/omics/latest/dev/synchronous-uploads.html">Direct
    /// upload to a sequence store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateMultipartReadSetUploadRequest : AmazonOmicsRequest
    {
        private string _clientToken;
        private string _description;
        private string _generatedFrom;
        private string _name;
        private string _referenceArn;
        private string _sampleId;
        private string _sequenceStoreId;
        private FileType _sourceFileType;
        private string _subjectId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token that can be used to avoid triggering multiple multipart uploads.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the read set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        /// Where the source originated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string GeneratedFrom
        {
            get { return this._generatedFrom; }
            set { this._generatedFrom = value; }
        }

        // Check to see if GeneratedFrom property is set
        internal bool IsSetGeneratedFrom()
        {
            return this._generatedFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the read set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
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
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        /// The ARN of the reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ReferenceArn
        {
            get { return this._referenceArn; }
            set { this._referenceArn = value; }
        }

        // Check to see if ReferenceArn property is set
        internal bool IsSetReferenceArn()
        {
            return this._referenceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SampleId. 
        /// <para>
        /// The source's sample ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string SampleId
        {
            get { return this._sampleId; }
            set { this._sampleId = value; }
        }

        // Check to see if SampleId property is set
        internal bool IsSetSampleId()
        {
            return this._sampleId != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The sequence store ID for the store that is the destination of the multipart uploads.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string SequenceStoreId
        {
            get { return this._sequenceStoreId; }
            set { this._sequenceStoreId = value; }
        }

        // Check to see if SequenceStoreId property is set
        internal bool IsSetSequenceStoreId()
        {
            return this._sequenceStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileType. 
        /// <para>
        /// The type of file being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileType SourceFileType
        {
            get { return this._sourceFileType; }
            set { this._sourceFileType = value; }
        }

        // Check to see if SourceFileType property is set
        internal bool IsSetSourceFileType()
        {
            return this._sourceFileType != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The source's subject ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string SubjectId
        {
            get { return this._subjectId; }
            set { this._subjectId = value; }
        }

        // Check to see if SubjectId property is set
        internal bool IsSetSubjectId()
        {
            return this._subjectId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags to add to the read set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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