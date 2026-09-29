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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This is the response object from the BatchDescribeEntities operation.
    /// </summary>
    public partial class BatchDescribeEntitiesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EntityDetails. 
        /// <para>
        /// Details about each entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, EntityDetail> EntityDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, EntityDetail>() : null;

        /// <summary>
        /// Checks to see if the EntityDetails property is set.
        /// </summary>
        internal bool IsSetEntityDetails() => this.EntityDetails != null && (this.EntityDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A map of errors returned, with <c>EntityId</c> as the key and <c>errorDetail</c> as
        /// the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, BatchDescribeErrorDetail> Errors { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, BatchDescribeErrorDetail>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
