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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The scaling configuration for an Aurora Serverless v2 DB cluster.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.html">Using
    /// Amazon Aurora Serverless v2</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ServerlessV2ScalingConfigurationInfo
    {
        private double? _maxCapacity;
        private double? _minCapacity;
        private int? _secondsUntilAutoPause;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of Aurora capacity units (ACUs) for a DB instance in an Aurora
        /// Serverless v2 cluster. You can specify ACU values in half-step increments, such as
        /// 32, 32.5, 33, and so on. The largest value that you can use is 256 for recent Aurora
        /// versions, or 128 for older versions. You can check the attributes of your engine version
        /// or platform version to determine the specific maximum capacity supported.
        /// </para>
        /// </summary>
        public double? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum number of Aurora capacity units (ACUs) for a DB instance in an Aurora
        /// Serverless v2 cluster. You can specify ACU values in half-step increments, such as
        /// 8, 8.5, 9, and so on. For Aurora versions that support the Aurora Serverless v2 auto-pause
        /// feature, the smallest value that you can use is 0. For versions that don't support
        /// Aurora Serverless v2 auto-pause, the smallest value that you can use is 0.5. 
        /// </para>
        /// </summary>
        public double? MinCapacity
        {
            get { return this._minCapacity; }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondsUntilAutoPause. 
        /// <para>
        ///  The number of seconds an Aurora Serverless v2 DB instance must be idle before Aurora
        /// attempts to automatically pause it. This property is only shown when the minimum capacity
        /// for the cluster is set to 0 ACUs. Changing the minimum capacity to a nonzero value
        /// removes this property. If you later change the minimum capacity back to 0 ACUs, this
        /// property is reset to its default value unless you specify it again. 
        /// </para>
        ///  
        /// <para>
        /// This value ranges between 300 seconds (five minutes) and 86,400 seconds (one day).
        /// The default is 300 seconds.
        /// </para>
        /// </summary>
        public int? SecondsUntilAutoPause
        {
            get { return this._secondsUntilAutoPause; }
            set { this._secondsUntilAutoPause = value; }
        }

        // Check to see if SecondsUntilAutoPause property is set
        internal bool IsSetSecondsUntilAutoPause()
        {
            return this._secondsUntilAutoPause.HasValue; 
        }

    }
}