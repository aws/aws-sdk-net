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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
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
namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// This is the response object from the CancelResourceRequest operation.
    /// </summary>
    public partial class CancelResourceRequestResponse : AmazonWebServiceResponse
    {
        private ProgressEvent _progressEvent;

        /// <summary>
        /// Gets and sets the property ProgressEvent.
        /// </summary>
        public ProgressEvent ProgressEvent
        {
            get { return this._progressEvent; }
            set { this._progressEvent = value; }
        }

        // Check to see if ProgressEvent property is set
        internal bool IsSetProgressEvent()
        {
            return this._progressEvent != null;
        }

    }
}