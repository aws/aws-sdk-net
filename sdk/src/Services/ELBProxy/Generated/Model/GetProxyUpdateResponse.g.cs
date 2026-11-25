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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// This is the response object from the GetProxyUpdate operation.
    /// </summary>
    public partial class GetProxyUpdateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. The date and time that the update's propagation
        /// status became `complete`, `failed`, or `cancelled`. This value is absent while the
        /// update is `in-progress` or `skipped`.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Details. Details about the update.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyUpdateDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property ProxyArn. The Amazon Resource Name (ARN) of the proxy.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProxyArn { get; set; }

        /// <summary>
        /// Checks to see if the ProxyArn property is set.
        /// </summary>
        internal bool IsSetProxyArn() => this.ProxyArn != null;

        /// <summary>
        /// Gets and sets the property State. The state of the update.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyUpdateState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubmittedAt. The date and time that the update was submitted.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateId. The ID of the update.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UpdateId { get; set; }

        /// <summary>
        /// Checks to see if the UpdateId property is set.
        /// </summary>
        internal bool IsSetUpdateId() => this.UpdateId != null;

        /// <summary>
        /// Gets and sets the property ValidatedAt. The date and time that the update was first
        /// successfully applied to a proxy node. This value is absent until the update is valid.
        /// </summary>
        public DateTime? ValidatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ValidatedAt property is set.
        /// </summary>
        internal bool IsSetValidatedAt() => this.ValidatedAt.HasValue;
    }
}
