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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSpendingLimit operation.
    /// Updates an existing spending limit. You can modify the spending amount or time period.
    /// Changes take effect immediately.
    /// </summary>
    public partial class UpdateSpendingLimitRequest : AmazonBraketRequest
    {
        private string _clientToken;
        private string _spendingLimit;
        private string _spendingLimitArn;
        private TimePeriod _timePeriod;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Braket ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property SpendingLimit. 
        /// <para>
        /// The new maximum amount that can be spent on the specified device, in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SpendingLimit
        {
            get { return this._spendingLimit; }
            set { this._spendingLimit = value; }
        }

        // Check to see if SpendingLimit property is set
        internal bool IsSetSpendingLimit()
        {
            return this._spendingLimit != null;
        }

        /// <summary>
        /// Gets and sets the property SpendingLimitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the spending limit to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string SpendingLimitArn
        {
            get { return this._spendingLimitArn; }
            set { this._spendingLimitArn = value; }
        }

        // Check to see if SpendingLimitArn property is set
        internal bool IsSetSpendingLimitArn()
        {
            return this._spendingLimitArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The new time period during which the spending limit is active, including start and
        /// end dates.
        /// </para>
        /// </summary>
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}