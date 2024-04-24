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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The configuration of an ML Detect Security Profile.
    /// </summary>
    public partial class MachineLearningDetectionConfig
    {
        private ConfidenceLevel _confidenceLevel;

        /// <summary>
        /// Gets and sets the property ConfidenceLevel. 
        /// <para>
        ///  The sensitivity of anomalous behavior evaluation. Can be <c>Low</c>, <c>Medium</c>,
        /// or <c>High</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfidenceLevel ConfidenceLevel
        {
            get { return this._confidenceLevel; }
            set { this._confidenceLevel = value; }
        }

        // Check to see if ConfidenceLevel property is set
        internal bool IsSetConfidenceLevel()
        {
            return this._confidenceLevel != null;
        }

    }
}