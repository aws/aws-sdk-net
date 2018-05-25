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
    /// An object with the name of the retention configuration and the retention period in
    /// days. The object stores the configuration for data retention in AWS Config.
    /// </summary>
    public partial class RetentionConfiguration
    {
        private string _name;
        private int? _retentionPeriodInDays;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the retention configuration object.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// Number of days AWS Config stores your historical information.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, only applicable to the configuration item history.
        /// </para>
        ///  </note>
        /// </summary>
        public int RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays.GetValueOrDefault(); }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

    }
}