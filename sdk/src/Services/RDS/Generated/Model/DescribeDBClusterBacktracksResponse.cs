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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>DescribeDBClusterBacktracks</a>
    /// action.
    /// </summary>
    public partial class DescribeDBClusterBacktracksResponse : AmazonWebServiceResponse
    {
        private List<DBClusterBacktrack> _dbClusterBacktracks = new List<DBClusterBacktrack>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property DBClusterBacktracks. 
        /// <para>
        /// Contains a list of backtracks for the user.
        /// </para>
        /// </summary>
        public List<DBClusterBacktrack> DBClusterBacktracks
        {
            get { return this._dbClusterBacktracks; }
            set { this._dbClusterBacktracks = value; }
        }

        // Check to see if DBClusterBacktracks property is set
        internal bool IsSetDBClusterBacktracks()
        {
            return this._dbClusterBacktracks != null && this._dbClusterBacktracks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that can be used in a subsequent <a>DescribeDBClusterBacktracks</a>
        /// request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}