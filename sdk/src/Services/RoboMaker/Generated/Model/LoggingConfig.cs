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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// The logging configuration.
    /// </summary>
    public partial class LoggingConfig
    {
        private bool? _recordAllRosTopics;

        /// <summary>
        /// Gets and sets the property RecordAllRosTopics. 
        /// <para>
        /// A boolean indicating whether to record all ROS topics.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("AWS RoboMaker is ending support for ROS software suite. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/software-support-policy.html.")]
        public bool? RecordAllRosTopics
        {
            get { return this._recordAllRosTopics; }
            set { this._recordAllRosTopics = value; }
        }

        // Check to see if RecordAllRosTopics property is set
        internal bool IsSetRecordAllRosTopics()
        {
            return this._recordAllRosTopics.HasValue; 
        }

    }
}