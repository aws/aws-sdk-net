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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides a summary of the Explainability properties used in the <a>ListExplainabilities</a>
    /// operation. To get a complete set of properties, call the <a>DescribeExplainability</a>
    /// operation, and provide the listed <c>ExplainabilityArn</c>.
    /// </summary>
    public partial class ExplainabilitySummary
    {
        private DateTime? _creationTime;
        private string _explainabilityArn;
        private ExplainabilityConfig _explainabilityConfig;
        private string _explainabilityName;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _resourceArn;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the Explainability was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExplainabilityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ExplainabilityArn
        {
            get { return this._explainabilityArn; }
            set { this._explainabilityArn = value; }
        }

        // Check to see if ExplainabilityArn property is set
        internal bool IsSetExplainabilityArn()
        {
            return this._explainabilityArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExplainabilityConfig. 
        /// <para>
        /// The configuration settings that define the granularity of time series and time points
        /// for the Explainability.
        /// </para>
        /// </summary>
        public ExplainabilityConfig ExplainabilityConfig
        {
            get { return this._explainabilityConfig; }
            set { this._explainabilityConfig = value; }
        }

        // Check to see if ExplainabilityConfig property is set
        internal bool IsSetExplainabilityConfig()
        {
            return this._explainabilityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExplainabilityName. 
        /// <para>
        /// The name of the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ExplainabilityName
        {
            get { return this._explainabilityName; }
            set { this._explainabilityName = value; }
        }

        // Check to see if ExplainabilityName property is set
        internal bool IsSetExplainabilityName()
        {
            return this._explainabilityName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - The <c>CreationTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPED</c> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> or <c>CREATE_FAILED</c> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
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
        /// Information about any errors that may have occurred during the Explainability creation
        /// process.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Predictor or Forecast used to create the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Explainability. States include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> </ul>
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

    }
}