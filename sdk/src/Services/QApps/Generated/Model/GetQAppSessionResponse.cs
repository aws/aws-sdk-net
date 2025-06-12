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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the GetQAppSession operation.
    /// </summary>
    public partial class GetQAppSessionResponse : AmazonWebServiceResponse
    {
        private int? _appVersion;
        private Dictionary<string, CardStatus> _cardStatus = AWSConfigs.InitializeCollections ? new Dictionary<string, CardStatus>() : null;
        private int? _latestPublishedAppVersion;
        private string _sessionArn;
        private string _sessionId;
        private string _sessionName;
        private ExecutionStatus _status;
        private bool? _userIsHost;

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the Q App used for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CardStatus. 
        /// <para>
        /// The current status for each card in the Q App session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, CardStatus> CardStatus
        {
            get { return this._cardStatus; }
            set { this._cardStatus = value; }
        }

        // Check to see if CardStatus property is set
        internal bool IsSetCardStatus()
        {
            return this._cardStatus != null && (this._cardStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LatestPublishedAppVersion. 
        /// <para>
        /// The latest published version of the Q App used for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? LatestPublishedAppVersion
        {
            get { return this._latestPublishedAppVersion; }
            set { this._latestPublishedAppVersion = value; }
        }

        // Check to see if LatestPublishedAppVersion property is set
        internal bool IsSetLatestPublishedAppVersion()
        {
            return this._latestPublishedAppVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The name of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus Status
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
        /// Gets and sets the property UserIsHost. 
        /// <para>
        /// Indicates whether the current user is the owner of the Q App data collection session.
        /// </para>
        /// </summary>
        public bool? UserIsHost
        {
            get { return this._userIsHost; }
            set { this._userIsHost = value; }
        }

        // Check to see if UserIsHost property is set
        internal bool IsSetUserIsHost()
        {
            return this._userIsHost.HasValue; 
        }

    }
}