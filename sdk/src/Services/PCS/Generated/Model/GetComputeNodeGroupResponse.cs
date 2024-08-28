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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// This is the response object from the GetComputeNodeGroup operation.
    /// </summary>
    public partial class GetComputeNodeGroupResponse : AmazonWebServiceResponse
    {
        private ComputeNodeGroup _computeNodeGroup;

        /// <summary>
        /// Gets and sets the property ComputeNodeGroup.
        /// </summary>
        public ComputeNodeGroup ComputeNodeGroup
        {
            get { return this._computeNodeGroup; }
            set { this._computeNodeGroup = value; }
        }

        // Check to see if ComputeNodeGroup property is set
        internal bool IsSetComputeNodeGroup()
        {
            return this._computeNodeGroup != null;
        }

    }
}