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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides options for how often Config delivers configuration snapshots to the Amazon
    /// S3 bucket in your delivery channel.
    /// 
    ///  
    /// <para>
    /// The frequency for a rule that triggers evaluations for your resources when Config
    /// delivers the configuration snapshot is set by one of two values, depending on which
    /// is less frequent:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The value for the <c>deliveryFrequency</c> parameter within the delivery channel configuration,
    /// which sets how often Config delivers configuration snapshots. This value also sets
    /// how often Config invokes evaluations for Config rules.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The value for the <c>MaximumExecutionFrequency</c> parameter, which sets the maximum
    /// frequency with which Config invokes evaluations for the rule. For more information,
    /// see <a>ConfigRule</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the <c>deliveryFrequency</c> value is less frequent than the <c>MaximumExecutionFrequency</c>
    /// value for a rule, Config invokes the rule only as often as the <c>deliveryFrequency</c>
    /// value.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// For example, you want your rule to run evaluations when Config delivers the configuration
    /// snapshot.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You specify the <c>MaximumExecutionFrequency</c> value for <c>Six_Hours</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You then specify the delivery channel <c>deliveryFrequency</c> value for <c>TwentyFour_Hours</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Because the value for <c>deliveryFrequency</c> is less frequent than <c>MaximumExecutionFrequency</c>,
    /// Config invokes evaluations for the rule every 24 hours. 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// You should set the <c>MaximumExecutionFrequency</c> value to be at least as frequent
    /// as the <c>deliveryFrequency</c> value. You can view the <c>deliveryFrequency</c> value
    /// by using the <c>DescribeDeliveryChannnels</c> action.
    /// </para>
    ///  
    /// <para>
    /// To update the <c>deliveryFrequency</c> with which Config delivers your configuration
    /// snapshots, use the <c>PutDeliveryChannel</c> action.
    /// </para>
    /// </summary>
    public partial class ConfigSnapshotDeliveryProperties
    {
        private MaximumExecutionFrequency _deliveryFrequency;

        /// <summary>
        /// Gets and sets the property DeliveryFrequency. 
        /// <para>
        /// The frequency with which Config delivers configuration snapshots.
        /// </para>
        /// </summary>
        public MaximumExecutionFrequency DeliveryFrequency
        {
            get { return this._deliveryFrequency; }
            set { this._deliveryFrequency = value; }
        }

        // Check to see if DeliveryFrequency property is set
        internal bool IsSetDeliveryFrequency()
        {
            return this._deliveryFrequency != null;
        }

    }
}