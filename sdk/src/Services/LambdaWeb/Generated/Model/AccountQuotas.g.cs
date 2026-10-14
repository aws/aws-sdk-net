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

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The quotas that apply to web functions in your account in the current AWS Region.
    /// </summary>
    public partial class AccountQuotas
    {
        /// <summary>
        /// Gets and sets the property MaxEndpointsPerFunction. 
        /// <para>
        /// The maximum number of endpoints that a single web function can have.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxEndpointsPerFunction { get; set; }

        /// <summary>
        /// Checks to see if the MaxEndpointsPerFunction property is set.
        /// </summary>
        internal bool IsSetMaxEndpointsPerFunction() => this.MaxEndpointsPerFunction.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRevisionsPerFunction. 
        /// <para>
        /// The maximum number of revisions that a single web function can have.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxRevisionsPerFunction { get; set; }

        /// <summary>
        /// Checks to see if the MaxRevisionsPerFunction property is set.
        /// </summary>
        internal bool IsSetMaxRevisionsPerFunction() => this.MaxRevisionsPerFunction.HasValue;

        /// <summary>
        /// Gets and sets the property MaxTotalArmVCpus. 
        /// <para>
        /// The maximum total number of Arm vCPUs that you can allocate across all of your web
        /// functions in the current AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxTotalArmVCpus { get; set; }

        /// <summary>
        /// Checks to see if the MaxTotalArmVCpus property is set.
        /// </summary>
        internal bool IsSetMaxTotalArmVCpus() => this.MaxTotalArmVCpus.HasValue;

        /// <summary>
        /// Gets and sets the property MaxTotalRateLimit. 
        /// <para>
        /// The maximum number of requests per second allowed across all of your web function
        /// endpoints in your account in the current AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxTotalRateLimit { get; set; }

        /// <summary>
        /// Checks to see if the MaxTotalRateLimit property is set.
        /// </summary>
        internal bool IsSetMaxTotalRateLimit() => this.MaxTotalRateLimit.HasValue;
    }
}
