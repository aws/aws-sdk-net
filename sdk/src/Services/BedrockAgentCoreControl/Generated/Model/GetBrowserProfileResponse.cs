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
    /// This is the response object from the GetBrowserProfile operation.
    /// </summary>
    public partial class GetBrowserProfileResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastSavedAt;
        private string _lastSavedBrowserId;
        private string _lastSavedBrowserSessionId;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private string _profileArn;
        private string _profileId;
        private BrowserProfileStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the browser profile was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
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
        /// Gets and sets the property LastSavedAt. 
        /// <para>
        /// The timestamp when browser session data was last saved to this profile.
        /// </para>
        /// </summary>
        public DateTime LastSavedAt
        {
            get { return this._lastSavedAt.GetValueOrDefault(); }
            set { this._lastSavedAt = value; }
        }

        // Check to see if LastSavedAt property is set
        internal bool IsSetLastSavedAt()
        {
            return this._lastSavedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSavedBrowserId. 
        /// <para>
        /// The identifier of the browser from which data was last saved to this profile.
        /// </para>
        /// </summary>
        public string LastSavedBrowserId
        {
            get { return this._lastSavedBrowserId; }
            set { this._lastSavedBrowserId = value; }
        }

        // Check to see if LastSavedBrowserId property is set
        internal bool IsSetLastSavedBrowserId()
        {
            return this._lastSavedBrowserId != null;
        }

        /// <summary>
        /// Gets and sets the property LastSavedBrowserSessionId. 
        /// <para>
        /// The identifier of the browser session from which data was last saved to this profile.
        /// </para>
        /// </summary>
        public string LastSavedBrowserSessionId
        {
            get { return this._lastSavedBrowserSessionId; }
            set { this._lastSavedBrowserSessionId = value; }
        }

        // Check to see if LastSavedBrowserSessionId property is set
        internal bool IsSetLastSavedBrowserSessionId()
        {
            return this._lastSavedBrowserSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the browser profile was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the browser profile.
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
        /// The unique identifier of the browser profile.
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
        /// The current status of the browser profile.
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