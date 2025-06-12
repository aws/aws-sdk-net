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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeHubContent operation.
    /// </summary>
    public partial class DescribeHubContentResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _documentSchemaVersion;
        private string _failureReason;
        private string _hubArn;
        private string _hubContentArn;
        private List<HubContentDependency> _hubContentDependencies = AWSConfigs.InitializeCollections ? new List<HubContentDependency>() : null;
        private string _hubContentDescription;
        private string _hubContentDisplayName;
        private string _hubContentDocument;
        private string _hubContentMarkdown;
        private string _hubContentName;
        private List<string> _hubContentSearchKeywords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HubContentStatus _hubContentStatus;
        private HubContentType _hubContentType;
        private string _hubContentVersion;
        private string _hubName;
        private DateTime? _lastModifiedTime;
        private string _referenceMinVersion;
        private string _sageMakerPublicHubContentArn;
        private HubContentSupportStatus _supportStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that hub content was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentSchemaVersion. 
        /// <para>
        /// The document schema version for the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=14)]
        public string DocumentSchemaVersion
        {
            get { return this._documentSchemaVersion; }
            set { this._documentSchemaVersion = value; }
        }

        // Check to see if DocumentSchemaVersion property is set
        internal bool IsSetDocumentSchemaVersion()
        {
            return this._documentSchemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason if importing hub content failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hub that contains the content. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string HubArn
        {
            get { return this._hubArn; }
            set { this._hubArn = value; }
        }

        // Check to see if HubArn property is set
        internal bool IsSetHubArn()
        {
            return this._hubArn != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string HubContentArn
        {
            get { return this._hubContentArn; }
            set { this._hubContentArn = value; }
        }

        // Check to see if HubContentArn property is set
        internal bool IsSetHubContentArn()
        {
            return this._hubContentArn != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentDependencies. 
        /// <para>
        /// The location of any dependencies that the hub content has, such as scripts, model
        /// artifacts, datasets, or notebooks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<HubContentDependency> HubContentDependencies
        {
            get { return this._hubContentDependencies; }
            set { this._hubContentDependencies = value; }
        }

        // Check to see if HubContentDependencies property is set
        internal bool IsSetHubContentDependencies()
        {
            return this._hubContentDependencies != null && (this._hubContentDependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HubContentDescription. 
        /// <para>
        /// A description of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1023)]
        public string HubContentDescription
        {
            get { return this._hubContentDescription; }
            set { this._hubContentDescription = value; }
        }

        // Check to see if HubContentDescription property is set
        internal bool IsSetHubContentDescription()
        {
            return this._hubContentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentDisplayName. 
        /// <para>
        /// The display name of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string HubContentDisplayName
        {
            get { return this._hubContentDisplayName; }
            set { this._hubContentDisplayName = value; }
        }

        // Check to see if HubContentDisplayName property is set
        internal bool IsSetHubContentDisplayName()
        {
            return this._hubContentDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentDocument. 
        /// <para>
        /// The hub content document that describes information about the hub content such as
        /// type, associated containers, scripts, and more.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public string HubContentDocument
        {
            get { return this._hubContentDocument; }
            set { this._hubContentDocument = value; }
        }

        // Check to see if HubContentDocument property is set
        internal bool IsSetHubContentDocument()
        {
            return this._hubContentDocument != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentMarkdown. 
        /// <para>
        /// A string that provides a description of the hub content. This string can include links,
        /// tables, and standard markdown formating.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public string HubContentMarkdown
        {
            get { return this._hubContentMarkdown; }
            set { this._hubContentMarkdown = value; }
        }

        // Check to see if HubContentMarkdown property is set
        internal bool IsSetHubContentMarkdown()
        {
            return this._hubContentMarkdown != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string HubContentName
        {
            get { return this._hubContentName; }
            set { this._hubContentName = value; }
        }

        // Check to see if HubContentName property is set
        internal bool IsSetHubContentName()
        {
            return this._hubContentName != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentSearchKeywords. 
        /// <para>
        /// The searchable keywords for the hub content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> HubContentSearchKeywords
        {
            get { return this._hubContentSearchKeywords; }
            set { this._hubContentSearchKeywords = value; }
        }

        // Check to see if HubContentSearchKeywords property is set
        internal bool IsSetHubContentSearchKeywords()
        {
            return this._hubContentSearchKeywords != null && (this._hubContentSearchKeywords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HubContentStatus. 
        /// <para>
        /// The status of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HubContentStatus HubContentStatus
        {
            get { return this._hubContentStatus; }
            set { this._hubContentStatus = value; }
        }

        // Check to see if HubContentStatus property is set
        internal bool IsSetHubContentStatus()
        {
            return this._hubContentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The type of hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HubContentType HubContentType
        {
            get { return this._hubContentType; }
            set { this._hubContentType = value; }
        }

        // Check to see if HubContentType property is set
        internal bool IsSetHubContentType()
        {
            return this._hubContentType != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        /// The version of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=14)]
        public string HubContentVersion
        {
            get { return this._hubContentVersion; }
            set { this._hubContentVersion = value; }
        }

        // Check to see if HubContentVersion property is set
        internal bool IsSetHubContentVersion()
        {
            return this._hubContentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub that contains the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }

        // Check to see if HubName property is set
        internal bool IsSetHubName()
        {
            return this._hubName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time of the hub content.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceMinVersion. 
        /// <para>
        /// The minimum version of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=14)]
        public string ReferenceMinVersion
        {
            get { return this._referenceMinVersion; }
            set { this._referenceMinVersion = value; }
        }

        // Check to see if ReferenceMinVersion property is set
        internal bool IsSetReferenceMinVersion()
        {
            return this._referenceMinVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerPublicHubContentArn. 
        /// <para>
        /// The ARN of the public hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SageMakerPublicHubContentArn
        {
            get { return this._sageMakerPublicHubContentArn; }
            set { this._sageMakerPublicHubContentArn = value; }
        }

        // Check to see if SageMakerPublicHubContentArn property is set
        internal bool IsSetSageMakerPublicHubContentArn()
        {
            return this._sageMakerPublicHubContentArn != null;
        }

        /// <summary>
        /// Gets and sets the property SupportStatus. 
        /// <para>
        /// The support status of the hub content.
        /// </para>
        /// </summary>
        public HubContentSupportStatus SupportStatus
        {
            get { return this._supportStatus; }
            set { this._supportStatus = value; }
        }

        // Check to see if SupportStatus property is set
        internal bool IsSetSupportStatus()
        {
            return this._supportStatus != null;
        }

    }
}