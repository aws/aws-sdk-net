/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the GetDimensionKeyDetails operation.
    /// Get the attributes of the specified dimension group for a DB instance or data source.
    /// For example, if you specify a SQL ID, <code>GetDimensionKeyDetails</code> retrieves
    /// the full text of the dimension <code>db.sql.statement</code> associated with this
    /// ID. This operation is useful because <code>GetResourceMetrics</code> and <code>DescribeDimensionKeys</code>
    /// don't support retrieval of large SQL statement text.
    /// </summary>
    public partial class GetDimensionKeyDetailsRequest : AmazonPIRequest
    {
        private string _group;
        private string _groupIdentifier;
        private string _identifier;
        private List<string> _requestedDimensions = new List<string>();
        private ServiceType _serviceType;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the dimension group. The only valid value is <code>db.sql</code>. Performance
        /// Insights searches the specified group for the dimension group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// The ID of the dimension group from which to retrieve dimension details. For dimension
        /// group <code>db.sql</code>, the group ID is <code>db.sql.id</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID for a data source from which to gather dimension data. This ID must be immutable
        /// and unique within an AWS Region. When a DB instance is the data source, specify its
        /// <code>DbiResourceId</code> value. For example, specify <code>db-ABCDEFGHIJKLMNOPQRSTU1VW2X</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedDimensions. 
        /// <para>
        /// A list of dimensions to retrieve the detail data for within the given dimension group.
        /// For the dimension group <code>db.sql</code>, specify either the full dimension name
        /// <code>db.sql.statement</code> or the short dimension name <code>statement</code>.
        /// If you don't specify this parameter, Performance Insights returns all dimension data
        /// within the specified dimension group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> RequestedDimensions
        {
            get { return this._requestedDimensions; }
            set { this._requestedDimensions = value; }
        }

        // Check to see if RequestedDimensions property is set
        internal bool IsSetRequestedDimensions()
        {
            return this._requestedDimensions != null && this._requestedDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The AWS service for which Performance Insights returns data. The only valid value
        /// is <code>RDS</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

    }
}