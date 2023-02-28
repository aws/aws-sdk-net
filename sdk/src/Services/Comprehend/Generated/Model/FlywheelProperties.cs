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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The flywheel properties.
    /// </summary>
    public partial class FlywheelProperties
    {
        private string _activeModelArn;
        private DateTime? _creationTime;
        private string _dataAccessRoleArn;
        private string _dataLakeS3Uri;
        private DataSecurityConfig _dataSecurityConfig;
        private string _flywheelArn;
        private DateTime? _lastModifiedTime;
        private string _latestFlywheelIteration;
        private string _message;
        private ModelType _modelType;
        private FlywheelStatus _status;
        private TaskConfig _taskConfig;

        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ActiveModelArn
        {
            get { return this._activeModelArn; }
            set { this._activeModelArn = value; }
        }

        // Check to see if ActiveModelArn property is set
        internal bool IsSetActiveModelArn()
        {
            return this._activeModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the flywheel.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend permission to access the flywheel data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataLakeS3Uri. 
        /// <para>
        /// Amazon S3 URI of the data lake location. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DataLakeS3Uri
        {
            get { return this._dataLakeS3Uri; }
            set { this._dataLakeS3Uri = value; }
        }

        // Check to see if DataLakeS3Uri property is set
        internal bool IsSetDataLakeS3Uri()
        {
            return this._dataLakeS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property DataSecurityConfig. 
        /// <para>
        /// Data security configuration.
        /// </para>
        /// </summary>
        public DataSecurityConfig DataSecurityConfig
        {
            get { return this._dataSecurityConfig; }
            set { this._dataSecurityConfig = value; }
        }

        // Check to see if DataSecurityConfig property is set
        internal bool IsSetDataSecurityConfig()
        {
            return this._dataSecurityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FlywheelArn
        {
            get { return this._flywheelArn; }
            set { this._flywheelArn = value; }
        }

        // Check to see if FlywheelArn property is set
        internal bool IsSetFlywheelArn()
        {
            return this._flywheelArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Last modified time for the flywheel.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestFlywheelIteration. 
        /// <para>
        /// The most recent flywheel iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string LatestFlywheelIteration
        {
            get { return this._latestFlywheelIteration; }
            set { this._latestFlywheelIteration = value; }
        }

        // Check to see if LatestFlywheelIteration property is set
        internal bool IsSetLatestFlywheelIteration()
        {
            return this._latestFlywheelIteration != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the status of the flywheel.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// Model type of the flywheel's model.
        /// </para>
        /// </summary>
        public ModelType ModelType
        {
            get { return this._modelType; }
            set { this._modelType = value; }
        }

        // Check to see if ModelType property is set
        internal bool IsSetModelType()
        {
            return this._modelType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the flywheel.
        /// </para>
        /// </summary>
        public FlywheelStatus Status
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
        /// Gets and sets the property TaskConfig. 
        /// <para>
        /// Configuration about the custom classifier associated with the flywheel.
        /// </para>
        /// </summary>
        public TaskConfig TaskConfig
        {
            get { return this._taskConfig; }
            set { this._taskConfig = value; }
        }

        // Check to see if TaskConfig property is set
        internal bool IsSetTaskConfig()
        {
            return this._taskConfig != null;
        }

    }
}