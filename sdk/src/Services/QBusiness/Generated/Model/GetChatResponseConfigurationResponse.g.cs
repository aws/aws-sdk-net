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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetChatResponseConfiguration operation.
    /// </summary>
    public partial class GetChatResponseConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the retrieved chat response configuration, which
        /// uniquely identifies the resource across all Amazon Web Services services. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1284)]
        public string ChatResponseConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ChatResponseConfigurationArn property is set.
        /// </summary>
        internal bool IsSetChatResponseConfigurationArn() => this.ChatResponseConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationId. 
        /// <para>
        /// The unique identifier of the retrieved chat response configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ChatResponseConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ChatResponseConfigurationId property is set.
        /// </summary>
        internal bool IsSetChatResponseConfigurationId() => this.ChatResponseConfigurationId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when the chat response configuration was initially created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name of the retrieved chat response configuration, making it easier
        /// to identify among multiple configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InUseConfiguration. 
        /// <para>
        /// The currently active configuration settings that are being used to generate responses
        /// in the Amazon Q Business application.
        /// </para>
        /// </summary>
        public ChatResponseConfigurationDetail InUseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InUseConfiguration property is set.
        /// </summary>
        internal bool IsSetInUseConfiguration() => this.InUseConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastUpdateConfiguration. 
        /// <para>
        /// Information about the most recent update to the configuration, including timestamp
        /// and modification details.
        /// </para>
        /// </summary>
        public ChatResponseConfigurationDetail LastUpdateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateConfiguration property is set.
        /// </summary>
        internal bool IsSetLastUpdateConfiguration() => this.LastUpdateConfiguration != null;
    }
}
