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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The information about the container used for a job run or a managed endpoint.
    /// </summary>
    public partial class ContainerInfo
    {
        private EksInfo _eksInfo;

        /// <summary>
        /// Gets and sets the property EksInfo. 
        /// <para>
        /// The information about the Amazon EKS cluster.
        /// </para>
        /// </summary>
        public EksInfo EksInfo
        {
            get { return this._eksInfo; }
            set { this._eksInfo = value; }
        }

        // Check to see if EksInfo property is set
        internal bool IsSetEksInfo()
        {
            return this._eksInfo != null;
        }

    }
}