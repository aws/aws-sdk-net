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
    /// A summary of a Managed API.
    /// </summary>
    public partial class ManagedApiSummary
    {
        /// <summary>
        /// Gets and sets the property ApiSignature. The attributes that identify the API.
        /// </summary>
        [AWSProperty(Required = true)]
        public ApiSignature ApiSignature { get; set; }

        /// <summary>
        /// Checks to see if the ApiSignature property is set.
        /// </summary>
        internal bool IsSetApiSignature() => this.ApiSignature != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. When the resource was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedApiArn. The ARN of the Managed API.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ManagedApiArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedApiArn property is set.
        /// </summary>
        internal bool IsSetManagedApiArn() => this.ManagedApiArn != null;

        /// <summary>
        /// Gets and sets the property ManagedApiId. The identifier of the Managed API.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ManagedApiId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedApiId property is set.
        /// </summary>
        internal bool IsSetManagedApiId() => this.ManagedApiId != null;

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
