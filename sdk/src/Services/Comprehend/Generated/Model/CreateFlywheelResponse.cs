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
    /// This is the response object from the CreateFlywheel operation.
    /// </summary>
    public partial class CreateFlywheelResponse : AmazonWebServiceResponse
    {
        private string _activeModelArn;
        private string _flywheelArn;

        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ActiveModelArn
        {
            get { return this._activeModelArn; }
            set { this._activeModelArn = value; }
        }

        // Check to see if ActiveModelArn property is set
        internal bool IsSetActiveModelArn()
        {
            return this._activeModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel.
        /// </para>
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

    }
}