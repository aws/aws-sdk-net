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
    /// Container for the parameters to the GetDashboardEmbedUrl operation.
    /// Generates a session URL and authorization code that you can use to embed an Amazon
    /// QuickSight read-only dashboard in your web server code. Before you use this command,
    /// make sure that you have configured the dashboards and permissions. 
    /// 
    ///  
    /// <para>
    /// Currently, you can use <code>GetDashboardEmbedURL</code> only from the server, not
    /// from the user's browser. The following rules apply to the combination of URL and authorization
    /// code:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// They must be used together.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// They can be used one time only.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// They are valid for 5 minutes after you run this command.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The resulting user session is valid for 10 hours.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedding-dashboards.html">Embedding
    /// Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i> .
    /// </para>
    /// </summary>
    public partial class GetDashboardEmbedUrlRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private IdentityType _identityType;
        private bool? _resetDisabled;
        private long? _sessionLifetimeInMinutes;
        private bool? _undoRedoDisabled;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that contains the dashboard that you're embedding.
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
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard, also added to the IAM policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The authentication method that the user uses to sign in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property ResetDisabled. 
        /// <para>
        /// Remove the reset button on the embedded dashboard. The default is FALSE, which enables
        /// the reset button.
        /// </para>
        /// </summary>
        public bool ResetDisabled
        {
            get { return this._resetDisabled.GetValueOrDefault(); }
            set { this._resetDisabled = value; }
        }

        // Check to see if ResetDisabled property is set
        internal bool IsSetResetDisabled()
        {
            return this._resetDisabled.HasValue; 
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
        /// Gets and sets the property UndoRedoDisabled. 
        /// <para>
        /// Remove the undo/redo button on the embedded dashboard. The default is FALSE, which
        /// enables the undo/redo button.
        /// </para>
        /// </summary>
        public bool UndoRedoDisabled
        {
            get { return this._undoRedoDisabled.GetValueOrDefault(); }
            set { this._undoRedoDisabled = value; }
        }

        // Check to see if UndoRedoDisabled property is set
        internal bool IsSetUndoRedoDisabled()
        {
            return this._undoRedoDisabled.HasValue; 
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
        /// <para>
        /// Omit this parameter for users in the third group – IAM users and IAM role-based sessions.
        /// </para>
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