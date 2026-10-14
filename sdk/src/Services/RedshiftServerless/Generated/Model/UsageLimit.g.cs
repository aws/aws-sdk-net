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
    /// The usage limit object.
    /// </summary>
    public partial class UsageLimit
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The limit amount. If time-based, this amount is in RPUs consumed per hour. If data-based,
        /// this amount is in terabytes (TB). The value must be a positive number.
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
        /// The action that Amazon Redshift Serverless takes when the limit is reached.
        /// </para>
        /// </summary>
        public UsageLimitBreachAction BreachAction { get; set; }

        /// <summary>
        /// Checks to see if the BreachAction property is set.
        /// </summary>
        internal bool IsSetBreachAction() => this.BreachAction != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time period that the amount applies to. A weekly period begins on Sunday. The
        /// default is monthly.
        /// </para>
        /// </summary>
        public UsageLimitPeriod Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the Amazon Redshift Serverless resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property UsageLimitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource associated with the usage limit.
        /// </para>
        /// </summary>
        public string UsageLimitArn { get; set; }

        /// <summary>
        /// Checks to see if the UsageLimitArn property is set.
        /// </summary>
        internal bool IsSetUsageLimitArn() => this.UsageLimitArn != null;

        /// <summary>
        /// Gets and sets the property UsageLimitId. 
        /// <para>
        /// The identifier of the usage limit.
        /// </para>
        /// </summary>
        public string UsageLimitId { get; set; }

        /// <summary>
        /// Checks to see if the UsageLimitId property is set.
        /// </summary>
        internal bool IsSetUsageLimitId() => this.UsageLimitId != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The Amazon Redshift Serverless feature to limit.
        /// </para>
        /// </summary>
        public UsageLimitUsageType UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
