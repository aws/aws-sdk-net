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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetChatResponseConfiguration operation.
    /// </summary>
    public partial class GetChatResponseConfigurationResponse : AmazonWebServiceResponse
    {
        private string _chatResponseConfigurationArn;
        private string _chatResponseConfigurationId;
        private DateTime? _createdAt;
        private string _displayName;
        private ChatResponseConfigurationDetail _inUseConfiguration;
        private ChatResponseConfigurationDetail _lastUpdateConfiguration;

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the retrieved chat response configuration, which
        /// uniquely identifies the resource across all Amazon Web Services services. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1284)]
        public string ChatResponseConfigurationArn
        {
            get { return this._chatResponseConfigurationArn; }
            set { this._chatResponseConfigurationArn = value; }
        }

        // Check to see if ChatResponseConfigurationArn property is set
        internal bool IsSetChatResponseConfigurationArn()
        {
            return this._chatResponseConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationId. 
        /// <para>
        /// The unique identifier of the retrieved chat response configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ChatResponseConfigurationId
        {
            get { return this._chatResponseConfigurationId; }
            set { this._chatResponseConfigurationId = value; }
        }

        // Check to see if ChatResponseConfigurationId property is set
        internal bool IsSetChatResponseConfigurationId()
        {
            return this._chatResponseConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when the chat response configuration was initially created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name of the retrieved chat response configuration, making it easier
        /// to identify among multiple configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property InUseConfiguration. 
        /// <para>
        /// The currently active configuration settings that are being used to generate responses
        /// in the Amazon Q Business application.
        /// </para>
        /// </summary>
        public ChatResponseConfigurationDetail InUseConfiguration
        {
            get { return this._inUseConfiguration; }
            set { this._inUseConfiguration = value; }
        }

        // Check to see if InUseConfiguration property is set
        internal bool IsSetInUseConfiguration()
        {
            return this._inUseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateConfiguration. 
        /// <para>
        /// Information about the most recent update to the configuration, including timestamp
        /// and modification details.
        /// </para>
        /// </summary>
        public ChatResponseConfigurationDetail LastUpdateConfiguration
        {
            get { return this._lastUpdateConfiguration; }
            set { this._lastUpdateConfiguration = value; }
        }

        // Check to see if LastUpdateConfiguration property is set
        internal bool IsSetLastUpdateConfiguration()
        {
            return this._lastUpdateConfiguration != null;
        }

    }
}