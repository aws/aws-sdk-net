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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetS3AccessPolicy operation.
    /// </summary>
    public partial class GetS3AccessPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property S3AccessPointArn. 
        /// <para>
        /// The S3 access point ARN that has the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string S3AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPointArn property is set.
        /// </summary>
        internal bool IsSetS3AccessPointArn() => this.S3AccessPointArn != null;

        /// <summary>
        /// Gets and sets the property S3AccessPolicy. 
        /// <para>
        /// The current resource policy that controls S3 access on the store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100000)]
        public string S3AccessPolicy { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPolicy property is set.
        /// </summary>
        internal bool IsSetS3AccessPolicy() => this.S3AccessPolicy != null;

        /// <summary>
        /// Gets and sets the property StoreId. 
        /// <para>
        /// The Amazon Web Services-generated Sequence Store or Reference Store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 36)]
        public string StoreId { get; set; }

        /// <summary>
        /// Checks to see if the StoreId property is set.
        /// </summary>
        internal bool IsSetStoreId() => this.StoreId != null;

        /// <summary>
        /// Gets and sets the property StoreType. 
        /// <para>
        /// The type of store associated with the access point.
        /// </para>
        /// </summary>
        public StoreType StoreType { get; set; }

        /// <summary>
        /// Checks to see if the StoreType property is set.
        /// </summary>
        internal bool IsSetStoreType() => this.StoreType != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time when the policy was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
