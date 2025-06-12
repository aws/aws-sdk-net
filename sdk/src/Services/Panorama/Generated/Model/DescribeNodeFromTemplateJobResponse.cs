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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// This is the response object from the DescribeNodeFromTemplateJob operation.
    /// </summary>
    public partial class DescribeNodeFromTemplateJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTime;
        private string _jobId;
        private List<JobResourceTags> _jobTags = AWSConfigs.InitializeCollections ? new List<JobResourceTags>() : null;
        private DateTime? _lastUpdatedTime;
        private string _nodeDescription;
        private string _nodeName;
        private string _outputPackageName;
        private string _outputPackageVersion;
        private NodeFromTemplateJobStatus _status;
        private string _statusMessage;
        private Dictionary<string, string> _templateParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TemplateType _templateType;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobTags. 
        /// <para>
        /// The job's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobResourceTags> JobTags
        {
            get { return this._jobTags; }
            set { this._jobTags = value; }
        }

        // Check to see if JobTags property is set
        internal bool IsSetJobTags()
        {
            return this._jobTags != null && (this._jobTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// When the job was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeDescription. 
        /// <para>
        /// The node's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string NodeDescription
        {
            get { return this._nodeDescription; }
            set { this._nodeDescription = value; }
        }

        // Check to see if NodeDescription property is set
        internal bool IsSetNodeDescription()
        {
            return this._nodeDescription != null;
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The node's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputPackageName. 
        /// <para>
        /// The job's output package name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OutputPackageName
        {
            get { return this._outputPackageName; }
            set { this._outputPackageName = value; }
        }

        // Check to see if OutputPackageName property is set
        internal bool IsSetOutputPackageName()
        {
            return this._outputPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputPackageVersion. 
        /// <para>
        /// The job's output package version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string OutputPackageVersion
        {
            get { return this._outputPackageVersion; }
            set { this._outputPackageVersion = value; }
        }

        // Check to see if OutputPackageVersion property is set
        internal bool IsSetOutputPackageVersion()
        {
            return this._outputPackageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The job's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeFromTemplateJobStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The job's status message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateParameters. 
        /// <para>
        /// The job's template parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> TemplateParameters
        {
            get { return this._templateParameters; }
            set { this._templateParameters = value; }
        }

        // Check to see if TemplateParameters property is set
        internal bool IsSetTemplateParameters()
        {
            return this._templateParameters != null && (this._templateParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The job's template type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateType TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}