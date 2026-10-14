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
    /// A summary of a specific version of the model card.
    /// </summary>
    public partial class ModelCardVersionSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the model card version was created.
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
        /// The time date and time that the model card version was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelCardArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ModelCardArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardArn property is set.
        /// </summary>
        internal bool IsSetModelCardArn() => this.ModelCardArn != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardStatus. 
        /// <para>
        /// The approval status of the model card version within your organization. Different
        /// organizations might have different criteria for model card review and approval.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Draft</c>: The model card is a work in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PendingReview</c>: The model card is pending review.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Approved</c>: The model card is approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Archived</c>: The model card is archived. No more updates should be made to the
        /// model card, but it can still be exported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelCardStatus ModelCardStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardStatus property is set.
        /// </summary>
        internal bool IsSetModelCardStatus() => this.ModelCardStatus != null;

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// A version of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;
    }
}
