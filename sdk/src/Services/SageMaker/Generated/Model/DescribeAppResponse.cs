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
    /// This is the response object from the DescribeApp operation.
    /// </summary>
    public partial class DescribeAppResponse : AmazonWebServiceResponse
    {
        private string _appArn;
        private string _appName;
        private AppType _appType;
        private DateTime? _creationTime;
        private string _domainId;
        private string _failureReason;
        private DateTime? _lastHealthCheckTimestamp;
        private DateTime? _lastUserActivityTimestamp;
        private ResourceSpec _resourceSpec;
        private string _spaceName;
        private AppStatus _status;
        private string _userProfileName;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string AppName
        {
            get { return this._appName; }
            set { this._appName = value; }
        }

        // Check to see if AppName property is set
        internal bool IsSetAppName()
        {
            return this._appName != null;
        }

        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        /// The type of app.
        /// </para>
        /// </summary>
        public AppType AppType
        {
            get { return this._appType; }
            set { this._appType = value; }
        }

        // Check to see if AppType property is set
        internal bool IsSetAppType()
        {
            return this._appType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
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
        /// Gets and sets the property LastHealthCheckTimestamp. 
        /// <para>
        /// The timestamp of the last health check.
        /// </para>
        /// </summary>
        public DateTime LastHealthCheckTimestamp
        {
            get { return this._lastHealthCheckTimestamp.GetValueOrDefault(); }
            set { this._lastHealthCheckTimestamp = value; }
        }

        // Check to see if LastHealthCheckTimestamp property is set
        internal bool IsSetLastHealthCheckTimestamp()
        {
            return this._lastHealthCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUserActivityTimestamp. 
        /// <para>
        /// The timestamp of the last user's activity. <code>LastUserActivityTimestamp</code>
        /// is also updated when SageMaker performs health checks without user activity. As a
        /// result, this value is set to the same value as <code>LastHealthCheckTimestamp</code>.
        /// </para>
        /// </summary>
        public DateTime LastUserActivityTimestamp
        {
            get { return this._lastUserActivityTimestamp.GetValueOrDefault(); }
            set { this._lastUserActivityTimestamp = value; }
        }

        // Check to see if LastUserActivityTimestamp property is set
        internal bool IsSetLastUserActivityTimestamp()
        {
            return this._lastUserActivityTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceSpec. 
        /// <para>
        /// The instance type and the Amazon Resource Name (ARN) of the SageMaker image created
        /// on the instance.
        /// </para>
        /// </summary>
        public ResourceSpec ResourceSpec
        {
            get { return this._resourceSpec; }
            set { this._resourceSpec = value; }
        }

        // Check to see if ResourceSpec property is set
        internal bool IsSetResourceSpec()
        {
            return this._resourceSpec != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public AppStatus Status
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
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The user profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string UserProfileName
        {
            get { return this._userProfileName; }
            set { this._userProfileName = value; }
        }

        // Check to see if UserProfileName property is set
        internal bool IsSetUserProfileName()
        {
            return this._userProfileName != null;
        }

    }
}