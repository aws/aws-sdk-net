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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUsageLimit operation. Update a usage limit
    /// in Amazon Redshift Serverless. You can't update the usage type or period of a usage
    /// limit.
    /// </summary>
    public partial class UpdateUsageLimitRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The new limit amount. If time-based, this amount is in Redshift Processing Units (RPU)
        /// consumed per hour. If data-based, this amount is in terabytes (TB) of data transferred
        /// between Regions in cross-account sharing. The value must be a positive number.
        /// </para>
        /// </summary>
        public long? Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount.HasValue;

        /// <summary>
        /// Gets and sets the property BreachAction. 
        /// <para>
        /// The new action that Amazon Redshift Serverless takes when the limit is reached.
        /// </para>
        /// </summary>
        public UsageLimitBreachAction BreachAction { get; set; }

        /// <summary>
        /// Checks to see if the BreachAction property is set.
        /// </summary>
        internal bool IsSetBreachAction() => this.BreachAction != null;

        /// <summary>
        /// Gets and sets the property UsageLimitId. 
        /// <para>
        /// The identifier of the usage limit to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UsageLimitId { get; set; }

        /// <summary>
        /// Checks to see if the UsageLimitId property is set.
        /// </summary>
        internal bool IsSetUsageLimitId() => this.UsageLimitId != null;
    }
}
