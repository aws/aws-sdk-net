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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// A summary of an API page, without its body.
    /// </summary>
    public partial class ProductApiPageSummaryNoBody
    {
        /// <summary>
        /// Gets and sets the property ApiId. The API the page documents.
        /// </summary>
        [AWSProperty(Required = true)]
        public ApiId ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property ApiUrl. The invoke URL shown on the page and used by Try-It.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ApiUrl { get; set; }

        /// <summary>
        /// Checks to see if the ApiUrl property is set.
        /// </summary>
        internal bool IsSetApiUrl() => this.ApiUrl != null;

        /// <summary>
        /// Gets and sets the property OperationName. The operation name shown as the page title.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property ProductApiPageArn. The ARN of the API page.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ProductApiPageArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductApiPageArn property is set.
        /// </summary>
        internal bool IsSetProductApiPageArn() => this.ProductApiPageArn != null;

        /// <summary>
        /// Gets and sets the property ProductApiPageId. The identifier of the API page.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ProductApiPageId { get; set; }

        /// <summary>
        /// Checks to see if the ProductApiPageId property is set.
        /// </summary>
        internal bool IsSetProductApiPageId() => this.ProductApiPageId != null;

        /// <summary>
        /// Gets and sets the property Status. The status of the page content: `IN_PROGRESS` while
        /// it is generated, then `AVAILABLE` or `FAILED`.
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusException.
        /// </summary>
        public ProductApiPageStatusException StatusException { get; set; }

        /// <summary>
        /// Checks to see if the StatusException property is set.
        /// </summary>
        internal bool IsSetStatusException() => this.StatusException != null;

        /// <summary>
        /// Gets and sets the property TryItState. Whether Try-It is enabled on the page.
        /// </summary>
        [AWSProperty(Required = true)]
        public TryItState TryItState { get; set; }

        /// <summary>
        /// Checks to see if the TryItState property is set.
        /// </summary>
        internal bool IsSetTryItState() => this.TryItState != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. When the resource was last updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
