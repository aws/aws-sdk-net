/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeDefaultClusterParameters operation.
    /// <para> Returns a list of parameter settings for the specified parameter group family. </para> <para> For more information about managing
    /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift
    /// Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class DescribeDefaultClusterParametersRequest : AmazonRedshiftRequest
    {
        private string parameterGroupFamily;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The name of the cluster parameter group family.
        ///  
        /// </summary>
        public string ParameterGroupFamily
        {
            get { return this.parameterGroupFamily; }
            set { this.parameterGroupFamily = value; }
        }

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this.parameterGroupFamily != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, a marker is
        /// included in the response so that the remaining results may be retrieved. Default: <c>100</c> Constraints: Value must be at least 20 and no
        /// more than 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional marker returned from a previous <b>DescribeDefaultClusterParameters</b> request. If this parameter is specified, the response
        /// includes only records beyond the marker, up to the value specified by <c>MaxRecords</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
