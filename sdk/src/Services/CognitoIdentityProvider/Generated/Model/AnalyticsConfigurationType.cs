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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The Amazon Pinpoint analytics configuration for collecting metrics for a user pool.
    /// </summary>
    public partial class AnalyticsConfigurationType
    {
        private string _applicationId;
        private string _externalId;
        private string _roleArn;
        private bool? _userDataShared;

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