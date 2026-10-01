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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateCustomAction operation. Updates a custom
    /// action.
    /// </summary>
    public partial class UpdateCustomActionRequest : AmazonChatbotRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name used to invoke this action in the chat channel. For example, <c>@aws run
        /// my-alias</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Defines when this custom action button should be attached to a notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomActionAttachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomActionAttachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomActionArn. 
        /// <para>
        /// The fully defined Amazon Resource Name (ARN) of the custom action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string CustomActionArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomActionArn property is set.
        /// </summary>
        internal bool IsSetCustomActionArn() => this.CustomActionArn != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the command to run when invoked as an alias or as an action button.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomActionDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;
    }
}
