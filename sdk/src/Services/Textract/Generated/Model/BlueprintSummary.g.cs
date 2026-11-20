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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// A summary of a blueprint, returned in the results of <c>ListBlueprints</c>.
    /// </summary>
    public partial class BlueprintSummary
    {
        /// <summary>
        /// Gets and sets the property BlueprintArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string BlueprintArn { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintArn property is set.
        /// </summary>
        internal bool IsSetBlueprintArn() => this.BlueprintArn != null;

        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BlueprintName { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintName property is set.
        /// </summary>
        internal bool IsSetBlueprintName() => this.BlueprintName != null;

        /// <summary>
        /// Gets and sets the property BlueprintVersion. 
        /// <para>
        /// The version of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string BlueprintVersion { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintVersion property is set.
        /// </summary>
        internal bool IsSetBlueprintVersion() => this.BlueprintVersion != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the blueprint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the blueprint was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// Whether the blueprint is owned by your account or provided by Amazon Textract.
        /// </para>
        /// </summary>
        public ResourceOwner ResourceOwner { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwner property is set.
        /// </summary>
        internal bool IsSetResourceOwner() => this.ResourceOwner != null;
    }
}
