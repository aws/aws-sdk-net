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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Information about a model packaging job. For more information, see <a>DescribeModelPackagingJob</a>.
    /// </summary>
    public partial class ModelPackagingDescription
    {
        private DateTime? _creationTimestamp;
        private string _jobName;
        private DateTime? _lastUpdatedTimestamp;
        private ModelPackagingConfiguration _modelPackagingConfiguration;
        private string _modelPackagingJobDescription;
        private string _modelPackagingMethod;
        private ModelPackagingOutputDetails _modelPackagingOutputDetails;
        private string _modelVersion;
        private string _projectName;
        private ModelPackagingJobStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        ///  The Unix timestamp for the time and date that the model packaging job was created.
        /// 
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        ///  The name of the model packaging job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        ///  The Unix timestamp for the time and date that the model packaging job was last updated.
        /// 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelPackagingConfiguration. 
        /// <para>
        ///  The configuration information used in the model packaging job. 
        /// </para>
        /// </summary>
        public ModelPackagingConfiguration ModelPackagingConfiguration
        {
            get { return this._modelPackagingConfiguration; }
            set { this._modelPackagingConfiguration = value; }
        }

        // Check to see if ModelPackagingConfiguration property is set
        internal bool IsSetModelPackagingConfiguration()
        {
            return this._modelPackagingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackagingJobDescription. 
        /// <para>
        /// The description for the model packaging job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ModelPackagingJobDescription
        {
            get { return this._modelPackagingJobDescription; }
            set { this._modelPackagingJobDescription = value; }
        }

        // Check to see if ModelPackagingJobDescription property is set
        internal bool IsSetModelPackagingJobDescription()
        {
            return this._modelPackagingJobDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackagingMethod. 
        /// <para>
        /// The AWS service used to package the job. Currently Lookout for Vision can package
        /// jobs with AWS IoT Greengrass. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ModelPackagingMethod
        {
            get { return this._modelPackagingMethod; }
            set { this._modelPackagingMethod = value; }
        }

        // Check to see if ModelPackagingMethod property is set
        internal bool IsSetModelPackagingMethod()
        {
            return this._modelPackagingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackagingOutputDetails. 
        /// <para>
        /// Information about the output of the model packaging job. For more information, see
        /// <a>DescribeModelPackagingJob</a>. 
        /// </para>
        /// </summary>
        public ModelPackagingOutputDetails ModelPackagingOutputDetails
        {
            get { return this._modelPackagingOutputDetails; }
            set { this._modelPackagingOutputDetails = value; }
        }

        // Check to see if ModelPackagingOutputDetails property is set
        internal bool IsSetModelPackagingOutputDetails()
        {
            return this._modelPackagingOutputDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model used in the model packaging job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that's associated with a model that's in the model package.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the model packaging job. 
        /// </para>
        /// </summary>
        public ModelPackagingJobStatus Status
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
        ///  The status message for the model packaging job. 
        /// </para>
        /// </summary>
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

    }
}