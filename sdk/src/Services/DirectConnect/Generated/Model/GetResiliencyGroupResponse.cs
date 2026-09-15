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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the GetResiliencyGroup operation.
    /// </summary>
    public partial class GetResiliencyGroupResponse : AmazonWebServiceResponse
    {
        private ResiliencyGroup _resiliencyGroup;

        /// <summary>
        /// Gets and sets the property ResiliencyGroup. 
        /// <para>
        /// Information about the resiliency group.
        /// </para>
        /// </summary>
        public ResiliencyGroup ResiliencyGroup
        {
            get { return this._resiliencyGroup; }
            set { this._resiliencyGroup = value; }
        }

        // Check to see if ResiliencyGroup property is set
        internal bool IsSetResiliencyGroup()
        {
            return this._resiliencyGroup != null;
        }

    }
}