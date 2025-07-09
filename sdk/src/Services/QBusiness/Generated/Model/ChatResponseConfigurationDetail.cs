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
    /// Detailed information about a chat response configuration, including comprehensive
    /// settings and parameters that define how Amazon Q Business generates and formats responses.
    /// </summary>
    public partial class ChatResponseConfigurationDetail
    {
        private ErrorDetail _error;
        private Dictionary<string, ResponseConfiguration> _responseConfigurations = AWSConfigs.InitializeCollections ? new Dictionary<string, ResponseConfiguration>() : null;
        private string _responseConfigurationSummary;
        private ChatResponseConfigurationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Error.
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseConfigurations. 
        /// <para>
        /// A collection of specific response configuration settings that collectively define
        /// how responses are generated, formatted, and presented to users in chat interactions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public Dictionary<string, ResponseConfiguration> ResponseConfigurations
        {
            get { return this._responseConfigurations; }
            set { this._responseConfigurations = value; }
        }

        // Check to see if ResponseConfigurations property is set
        internal bool IsSetResponseConfigurations()
        {
            return this._responseConfigurations != null && (this._responseConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseConfigurationSummary. 
        /// <para>
        /// A summary of the response configuration details, providing a concise overview of the
        /// key parameters and settings that define the response generation behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResponseConfigurationSummary
        {
            get { return this._responseConfigurationSummary; }
            set { this._responseConfigurationSummary = value; }
        }

        // Check to see if ResponseConfigurationSummary property is set
        internal bool IsSetResponseConfigurationSummary()
        {
            return this._responseConfigurationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the chat response configuration, indicating whether it is active,
        /// pending, or in another state that affects its availability for use.
        /// </para>
        /// </summary>
        public ChatResponseConfigurationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp indicating when the detailed chat response configuration was last modified,
        /// helping administrators track changes and maintain version awareness.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}