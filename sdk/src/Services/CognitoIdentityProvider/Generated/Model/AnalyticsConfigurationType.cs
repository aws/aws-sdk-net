/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The Amazon Pinpoint analytics configuration for collecting metrics for a user pool.
    /// 
    ///  <note> 
    /// <para>
    /// In regions where Pinpoint is not available, Cognito User Pools only supports sending
    /// events to Amazon Pinpoint projects in us-east-1. In regions where Pinpoint is available,
    /// Cognito User Pools will support sending events to Amazon Pinpoint projects within
    /// that same region. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AnalyticsConfigurationType
    {
        private string _applicationArn;
        private string _applicationId;
        private string _externalId;
        private string _roleArn;
        private bool? _userDataShared;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Pinpoint project. You can use the Amazon
        /// Pinpoint project for Pinpoint integration with the chosen User Pool Client. Amazon
        /// Cognito publishes events to the pinpoint project declared by the app ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID for an Amazon Pinpoint application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that authorizes Amazon Cognito to publish events to Amazon
        /// Pinpoint analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserDataShared. 
        /// <para>
        /// If <code>UserDataShared</code> is <code>true</code>, Amazon Cognito will include user
        /// data in the events it publishes to Amazon Pinpoint analytics.
        /// </para>
        /// </summary>
        public bool UserDataShared
        {
            get { return this._userDataShared.GetValueOrDefault(); }
            set { this._userDataShared = value; }
        }

        // Check to see if UserDataShared property is set
        internal bool IsSetUserDataShared()
        {
            return this._userDataShared.HasValue; 
        }

    }
}