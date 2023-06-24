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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUsageLimit operation.
    /// Update a usage limit in Amazon Redshift Serverless. You can't update the usage type
    /// or period of a usage limit.
    /// </summary>
    public partial class UpdateUsageLimitRequest : AmazonRedshiftServerlessRequest
    {
        private long? _amount;
        private UsageLimitBreachAction _breachAction;
        private string _usageLimitId;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The new limit amount. If time-based, this amount is in Redshift Processing Units (RPU)
        /// consumed per hour. If data-based, this amount is in terabytes (TB) of data transferred
        /// between Regions in cross-account sharing. The value must be a positive number.
        /// </para>
        /// </summary>
        public long Amount
        {
            get { return this._amount.GetValueOrDefault(); }
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
        /// The new action that Amazon Redshift Serverless takes when the limit is reached.
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
        /// Gets and sets the property UsageLimitId. 
        /// <para>
        /// The identifier of the usage limit to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}