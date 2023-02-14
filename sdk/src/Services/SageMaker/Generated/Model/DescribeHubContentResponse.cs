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
        private List<HubContentDependency> _hubContentDependencies = new List<HubContentDependency>();
        private string _hubContentDescription;
        private string _hubContentDisplayName;
        private string _hubContentDocument;
        private string _hubContentMarkdown;
        private string _hubContentName;
        private List<string> _hubContentSearchKeywords = new List<string>();
        private HubContentStatus _hubContentStatus;
        private HubContentType _hubContentType;
        private string _hubContentVersion;
        private string _hubName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that hub content was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        [AWSProperty(Max=1024)]
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
        [AWSProperty(Required=true, Max=255)]
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
        [AWSProperty(Required=true, Max=255)]
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
        /// </summary>
        [AWSProperty(Max=50)]
        public List<HubContentDependency> HubContentDependencies
        {
            get { return this._hubContentDependencies; }
            set { this._hubContentDependencies = value; }
        }

        // Check to see if HubContentDependencies property is set
        internal bool IsSetHubContentDependencies()
        {
            return this._hubContentDependencies != null && this._hubContentDependencies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HubContentDescription. 
        /// <para>
        /// A description of the hub content.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1023)]
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
        [AWSProperty(Max=255)]
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
        [AWSProperty(Required=true, Max=65535)]
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
        [AWSProperty(Max=65535)]
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
        [AWSProperty(Required=true, Max=63)]
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
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> HubContentSearchKeywords
        {
            get { return this._hubContentSearchKeywords; }
            set { this._hubContentSearchKeywords = value; }
        }

        // Check to see if HubContentSearchKeywords property is set
        internal bool IsSetHubContentSearchKeywords()
        {
            return this._hubContentSearchKeywords != null && this._hubContentSearchKeywords.Count > 0; 
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
        [AWSProperty(Required=true, Max=63)]
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

    }
}