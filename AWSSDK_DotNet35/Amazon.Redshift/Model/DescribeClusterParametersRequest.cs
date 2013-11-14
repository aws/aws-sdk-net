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
    /// Container for the parameters to the DescribeClusterParameters operation.
    /// <para> Returns a detailed list of parameters contained within the specified Amazon Redshift parameter group. For each parameter the response
    /// includes information such as parameter name, description, data type, value, whether the parameter value is modifiable, and so on. </para>
    /// <para>You can specify <i>source</i> filter to retrieve parameters of only specific type. For example, to retrieve parameters that were
    /// modified by a user action such as from ModifyClusterParameterGroup, you can specify <i>source</i> equal to <i>user</i> .</para> <para> For
    /// more information about managing parameter groups, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
    /// <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class DescribeClusterParametersRequest : AmazonRedshiftRequest
    {
        private string parameterGroupName;
        private string source;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The name of a cluster parameter group for which to return details.
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
        /// The parameter types to return. Specify <c>user</c> to show parameters that are different form the default. Similarly, specify
        /// <c>engine-default</c> to show parameters that are the same as the default parameter group. Default: All parameter types returned. Valid
        /// Values: <c>user</c> | <c>engine-default</c>
        ///  
        /// </summary>
        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this.source != null;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more records exist than the specified <c>MaxRecords</c> value, response
        /// includes a marker that you can specify in your subsequent request to retrieve remaining result. Default: <c>100</c> Constraints: Value must
        /// be at least 20 and no more than 100.
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
        /// An optional marker returned from a previous <b>DescribeClusterParameters</b> request. If this parameter is specified, the response includes
        /// only records beyond the specified marker, up to the value specified by <c>MaxRecords</c>.
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
    
