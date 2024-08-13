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
    /// The usage limit object.
    /// </summary>
    public partial class UsageLimit
    {
        private long? _amount;
        private UsageLimitBreachAction _breachAction;
        private UsageLimitPeriod _period;
        private string _resourceArn;
        private string _usageLimitArn;
        private string _usageLimitId;
        private UsageLimitUsageType _usageType;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The limit amount. If time-based, this amount is in RPUs consumed per hour. If data-based,
        /// this amount is in terabytes (TB). The value must be a positive number.
        /// </para>
        /// </summary>
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
        /// The action that Amazon Redshift Serverless takes when the limit is reached.
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
        /// The Amazon Resource Name (ARN) that identifies the Amazon Redshift Serverless resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UsageLimitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource associated with the usage limit.
        /// </para>
        /// </summary>
        public string UsageLimitArn
        {
            get { return this._usageLimitArn; }
            set { this._usageLimitArn = value; }
        }

        // Check to see if UsageLimitArn property is set
        internal bool IsSetUsageLimitArn()
        {
            return this._usageLimitArn != null;
        }

        /// <summary>
        /// Gets and sets the property UsageLimitId. 
        /// <para>
        /// The identifier of the usage limit.
        /// </para>
        /// </summary>
        public string UsageLimitId
        {
            get { return this._usageLimitId; }
            set { this._usageLimitId = value; }
        }

        // Check to see if UsageLimitId property is set
        internal bool IsSetUsageLimitId()
        {
            return this._usageLimitId != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The Amazon Redshift Serverless feature to limit.
        /// </para>
        /// </summary>
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