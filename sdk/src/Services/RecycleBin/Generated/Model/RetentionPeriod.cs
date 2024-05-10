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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
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
namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Information about the retention period for which the retention rule is to retain resources.
    /// </summary>
    public partial class RetentionPeriod
    {
        private RetentionPeriodUnit _retentionPeriodUnit;
        private int? _retentionPeriodValue;

        /// <summary>
        /// Gets and sets the property RetentionPeriodUnit. 
        /// <para>
        /// The unit of time in which the retention period is measured. Currently, only <c>DAYS</c>
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetentionPeriodUnit RetentionPeriodUnit
        {
            get { return this._retentionPeriodUnit; }
            set { this._retentionPeriodUnit = value; }
        }

        // Check to see if RetentionPeriodUnit property is set
        internal bool IsSetRetentionPeriodUnit()
        {
            return this._retentionPeriodUnit != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodValue. 
        /// <para>
        /// The period value for which the retention rule is to retain resources. The period is
        /// measured using the unit specified for <b>RetentionPeriodUnit</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3650)]
        public int? RetentionPeriodValue
        {
            get { return this._retentionPeriodValue; }
            set { this._retentionPeriodValue = value; }
        }

        // Check to see if RetentionPeriodValue property is set
        internal bool IsSetRetentionPeriodValue()
        {
            return this._retentionPeriodValue.HasValue; 
        }

    }
}