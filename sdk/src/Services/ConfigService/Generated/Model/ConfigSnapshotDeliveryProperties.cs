/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides options for how often AWS Config delivers configuration snapshots to the
    /// Amazon S3 bucket in your delivery channel.
    /// 
    ///  <note> 
    /// <para>
    /// If you want to create a rule that triggers evaluations for your resources when AWS
    /// Config delivers the configuration snapshot, see the following:
    /// </para>
    ///  </note> 
    /// <para>
    /// The frequency for a rule that triggers evaluations for your resources when AWS Config
    /// delivers the configuration snapshot is set by one of two values, depending on which
    /// is less frequent:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The value for the <code>deliveryFrequency</code> parameter within the delivery channel
    /// configuration, which sets how often AWS Config delivers configuration snapshots. This
    /// value also sets how often AWS Config invokes evaluations for AWS Config rules.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The value for the <code>MaximumExecutionFrequency</code> parameter, which sets the
    /// maximum frequency with which AWS Config invokes evaluations for the rule. For more
    /// information, see <a>ConfigRule</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the <code>deliveryFrequency</code> value is less frequent than the <code>MaximumExecutionFrequency</code>
    /// value for a rule, AWS Config invokes the rule only as often as the <code>deliveryFrequency</code>
    /// value.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// For example, you want your rule to run evaluations when AWS Config delivers the configuration
    /// snapshot.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You specify the <code>MaximumExecutionFrequency</code> value for <code>Six_Hours</code>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You then specify the delivery channel <code>deliveryFrequency</code> value for <code>TwentyFour_Hours</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Because the value for <code>deliveryFrequency</code> is less frequent than <code>MaximumExecutionFrequency</code>,
    /// AWS Config invokes evaluations for the rule every 24 hours. 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// You should set the <code>MaximumExecutionFrequency</code> value to be at least as
    /// frequent as the <code>deliveryFrequency</code> value. You can view the <code>deliveryFrequency</code>
    /// value by using the <code>DescribeDeliveryChannnels</code> action.
    /// </para>
    ///  
    /// <para>
    /// To update the <code>deliveryFrequency</code> with which AWS Config delivers your configuration
    /// snapshots, use the <code>PutDeliveryChannel</code> action.
    /// </para>
    /// </summary>
    public partial class ConfigSnapshotDeliveryProperties
    {
        private MaximumExecutionFrequency _deliveryFrequency;

        /// <summary>
        /// Gets and sets the property DeliveryFrequency. 
        /// <para>
        /// The frequency with which AWS Config delivers configuration snapshots.
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