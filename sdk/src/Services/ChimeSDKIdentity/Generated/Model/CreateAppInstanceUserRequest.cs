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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
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
namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppInstanceUser operation.
    /// Creates a user under an Amazon Chime <c>AppInstance</c>. The request consists of a
    /// unique <c>appInstanceUserId</c> and <c>Name</c> for that user.
    /// </summary>
    public partial class CreateAppInstanceUserRequest : AmazonChimeSDKIdentityRequest
    {
        private string _appInstanceArn;
        private string _appInstanceUserId;
        private string _clientRequestToken;
        private ExpirationSettings _expirationSettings;
        private string _metadata;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the <c>AppInstance</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppInstanceUserId. 
        /// <para>
        /// The user ID of the <c>AppInstance</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string AppInstanceUserId
        {
            get { return this._appInstanceUserId; }
            set { this._appInstanceUserId = value; }
        }

        // Check to see if AppInstanceUserId property is set
        internal bool IsSetAppInstanceUserId()
        {
            return this._appInstanceUserId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique ID of the request. Use different tokens to request additional <c>AppInstances</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationSettings. 
        /// <para>
        /// Settings that control the interval after which the <c>AppInstanceUser</c> is automatically
        /// deleted.
        /// </para>
        /// </summary>
        public ExpirationSettings ExpirationSettings
        {
            get { return this._expirationSettings; }
            set { this._expirationSettings = value; }
        }

        // Check to see if ExpirationSettings property is set
        internal bool IsSetExpirationSettings()
        {
            return this._expirationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The request's metadata. Limited to a 1KB string in UTF-8.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the <c>AppInstanceUser</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}