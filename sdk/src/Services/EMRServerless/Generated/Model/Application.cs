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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Information about an application. EMR Serverless uses applications to run jobs.
    /// </summary>
    public partial class Application
    {
        private string _applicationId;
        private Architecture _architecture;
        private string _arn;
        private AutoStartConfig _autoStartConfiguration;
        private AutoStopConfig _autoStopConfiguration;
        private DateTime? _createdAt;
        private ImageConfiguration _imageConfiguration;
        private Dictionary<string, InitialCapacityConfig> _initialCapacity = new Dictionary<string, InitialCapacityConfig>();
        private MaximumAllowedResources _maximumCapacity;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private string _releaseLabel;
        private ApplicationState _state;
        private string _stateDetails;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _type;
        private DateTime? _updatedAt;
        private Dictionary<string, WorkerTypeSpecification> _workerTypeSpecifications = new Dictionary<string, WorkerTypeSpecification>();

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture of an application.
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoStartConfiguration. 
        /// <para>
        /// The configuration for an application to automatically start on job submission.
        /// </para>
        /// </summary>
        public AutoStartConfig AutoStartConfiguration
        {
            get { return this._autoStartConfiguration; }
            set { this._autoStartConfiguration = value; }
        }

        // Check to see if AutoStartConfiguration property is set
        internal bool IsSetAutoStartConfiguration()
        {
            return this._autoStartConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoStopConfiguration. 
        /// <para>
        /// The configuration for an application to automatically stop after a certain amount
        /// of time being idle.
        /// </para>
        /// </summary>
        public AutoStopConfig AutoStopConfiguration
        {
            get { return this._autoStopConfiguration; }
            set { this._autoStopConfiguration = value; }
        }

        // Check to see if AutoStopConfiguration property is set
        internal bool IsSetAutoStopConfiguration()
        {
            return this._autoStopConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the application run was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// The image configuration applied to all worker types.
        /// </para>
        /// </summary>
        public ImageConfiguration ImageConfiguration
        {
            get { return this._imageConfiguration; }
            set { this._imageConfiguration = value; }
        }

        // Check to see if ImageConfiguration property is set
        internal bool IsSetImageConfiguration()
        {
            return this._imageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InitialCapacity. 
        /// <para>
        /// The initial capacity of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, InitialCapacityConfig> InitialCapacity
        {
            get { return this._initialCapacity; }
            set { this._initialCapacity = value; }
        }

        // Check to see if InitialCapacity property is set
        internal bool IsSetInitialCapacity()
        {
            return this._initialCapacity != null && this._initialCapacity.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumCapacity. 
        /// <para>
        /// The maximum capacity of the application. This is cumulative across all workers at
        /// any given point in time during the lifespan of the application is created. No new
        /// resources will be created once any one of the defined limits is hit.
        /// </para>
        /// </summary>
        public MaximumAllowedResources MaximumCapacity
        {
            get { return this._maximumCapacity; }
            set { this._maximumCapacity = value; }
        }

        // Check to see if MaximumCapacity property is set
        internal bool IsSetMaximumCapacity()
        {
            return this._maximumCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for customer VPC connectivity for the application.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The EMR release associated with the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationState State
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
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of application, such as Spark or Hive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the application run was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkerTypeSpecifications. 
        /// <para>
        /// The specification applied to each worker type.
        /// </para>
        /// </summary>
        public Dictionary<string, WorkerTypeSpecification> WorkerTypeSpecifications
        {
            get { return this._workerTypeSpecifications; }
            set { this._workerTypeSpecifications = value; }
        }

        // Check to see if WorkerTypeSpecifications property is set
        internal bool IsSetWorkerTypeSpecifications()
        {
            return this._workerTypeSpecifications != null && this._workerTypeSpecifications.Count > 0; 
        }

    }
}