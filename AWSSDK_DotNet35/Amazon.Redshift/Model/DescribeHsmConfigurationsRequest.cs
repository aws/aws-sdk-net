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
    /// Container for the parameters to the DescribeHsmConfigurations operation.
    /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
    /// ID is            specified, returns information about all the HSM configurations owned
    /// by your AWS customer account.
    /// </summary>
    public partial class DescribeHsmConfigurationsRequest : AmazonRedshiftRequest
    {
        private string _hsmConfigurationIdentifier;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// The identifier of a specific Amazon Redshift HSM configuration to be described. If
        /// no            identifier is specified, information is returned for all HSM configurations
        ///            owned by your AWS customer account.
        /// </para>
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this._hsmConfigurationIdentifier; }
            set { this._hsmConfigurationIdentifier = value; }
        }

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this._hsmConfigurationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///             An optional parameter that specifies the starting point to return a set
        /// of response records.             When the results of a <a>DescribeHsmConfigurations</a>
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

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

    }
}