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
    /// This is the response object from the PromoteReadReplicaDBCluster operation.
    /// </summary>
    public partial class PromoteReadReplicaDBClusterResponse : AmazonWebServiceResponse
    {
        private DBCluster _dbCluster;

        /// <summary>
        /// Gets and sets the property DBCluster.
        /// </summary>
        public DBCluster DBCluster
        {
            get { return this._dbCluster; }
            set { this._dbCluster = value; }
        }

        // Check to see if DBCluster property is set
        internal bool IsSetDBCluster()
        {
            return this._dbCluster != null;
        }

    }
}