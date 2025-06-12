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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the GetDimensionKeyDetails operation.
    /// Get the attributes of the specified dimension group for a DB instance or data source.
    /// For example, if you specify a SQL ID, <c>GetDimensionKeyDetails</c> retrieves the
    /// full text of the dimension <c>db.sql.statement</c> associated with this ID. This operation
    /// is useful because <c>GetResourceMetrics</c> and <c>DescribeDimensionKeys</c> don't
    /// support retrieval of large SQL statement text, lock snapshots, and execution plans.
    /// </summary>
    public partial class GetDimensionKeyDetailsRequest : AmazonPIRequest
    {
        private string _group;
        private string _groupIdentifier;
        private string _identifier;
        private List<string> _requestedDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ServiceType _serviceType;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the dimension group. Performance Insights searches the specified group
        /// for the dimension group ID. The following group name values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.execution_plan</c> (Amazon RDS and Aurora only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.lock_snapshot</c> (Aurora only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.query</c> (Amazon DocumentDB only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql</c> (Amazon RDS and Aurora only)
        /// </para>
        ///  </li> </ul>
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
        /// group <c>db.sql</c>, the group ID is <c>db.sql.id</c>. The following group ID values
        /// are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.execution_plan.id</c> for dimension group <c>db.execution_plan</c> (Aurora
        /// and RDS only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql.id</c> for dimension group <c>db.sql</c> (Aurora and RDS only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.query.id</c> for dimension group <c>db.query</c> (DocumentDB only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the dimension group <c>db.lock_snapshot</c>, the <c>GroupIdentifier</c> is the
        /// epoch timestamp when Performance Insights captured the snapshot, in seconds. You can
        /// retrieve this value with the <c>GetResourceMetrics</c> operation for a 1 second period.
        /// </para>
        ///  </li> </ul>
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
        /// and unique within an Amazon Web Services Region. When a DB instance is the data source,
        /// specify its <c>DbiResourceId</c> value. For example, specify <c>db-ABCDEFGHIJKLMNOPQRSTU1VW2X</c>.
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
        /// If you don't specify this parameter, Performance Insights returns all dimension data
        /// within the specified dimension group. Specify dimension names for the following dimension
        /// groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.execution_plan</c> - Specify the dimension name <c>db.execution_plan.raw_plan</c>
        /// or the short dimension name <c>raw_plan</c> (Amazon RDS and Aurora only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.lock_snapshot</c> - Specify the dimension name <c>db.lock_snapshot.lock_trees</c>
        /// or the short dimension name <c>lock_trees</c>. (Aurora only)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sql</c> - Specify either the full dimension name <c>db.sql.statement</c> or
        /// the short dimension name <c>statement</c> (Aurora and RDS only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.query</c> - Specify either the full dimension name <c>db.query.statement</c>
        /// or the short dimension name <c>statement</c> (DocumentDB only).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._requestedDimensions != null && (this._requestedDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights returns data. The only
        /// valid value is <c>RDS</c>.
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