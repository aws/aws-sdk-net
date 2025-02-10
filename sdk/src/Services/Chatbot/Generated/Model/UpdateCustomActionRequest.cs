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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCustomAction operation.
    /// Updates a custom action.
    /// </summary>
    public partial class UpdateCustomActionRequest : AmazonChatbotRequest
    {
        private string _aliasName;
        private List<CustomActionAttachment> _attachments = AWSConfigs.InitializeCollections ? new List<CustomActionAttachment>() : null;
        private string _customActionArn;
        private CustomActionDefinition _definition;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name used to invoke this action in the chat channel. For example, <c>@aws run
        /// my-alias</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Defines when this custom action button should be attached to a notification.
        /// </para>
        /// </summary>
        public List<CustomActionAttachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomActionArn. 
        /// <para>
        /// The fully defined Amazon Resource Name (ARN) of the custom action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string CustomActionArn
        {
            get { return this._customActionArn; }
            set { this._customActionArn = value; }
        }

        // Check to see if CustomActionArn property is set
        internal bool IsSetCustomActionArn()
        {
            return this._customActionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the command to run when invoked as an alias or as an action button.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomActionDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

    }
}