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
    /// An object that represents the price performance target settings for the workgroup.
    /// </summary>
    public partial class PerformanceTarget
    {
        private int? _level;
        private PerformanceTargetStatus _status;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The target price performance level for the workgroup. Valid values include 1, 25,
        /// 50, 75, and 100. These correspond to the price performance levels LOW_COST, ECONOMICAL,
        /// BALANCED, RESOURCEFUL, and HIGH_PERFORMANCE.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the price performance target is enabled for the workgroup.
        /// </para>
        /// </summary>
        public PerformanceTargetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}