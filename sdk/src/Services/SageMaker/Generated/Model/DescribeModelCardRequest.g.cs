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
    /// Container for the parameters to the DescribeModelCard operation. Describes the content,
    /// creation time, and security configuration of an Amazon SageMaker Model Card. <important>
    /// <para> To retrieve only metadata about a model card without requiring <c>kms:Decrypt</c>
    /// permission on the associated customer-managed Amazon Web Services KMS key, set <c>IncludedData</c>
    /// to <c>MetadataOnly</c>. The default is <c>AllData</c>, which returns the full model
    /// card <c>Content</c> and requires <c>kms:Decrypt</c> permission when a customer-managed
    /// key is configured. </para> </important>
    /// </summary>
    public partial class DescribeModelCardRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property IncludedData. 
        /// <para>
        /// Specifies the level of model card data to include in the response. Use this parameter
        /// to call <c>DescribeModelCard</c> without requiring <c>kms:Decrypt</c> permission on
        /// the customer-managed Amazon Web Services KMS key.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AllData</c>: Returns the full model card <c>Content</c>. This option requires
        /// <c>kms:Decrypt</c> permission on the customer-managed key, if one is associated with
        /// the model card. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MetadataOnly</c>: Returns the model card with sanitized <c>Content</c> that includes
        /// only a small set of unencrypted metadata fields. This option does not require <c>kms:Decrypt</c>
        /// permission. For the list of fields preserved in the response, see <c>Content</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, SageMaker returns <c>AllData</c>.
        /// </para>
        /// </summary>
        public IncludedData IncludedData { get; set; }

        /// <summary>
        /// Checks to see if the IncludedData property is set.
        /// </summary>
        internal bool IsSetIncludedData() => this.IncludedData != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model card to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card to describe. If a version is not provided, then the
        /// latest version of the model card is described.
        /// </para>
        /// </summary>
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;
    }
}
