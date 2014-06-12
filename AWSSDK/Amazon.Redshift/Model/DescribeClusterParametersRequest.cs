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
    /// Returns a detailed list of parameters contained within the specified Amazon
    /// Redshift         parameter group. For each parameter the response includes information
    ///         such as parameter name, description,         data type, value, whether the
    /// parameter value is modifiable, and so on.        
    /// 
    ///         
    /// <para>
    /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
    ///            For example, to retrieve parameters that were modified by a user action
    /// such as from             <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i>
    /// equal to <i>user</i>.
    /// </para>
    ///         
    /// <para>
    /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
    /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeClusterParametersRequest : AmazonWebServiceRequest
    {
        private string _marker;
        private int? _maxRecords;
        private string _parameterGroupName;
        private string _source;


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///             An optional parameter that specifies the starting point to return a set
        /// of response records.             When the results of a <a>DescribeClusterParameters</a>
        /// request exceed the value specified in <code>MaxRecords</code>,             AWS returns
        /// a value in the <code>Marker</code> field of the response. You can retrieve the next
        /// set of             response records by providing the returned marker value in the
        /// <code>Marker</code> parameter and             retrying the request.        
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParametersRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///             The maximum number of response records to return in each call.       
        ///      If the number of remaining response records exceeds the specified <code>MaxRecords</code>
        /// value,             a value is returned in a <code>marker</code> field of the response.
        ///             You can retrieve the next set of records by retrying the command with
        /// the returned marker value.        
        /// </para>
        ///         
        /// <para>
        /// Default: <code>100</code>
        /// </para>
        ///         
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParametersRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        ///         The name of a cluster parameter group for which to return details.       
        /// 
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }


        /// <summary>
        /// Sets the ParameterGroupName property
        /// </summary>
        /// <param name="parameterGroupName">The value to set for the ParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParametersRequest WithParameterGroupName(string parameterGroupName)
        {
            this._parameterGroupName = parameterGroupName;
            return this;
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        ///             The parameter types to return. Specify <code>user</code> to show parameters
        /// that are different form the        default. Similarly, specify <code>engine-default</code>
        /// to show parameters that are the same as the default            parameter group.  
        ///      
        /// </para>
        ///         
        /// <para>
        /// Default: All parameter types returned.
        /// </para>
        ///                 
        /// <para>
        /// Valid Values: <code>user</code> | <code>engine-default</code>
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }


        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterParametersRequest WithSource(string source)
        {
            this._source = source;
            return this;
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}