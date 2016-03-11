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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the CreateClusterParameterGroup operation.
    /// </summary>
    public partial class CreateClusterParameterGroupResponse : AmazonWebServiceResponse
    {
        private ClusterParameterGroup _clusterParameterGroup;

        /// <summary>
        /// Gets and sets the property ClusterParameterGroup.
        /// </summary>
        public ClusterParameterGroup ClusterParameterGroup
        {
            get { return this._clusterParameterGroup; }
            set { this._clusterParameterGroup = value; }
        }

        // Check to see if ClusterParameterGroup property is set
        internal bool IsSetClusterParameterGroup()
        {
            return this._clusterParameterGroup != null;
        }

    }
}