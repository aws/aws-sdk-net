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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the UpdateCommand operation.
    /// </summary>
    public partial class UpdateCommandResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The unique identifier of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property Deprecated. 
        /// <para>
        /// The boolean that indicates whether the command was deprecated.
        /// </para>
        /// </summary>
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Checks to see if the Deprecated property is set.
        /// </summary>
        internal bool IsSetDeprecated() => this.Deprecated.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated text description of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated user-friendly display name in the console for the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time (epoch timestamp in seconds) when the command was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;
    }
}
