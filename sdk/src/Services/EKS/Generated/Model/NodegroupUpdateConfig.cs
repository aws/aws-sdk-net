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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NodegroupUpdateConfig
    {
        private int? _maxUnavailable;
        private int? _maxUnavailablePercentage;

        /// <summary>
        /// Gets and sets the property MaxUnavailable.
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxUnavailable
        {
            get { return this._maxUnavailable.GetValueOrDefault(); }
            set { this._maxUnavailable = value; }
        }

        // Check to see if MaxUnavailable property is set
        internal bool IsSetMaxUnavailable()
        {
            return this._maxUnavailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxUnavailablePercentage.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxUnavailablePercentage
        {
            get { return this._maxUnavailablePercentage.GetValueOrDefault(); }
            set { this._maxUnavailablePercentage = value; }
        }

        // Check to see if MaxUnavailablePercentage property is set
        internal bool IsSetMaxUnavailablePercentage()
        {
            return this._maxUnavailablePercentage.HasValue; 
        }

    }
}