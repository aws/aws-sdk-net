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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Identifies a Amazon Cognito user group. A user group can be used in on or more work
    /// teams.
    /// </summary>
    public partial class CognitoMemberDefinition
    {
        private string _clientId;
        private string _userGroup;
        private string _userPool;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// An identifier for an application client. You must create the app client ID using Amazon
        /// Cognito.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroup. 
        /// <para>
        /// An identifier for a user group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string UserGroup
        {
            get { return this._userGroup; }
            set { this._userGroup = value; }
        }

        // Check to see if UserGroup property is set
        internal bool IsSetUserGroup()
        {
            return this._userGroup != null;
        }

        /// <summary>
        /// Gets and sets the property UserPool. 
        /// <para>
        /// An identifier for a user pool. The user pool must be in the same region as the service
        /// that you are calling.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPool
        {
            get { return this._userPool; }
            set { this._userPool = value; }
        }

        // Check to see if UserPool property is set
        internal bool IsSetUserPool()
        {
            return this._userPool != null;
        }

    }
}