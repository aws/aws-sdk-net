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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of an extension installed on a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ExtensionSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the extension was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExtensionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExtensionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionArn property is set.
        /// </summary>
        internal bool IsSetExtensionArn() => this.ExtensionArn != null;

        /// <summary>
        /// Gets and sets the property ExtensionName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionName property is set.
        /// </summary>
        internal bool IsSetExtensionName() => this.ExtensionName != null;

        /// <summary>
        /// Gets and sets the property ExtensionVersion. 
        /// <para>
        /// The version of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ExtensionVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionVersion property is set.
        /// </summary>
        internal bool IsSetExtensionVersion() => this.ExtensionVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the extension. For the meaning of each status, see <c>ExtensionDetails</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtensionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
