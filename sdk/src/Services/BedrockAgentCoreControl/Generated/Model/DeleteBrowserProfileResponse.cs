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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the DeleteBrowserProfile operation.
    /// </summary>
    public partial class DeleteBrowserProfileResponse : AmazonWebServiceResponse
    {
        private DateTime? _lastSavedAt;
        private DateTime? _lastUpdatedAt;
        private string _profileArn;
        private string _profileId;
        private BrowserProfileStatus _status;

        /// <summary>
        /// Gets and sets the property LastSavedAt. 
        /// <para>
        /// The timestamp when browser session data was last saved to this profile before deletion.
        /// </para>
        /// </summary>
        public DateTime? LastSavedAt
        {
            get { return this._lastSavedAt; }
            set { this._lastSavedAt = value; }
        }

        // Check to see if LastSavedAt property is set
        internal bool IsSetLastSavedAt()
        {
            return this._lastSavedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the browser profile was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deleted browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the deleted browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the browser profile deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BrowserProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}