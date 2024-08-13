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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use these settings to insert a DVB Time and Date Table (TDT) in the transport stream
    /// of this output.
    /// </summary>
    public partial class DvbTdtSettings
    {
        private int? _tdtInterval;

        /// <summary>
        /// Gets and sets the property TdtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min=1000, Max=30000)]
        public int? TdtInterval
        {
            get { return this._tdtInterval; }
            set { this._tdtInterval = value; }
        }

        // Check to see if TdtInterval property is set
        internal bool IsSetTdtInterval()
        {
            return this._tdtInterval.HasValue; 
        }

    }
}