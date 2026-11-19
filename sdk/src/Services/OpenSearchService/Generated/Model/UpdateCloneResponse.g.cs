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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the UpdateClone operation.
    /// </summary>
    public partial class UpdateCloneResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The unique identifier of the configuration change. Use it with <c>DescribeDomainChangeProgress</c>
        /// to track the change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ChangeId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeId property is set.
        /// </summary>
        internal bool IsSetChangeId() => this.ChangeId != null;

        /// <summary>
        /// Gets and sets the property CutoverOptions. 
        /// <para>
        /// The requested cutover target and the status of the cutover.
        /// </para>
        /// </summary>
        public CutoverOptions CutoverOptions { get; set; }

        /// <summary>
        /// Checks to see if the CutoverOptions property is set.
        /// </summary>
        internal bool IsSetCutoverOptions() => this.CutoverOptions != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property RetentionOptions. 
        /// <para>
        /// The retention settings for the upgrade.
        /// </para>
        /// </summary>
        public RetentionOptions RetentionOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetentionOptions property is set.
        /// </summary>
        internal bool IsSetRetentionOptions() => this.RetentionOptions != null;

        /// <summary>
        /// Gets and sets the property TrafficSplitOptions. 
        /// <para>
        /// The current and requested traffic split, and the status of the traffic shift.
        /// </para>
        /// </summary>
        public TrafficSplitOptions TrafficSplitOptions { get; set; }

        /// <summary>
        /// Checks to see if the TrafficSplitOptions property is set.
        /// </summary>
        internal bool IsSetTrafficSplitOptions() => this.TrafficSplitOptions != null;
    }
}
