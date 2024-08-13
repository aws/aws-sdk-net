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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
    /// Container for the parameters to the CreateUsageLimit operation.
    /// Creates a usage limit for a specified Amazon Redshift Serverless usage type. The usage
    /// limit is identified by the returned usage limit identifier.
    /// </summary>
    public partial class CreateUsageLimitRequest : AmazonRedshiftServerlessRequest
    {
        private long? _amount;
        private UsageLimitBreachAction _breachAction;
        private UsageLimitPeriod _period;
        private string _resourceArn;
        private UsageLimitUsageType _usageType;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The limit amount. If time-based, this amount is in Redshift Processing Units (RPU)
        /// consumed per hour. If data-based, this amount is in terabytes (TB) of data transferred
        /// between Regions in cross-account sharing. The value must be a positive number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BreachAction. 
        /// <para>
        /// The action that Amazon Redshift Serverless takes when the limit is reached. The default
        /// is log.
        /// </para>
        /// </summary>
        public UsageLimitBreachAction BreachAction
        {
            get { return this._breachAction; }
            set { this._breachAction = value; }
        }

        // Check to see if BreachAction property is set
        internal bool IsSetBreachAction()
        {
            return this._breachAction != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time period that the amount applies to. A weekly period begins on Sunday. The
        /// default is monthly.
        /// </para>
        /// </summary>
        public UsageLimitPeriod Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Redshift Serverless resource to create
        /// the usage limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The type of Amazon Redshift Serverless usage to create a usage limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UsageLimitUsageType UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}