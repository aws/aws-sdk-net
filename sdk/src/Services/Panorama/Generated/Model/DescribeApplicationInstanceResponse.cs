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
    /// This is the response object from the DescribeApplicationInstance operation.
    /// </summary>
    public partial class DescribeApplicationInstanceResponse : AmazonWebServiceResponse
    {
        private string _applicationInstanceId;
        private string _applicationInstanceIdToReplace;
        private string _arn;
        private DateTime? _createdTime;
        private string _defaultRuntimeContextDevice;
        private string _defaultRuntimeContextDeviceName;
        private string _description;
        private ApplicationInstanceHealthStatus _healthStatus;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private List<ReportedRuntimeContextState> _runtimeContextStates = AWSConfigs.InitializeCollections ? new List<ReportedRuntimeContextState>() : null;
        private string _runtimeRoleArn;
        private ApplicationInstanceStatus _status;
        private string _statusDescription;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationInstanceId. 
        /// <para>
        /// The application instance's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ApplicationInstanceId
        {
            get { return this._applicationInstanceId; }
            set { this._applicationInstanceId = value; }
        }

        // Check to see if ApplicationInstanceId property is set
        internal bool IsSetApplicationInstanceId()
        {
            return this._applicationInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationInstanceIdToReplace. 
        /// <para>
        /// The ID of the application instance that this instance replaced.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ApplicationInstanceIdToReplace
        {
            get { return this._applicationInstanceIdToReplace; }
            set { this._applicationInstanceIdToReplace = value; }
        }

        // Check to see if ApplicationInstanceIdToReplace property is set
        internal bool IsSetApplicationInstanceIdToReplace()
        {
            return this._applicationInstanceIdToReplace != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The application instance's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the application instance was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DefaultRuntimeContextDevice. 
        /// <para>
        /// The device's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DefaultRuntimeContextDevice
        {
            get { return this._defaultRuntimeContextDevice; }
            set { this._defaultRuntimeContextDevice = value; }
        }

        // Check to see if DefaultRuntimeContextDevice property is set
        internal bool IsSetDefaultRuntimeContextDevice()
        {
            return this._defaultRuntimeContextDevice != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRuntimeContextDeviceName. 
        /// <para>
        /// The device's bane.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DefaultRuntimeContextDeviceName
        {
            get { return this._defaultRuntimeContextDeviceName; }
            set { this._defaultRuntimeContextDeviceName = value; }
        }

        // Check to see if DefaultRuntimeContextDeviceName property is set
        internal bool IsSetDefaultRuntimeContextDeviceName()
        {
            return this._defaultRuntimeContextDeviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The application instance's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The application instance's health status.
        /// </para>
        /// </summary>
        public ApplicationInstanceHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The application instance was updated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The application instance's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property RuntimeContextStates. 
        /// <para>
        /// The application instance's state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReportedRuntimeContextState> RuntimeContextStates
        {
            get { return this._runtimeContextStates; }
            set { this._runtimeContextStates = value; }
        }

        // Check to see if RuntimeContextStates property is set
        internal bool IsSetRuntimeContextStates()
        {
            return this._runtimeContextStates != null && (this._runtimeContextStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuntimeRoleArn. 
        /// <para>
        /// The application instance's runtime role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RuntimeRoleArn
        {
            get { return this._runtimeRoleArn; }
            set { this._runtimeRoleArn = value; }
        }

        // Check to see if RuntimeRoleArn property is set
        internal bool IsSetRuntimeRoleArn()
        {
            return this._runtimeRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The application instance's status.
        /// </para>
        /// </summary>
        public ApplicationInstanceStatus Status
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
        /// Gets and sets the property StatusDescription. 
        /// <para>
        /// The application instance's status description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatusDescription
        {
            get { return this._statusDescription; }
            set { this._statusDescription = value; }
        }

        // Check to see if StatusDescription property is set
        internal bool IsSetStatusDescription()
        {
            return this._statusDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The application instance's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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