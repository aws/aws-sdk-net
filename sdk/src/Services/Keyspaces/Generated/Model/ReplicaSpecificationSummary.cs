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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The Region-specific settings of a multi-Region table in the specified Amazon Web Services
    /// Region.
    /// 
    ///  
    /// <para>
    /// If the multi-Region table is using provisioned capacity and has optional auto scaling
    /// policies configured, note that the Region specific summary returns both read and write
    /// capacity settings. But only Region specific read capacity settings can be configured
    /// for a multi-Region table. In a multi-Region table, your write capacity units will
    /// be synced across all Amazon Web Services Regions to ensure that there is enough capacity
    /// to replicate write events across Regions.
    /// </para>
    /// </summary>
    public partial class ReplicaSpecificationSummary
    {
        private CapacitySpecificationSummary _capacitySpecification;
        private string _region;
        private TableStatus _status;

        /// <summary>
        /// Gets and sets the property CapacitySpecification.
        /// </summary>
        public CapacitySpecificationSummary CapacitySpecification
        {
            get { return this._capacitySpecification; }
            set { this._capacitySpecification = value; }
        }

        // Check to see if CapacitySpecification property is set
        internal bool IsSetCapacitySpecification()
        {
            return this._capacitySpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=25)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the multi-Region table in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        public TableStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}