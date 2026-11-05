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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyUsageLimit operation. Modifies a usage limit
    /// in a cluster. You can't modify the feature type or period of a usage limit.
    /// </summary>
    public partial class ModifyUsageLimitRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The new limit amount. For more information about this parameter, see <a>UsageLimit</a>.
        /// 
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
        /// The new action that Amazon Redshift takes when the limit is reached. For more information
        /// about this parameter, see <a>UsageLimit</a>. 
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
        /// The identifier of the usage limit to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string UsageLimitId { get; set; }

        /// <summary>
        /// Checks to see if the UsageLimitId property is set.
        /// </summary>
        internal bool IsSetUsageLimitId() => this.UsageLimitId != null;
    }
}
