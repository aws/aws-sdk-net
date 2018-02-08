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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeBuild operation.
    /// Retrieves properties for a build. To request a build record, specify a build ID. If
    /// successful, an object containing the build properties is returned.
    /// 
    ///  
    /// <para>
    /// Build-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListBuilds</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBuild</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeBuildRequest : AmazonGameLiftRequest
    {
        private string _buildId;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// Unique identifier for a build to retrieve properties for.
        /// </para>
        /// </summary>
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

    }
}