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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the GetSessionEmbedUrl operation.
    /// Generates a session URL and authorization code that you can embed in your web server
    /// code.
    /// </summary>
    public partial class GetSessionEmbedUrlRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _entryPoint;
        private long? _sessionLifetimeInMinutes;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that contains the QuickSight session that you're embedding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The entry point for the embedded session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property SessionLifetimeInMinutes. 
        /// <para>
        /// How many minutes the session is valid. The session lifetime must be 15-600 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=600)]
        public long SessionLifetimeInMinutes
        {
            get { return this._sessionLifetimeInMinutes.GetValueOrDefault(); }
            set { this._sessionLifetimeInMinutes = value; }
        }

        // Check to see if SessionLifetimeInMinutes property is set
        internal bool IsSetSessionLifetimeInMinutes()
        {
            return this._sessionLifetimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon QuickSight user's Amazon Resource Name (ARN), for use with <code>QUICKSIGHT</code>
        /// identity type. You can use this for any Amazon QuickSight users in your account (readers,
        /// authors, or admins) authenticated as one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Active Directory (AD) users or group members
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invited nonfederated users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM users and IAM role-based sessions authenticated through Federated Single Sign-On
        /// using SAML, OpenID Connect, or IAM federation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}