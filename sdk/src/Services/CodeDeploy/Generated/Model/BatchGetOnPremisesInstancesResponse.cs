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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a batch get on-premises instances operation.
    /// </summary>
    public partial class BatchGetOnPremisesInstancesResponse : AmazonWebServiceResponse
    {
        private List<InstanceInfo> _instanceInfos = new List<InstanceInfo>();

        /// <summary>
        /// Gets and sets the property InstanceInfos. 
        /// <para>
        /// Information about the on-premises instances.
        /// </para>
        /// </summary>
        public List<InstanceInfo> InstanceInfos
        {
            get { return this._instanceInfos; }
            set { this._instanceInfos = value; }
        }

        // Check to see if InstanceInfos property is set
        internal bool IsSetInstanceInfos()
        {
            return this._instanceInfos != null && this._instanceInfos.Count > 0; 
        }

    }
}