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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about a generation request made for the bot locale.
    /// </summary>
    public partial class GenerationSummary
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time at which the generation request was made.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The unique identifier of the generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string GenerationId { get; set; }

        /// <summary>
        /// Checks to see if the GenerationId property is set.
        /// </summary>
        internal bool IsSetGenerationId() => this.GenerationId != null;

        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// The status of the generation request.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus { get; set; }

        /// <summary>
        /// Checks to see if the GenerationStatus property is set.
        /// </summary>
        internal bool IsSetGenerationStatus() => this.GenerationStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time at which the generation request was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;
    }
}
