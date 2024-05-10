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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// A single attack statistics data record. This is returned by <a>DescribeAttackStatistics</a>
    /// along with a time range indicating the time period that the attack statistics apply
    /// to.
    /// </summary>
    public partial class AttackStatisticsDataItem
    {
        private long? _attackCount;
        private AttackVolume _attackVolume;

        /// <summary>
        /// Gets and sets the property AttackCount. 
        /// <para>
        /// The number of attacks detected during the time period. This is always present, but
        /// might be zero. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? AttackCount
        {
            get { return this._attackCount; }
            set { this._attackCount = value; }
        }

        // Check to see if AttackCount property is set
        internal bool IsSetAttackCount()
        {
            return this._attackCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AttackVolume. 
        /// <para>
        /// Information about the volume of attacks during the time period. If the accompanying
        /// <c>AttackCount</c> is zero, this setting might be empty.
        /// </para>
        /// </summary>
        public AttackVolume AttackVolume
        {
            get { return this._attackVolume; }
            set { this._attackVolume = value; }
        }

        // Check to see if AttackVolume property is set
        internal bool IsSetAttackVolume()
        {
            return this._attackVolume != null;
        }

    }
}