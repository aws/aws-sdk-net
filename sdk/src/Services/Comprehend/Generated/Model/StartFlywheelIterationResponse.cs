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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the StartFlywheelIteration operation.
    /// </summary>
    public partial class StartFlywheelIterationResponse : AmazonWebServiceResponse
    {
        private string _flywheelArn;
        private string _flywheelIterationId;

        /// <summary>
        /// Gets and sets the property FlywheelArn.
        /// </summary>
        [AWSProperty(Max=256)]
        public string FlywheelArn
        {
            get { return this._flywheelArn; }
            set { this._flywheelArn = value; }
        }

        // Check to see if FlywheelArn property is set
        internal bool IsSetFlywheelArn()
        {
            return this._flywheelArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelIterationId.
        /// </summary>
        [AWSProperty(Max=63)]
        public string FlywheelIterationId
        {
            get { return this._flywheelIterationId; }
            set { this._flywheelIterationId = value; }
        }

        // Check to see if FlywheelIterationId property is set
        internal bool IsSetFlywheelIterationId()
        {
            return this._flywheelIterationId != null;
        }

    }
}