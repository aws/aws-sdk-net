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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Information about an export image task, including its current state, timestamps, and
    /// any error details.
    /// </summary>
    public partial class ExportImageTask
    {
        private string _amiDescription;
        private string _amiId;
        private string _amiName;
        private DateTime? _createdDate;
        private List<ErrorDetails> _errorDetails = AWSConfigs.InitializeCollections ? new List<ErrorDetails>() : null;
        private string _imageArn;
        private ExportImageTaskState _state;
        private Dictionary<string, string> _tagSpecifications = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property AmiDescription. 
        /// <para>
        /// The description that will be applied to the exported EC2 AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AmiDescription
        {
            get { return this._amiDescription; }
            set { this._amiDescription = value; }
        }

        // Check to see if AmiDescription property is set
        internal bool IsSetAmiDescription()
        {
            return this._amiDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the EC2 AMI that was created by this export task. This field is only populated
        /// when the task completes successfully.
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property AmiName. 
        /// <para>
        /// The name of the EC2 AMI that will be created by this export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AmiName
        {
            get { return this._amiName; }
            set { this._amiName = value; }
        }

        // Check to see if AmiName property is set
        internal bool IsSetAmiName()
        {
            return this._amiName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the export image task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about any errors that occurred during the export process. This field is only
        /// populated when the task fails.
        /// </para>
        /// </summary>
        public List<ErrorDetails> ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null && (this._errorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the WorkSpaces Applications image being exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the export image task, such as PENDING, RUNNING, COMPLETED, or
        /// FAILED.
        /// </para>
        /// </summary>
        public ExportImageTaskState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags that will be applied to the exported EC2 AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier for the export image task. Use this ID to track the task's progress
        /// and retrieve its details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}