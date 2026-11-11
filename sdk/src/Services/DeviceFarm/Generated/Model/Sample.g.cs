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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a sample of performance data.
    /// 
    ///  <important> 
    /// <para>
    /// Device Farm does not support performance data samples during test executions.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class Sample
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The sample's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The sample's type.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CPU: A CPU sample type. This is expressed as the app processing CPU time (including
        /// child processes) as reported by process, as a percentage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMORY: A memory usage sample type. This is expressed as the total proportional set
        /// size of an app process, in kilobytes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NATIVE_AVG_DRAWTIME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NATIVE_FPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NATIVE_FRAMES
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NATIVE_MAX_DRAWTIME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NATIVE_MIN_DRAWTIME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPENGL_AVG_DRAWTIME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPENGL_FPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPENGL_FRAMES
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPENGL_MAX_DRAWTIME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPENGL_MIN_DRAWTIME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RX
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RX_RATE: The total number of bytes per second (TCP and UDP) that are sent, by app
        /// process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// THREADS: A threads sample type. This is expressed as the total number of threads per
        /// app process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TX
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TX_RATE: The total number of bytes per second (TCP and UDP) that are received, by
        /// app process.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SampleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The presigned Amazon S3 URL that can be used with a GET request to download the sample's
        /// file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
