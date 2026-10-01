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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the ListExposuresByRemediationV2 operation.
    /// </summary>
    public partial class ListExposuresByRemediationV2Response : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// An array of exposure findings returned by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public List<ExposureFinding> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<ExposureFinding>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to request the next page of results. Otherwise, this parameter
        /// is null.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// Provides comprehensive details about a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationResource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property TargetUid. 
        /// <para>
        /// The unique identifier (ID) of the remediation target that the exposure findings are
        /// associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetUid { get; set; }

        /// <summary>
        /// Checks to see if the TargetUid property is set.
        /// </summary>
        internal bool IsSetTargetUid() => this.TargetUid != null;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total count of exposure findings associated with the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;

        /// <summary>
        /// Gets and sets the property Trait. 
        /// <para>
        /// The specific trait associated with the remediation target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationTrait Trait { get; set; }

        /// <summary>
        /// Checks to see if the Trait property is set.
        /// </summary>
        internal bool IsSetTrait() => this.Trait != null;
    }
}
