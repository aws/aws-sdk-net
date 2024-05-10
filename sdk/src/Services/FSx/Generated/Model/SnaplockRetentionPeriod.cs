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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration to set the retention period of an FSx for ONTAP SnapLock volume.
    /// The retention period includes default, maximum, and minimum settings. For more information,
    /// see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-retention.html">Working
    /// with the retention period in SnapLock</a>.
    /// </summary>
    public partial class SnaplockRetentionPeriod
    {
        private RetentionPeriod _defaultRetention;
        private RetentionPeriod _maximumRetention;
        private RetentionPeriod _minimumRetention;

        /// <summary>
        /// Gets and sets the property DefaultRetention. 
        /// <para>
        /// The retention period assigned to a write once, read many (WORM) file by default if
        /// an explicit retention period is not set for an FSx for ONTAP SnapLock volume. The
        /// default retention period must be greater than or equal to the minimum retention period
        /// and less than or equal to the maximum retention period. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetentionPeriod DefaultRetention
        {
            get { return this._defaultRetention; }
            set { this._defaultRetention = value; }
        }

        // Check to see if DefaultRetention property is set
        internal bool IsSetDefaultRetention()
        {
            return this._defaultRetention != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumRetention. 
        /// <para>
        /// The longest retention period that can be assigned to a WORM file on an FSx for ONTAP
        /// SnapLock volume. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetentionPeriod MaximumRetention
        {
            get { return this._maximumRetention; }
            set { this._maximumRetention = value; }
        }

        // Check to see if MaximumRetention property is set
        internal bool IsSetMaximumRetention()
        {
            return this._maximumRetention != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumRetention. 
        /// <para>
        /// The shortest retention period that can be assigned to a WORM file on an FSx for ONTAP
        /// SnapLock volume. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetentionPeriod MinimumRetention
        {
            get { return this._minimumRetention; }
            set { this._minimumRetention = value; }
        }

        // Check to see if MinimumRetention property is set
        internal bool IsSetMinimumRetention()
        {
            return this._minimumRetention != null;
        }

    }
}