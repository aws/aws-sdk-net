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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the UpdateFlow operation.
    /// </summary>
    public partial class UpdateFlowResponse : AmazonWebServiceResponse
    {
        private Flow _flow;

        /// <summary>
        /// Gets and sets the property Flow. 
        /// <para>
        ///  The updated flow. 
        /// </para>
        /// </summary>
        public Flow Flow
        {
            get { return this._flow; }
            set { this._flow = value; }
        }

        // Check to see if Flow property is set
        internal bool IsSetFlow()
        {
            return this._flow != null;
        }

    }
}