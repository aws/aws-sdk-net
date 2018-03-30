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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the CreateSoftwareUpdateJob operation.
    /// </summary>
    public partial class CreateSoftwareUpdateJobResponse : AmazonWebServiceResponse
    {
        private string _iotJobArn;
        private string _iotJobId;

        /// <summary>
        /// Gets and sets the property IotJobArn. The IoT Job ARN corresponding to this update.
        /// </summary>
        public string IotJobArn
        {
            get { return this._iotJobArn; }
            set { this._iotJobArn = value; }
        }

        // Check to see if IotJobArn property is set
        internal bool IsSetIotJobArn()
        {
            return this._iotJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property IotJobId. The IoT Job Id corresponding to this update.
        /// </summary>
        public string IotJobId
        {
            get { return this._iotJobId; }
            set { this._iotJobId = value; }
        }

        // Check to see if IotJobId property is set
        internal bool IsSetIotJobId()
        {
            return this._iotJobId != null;
        }

    }
}