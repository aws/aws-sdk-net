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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides a summary of the what-if forecast properties used in the <a>ListWhatIfForecasts</a>
    /// operation. To get the complete set of properties, call the <a>DescribeWhatIfForecast</a>
    /// operation, and provide the <code>WhatIfForecastArn</code> that is listed in the summary.
    /// </summary>
    public partial class WhatIfForecastSummary
    {
        private DateTime? _creationTime;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _status;
        private string _whatIfAnalysisArn;
        private string _whatIfForecastArn;
        private string _whatIfForecastName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the what-if forecast was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code> - The <code>CreationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_IN_PROGRESS</code> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPING</code> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPED</code> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> or <code>CREATE_FAILED</code> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime LastModificationTime
        {
            get { return this._lastModificationTime.GetValueOrDefault(); }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the what-if forecast. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPING</code>, <code>CREATE_STOPPED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>Status</code> of the what-if analysis must be <code>ACTIVE</code> before
        /// you can access the analysis.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WhatIfAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if analysis that contains this what-if
        /// forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string WhatIfAnalysisArn
        {
            get { return this._whatIfAnalysisArn; }
            set { this._whatIfAnalysisArn = value; }
        }

        // Check to see if WhatIfAnalysisArn property is set
        internal bool IsSetWhatIfAnalysisArn()
        {
            return this._whatIfAnalysisArn != null;
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Max=300)]
        public string WhatIfForecastArn
        {
            get { return this._whatIfForecastArn; }
            set { this._whatIfForecastArn = value; }
        }

        // Check to see if WhatIfForecastArn property is set
        internal bool IsSetWhatIfForecastArn()
        {
            return this._whatIfForecastArn != null;
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastName. 
        /// <para>
        /// The name of the what-if forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string WhatIfForecastName
        {
            get { return this._whatIfForecastName; }
            set { this._whatIfForecastName = value; }
        }

        // Check to see if WhatIfForecastName property is set
        internal bool IsSetWhatIfForecastName()
        {
            return this._whatIfForecastName != null;
        }

    }
}