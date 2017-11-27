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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for Nielsen Configuration
    /// </summary>
    public partial class NielsenConfiguration
    {
        private int? _breakoutCode;
        private string _distributorId;

        /// <summary>
        /// Gets and sets the property BreakoutCode. Use Nielsen Configuration (NielsenConfiguration)
        /// to set the Nielsen measurement system breakout code. Supported values are 0, 3, 7,
        /// and 9.
        /// </summary>
        public int BreakoutCode
        {
            get { return this._breakoutCode.GetValueOrDefault(); }
            set { this._breakoutCode = value; }
        }

        // Check to see if BreakoutCode property is set
        internal bool IsSetBreakoutCode()
        {
            return this._breakoutCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistributorId. Use Distributor ID (DistributorID) to specify
        /// the distributor ID that is assigned to your organization by Neilsen.
        /// </summary>
        public string DistributorId
        {
            get { return this._distributorId; }
            set { this._distributorId = value; }
        }

        // Check to see if DistributorId property is set
        internal bool IsSetDistributorId()
        {
            return this._distributorId != null;
        }

    }
}