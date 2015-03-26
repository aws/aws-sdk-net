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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeRaidArrays</code> request.
    /// </summary>
    public partial class DescribeRaidArraysResponse : AmazonWebServiceResponse
    {
        private List<RaidArray> _raidArrays = new List<RaidArray>();

        /// <summary>
        /// Gets and sets the property RaidArrays. 
        /// <para>
        /// A <code>RaidArrays</code> object that describes the specified RAID arrays.
        /// </para>
        /// </summary>
        public List<RaidArray> RaidArrays
        {
            get { return this._raidArrays; }
            set { this._raidArrays = value; }
        }

        // Check to see if RaidArrays property is set
        internal bool IsSetRaidArrays()
        {
            return this._raidArrays != null && this._raidArrays.Count > 0; 
        }

    }
}