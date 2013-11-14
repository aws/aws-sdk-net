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
    /// Container for the parameters to the DescribeClusterParameterGroups operation.
    /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
    /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
    /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
    /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class DescribeClusterParameterGroupsRequest : AmazonRedshiftRequest
    {
        private string parameterGroupName;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The name of a specific parameter group for which to return details. By default, details about all parameter groups and the default parameter
        /// group are returned.
        ///  
        /// </summary>
        public string ParameterGroupName
        {
            get { return this.parameterGroupName; }
            set { this.parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this.parameterGroupName != null;
        }

        /// <summary>
        /// The maximum number of parameter group records to include in the response. If more records exist than the specified <c>MaxRecords</c> value,
        /// the response includes a marker that you can use in a subsequent <a>DescribeClusterParameterGroups</a> request to retrieve the next set of
        /// records. Default: <c>100</c> Constraints: Value must be at least 20 and no more than 100.
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
        /// An optional marker returned by a previous <a>DescribeClusterParameterGroups</a> request to indicate the first parameter group that the
        /// current request will return.
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
    
