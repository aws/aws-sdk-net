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
    /// Information about an association between an extension and an AppConfig resource such
    /// as an application, environment, or configuration profile. Call <c>GetExtensionAssociation</c>
    /// to get more information about an association.
    /// </summary>
    public partial class ExtensionAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property ExtensionArn. 
        /// <para>
        /// The system-generated Amazon Resource Name (ARN) for the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExtensionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionArn property is set.
        /// </summary>
        internal bool IsSetExtensionArn() => this.ExtensionArn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The extension association ID. This ID is used to call other <c>ExtensionAssociation</c>
        /// API actions such as <c>GetExtensionAssociation</c> or <c>DeleteExtensionAssociation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARNs of applications, configuration profiles, or environments defined in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
