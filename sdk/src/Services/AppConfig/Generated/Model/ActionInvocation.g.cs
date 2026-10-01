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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// An extension that was invoked as part of a deployment event.
    /// </summary>
    public partial class ActionInvocation
    {
        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code when an extension invocation fails.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message when an extension invocation fails.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ExtensionIdentifier. 
        /// <para>
        /// The name, the ID, or the Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExtensionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionIdentifier property is set.
        /// </summary>
        internal bool IsSetExtensionIdentifier() => this.ExtensionIdentifier != null;

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// A system-generated ID for this invocation.
        /// </para>
        /// </summary>
        public string InvocationId { get; set; }

        /// <summary>
        /// Checks to see if the InvocationId property is set.
        /// </summary>
        internal bool IsSetInvocationId() => this.InvocationId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) for an Identity and Access Management assume role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The extension URI associated to the action point in the extension definition. The
        /// URI can be an Amazon Resource Name (ARN) for one of the following: an Lambda function,
        /// an Amazon Simple Queue Service queue, an Amazon Simple Notification Service topic,
        /// or the Amazon EventBridge default event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
