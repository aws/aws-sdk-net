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
    /// Container for the parameters to the CreateApp operation.
    /// Creates a running app for the specified UserProfile. This operation is automatically
    /// invoked by Amazon SageMaker Studio upon access to the associated Domain, and when
    /// new kernel configurations are selected by the user. A user may have multiple Apps
    /// active simultaneously.
    /// </summary>
    public partial class CreateAppRequest : AmazonSageMakerRequest
    {
        private string _appName;
        private AppType _appType;
        private string _domainId;
        private ResourceSpec _resourceSpec;
        private string _spaceName;
        private List<Tag> _tags = new List<Tag>();
        private string _userProfileName;

        /// <summary>
        /// Gets and sets the property AppName. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// Gets and sets the property ResourceSpec. 
        /// <para>
        /// The instance type and the Amazon Resource Name (ARN) of the SageMaker image created
        /// on the instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// The value of <code>InstanceType</code> passed as part of the <code>ResourceSpec</code>
        /// in the <code>CreateApp</code> call overrides the value passed as part of the <code>ResourceSpec</code>
        /// configured for the user profile or the domain. If <code>InstanceType</code> is not
        /// specified in any of those three <code>ResourceSpec</code> values for a <code>KernelGateway</code>
        /// app, the <code>CreateApp</code> call fails with a request validation error.
        /// </para>
        ///  </note>
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
        /// The name of the space. If this value is not set, then <code>UserProfileName</code>
        /// must be set.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The user profile name. If this value is not set, then <code>SpaceName</code> must
        /// be set.
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