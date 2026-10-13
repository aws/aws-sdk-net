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
    /// Container for the parameters to the CreateUsageLimit operation. Creates a usage limit
    /// for a specified Amazon Redshift Serverless usage type. The usage limit is identified
    /// by the returned usage limit identifier.
    /// </summary>
    public partial class CreateUsageLimitRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The limit amount. If time-based, this amount is in Redshift Processing Units (RPU)
        /// consumed per hour. If data-based, this amount is in terabytes (TB) of data transferred
        /// between Regions in cross-account sharing. The value must be a positive number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount.HasValue;

        /// <summary>
        /// Gets and sets the property BreachAction. 
        /// <para>
        /// The action that Amazon Redshift Serverless takes when the limit is reached. The default
        /// is log.
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
        /// The Amazon Resource Name (ARN) of the Amazon Redshift Serverless resource to create
        /// the usage limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The type of Amazon Redshift Serverless usage to create a usage limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UsageLimitUsageType UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;
    }
}
