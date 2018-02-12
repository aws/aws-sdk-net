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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeAggregateIdFormat operation.
    /// </summary>
    public partial class DescribeAggregateIdFormatResponse : AmazonWebServiceResponse
    {
        private List<IdFormat> _statuses = new List<IdFormat>();
        private bool? _useLongIdsAggregated;

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Information about each resource's ID format.
        /// </para>
        /// </summary>
        public List<IdFormat> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && this._statuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseLongIdsAggregated. 
        /// <para>
        /// Indicates whether all resource types in the region are configured to use longer IDs.
        /// This value is only <code>true</code> if all users are configured to use longer IDs
        /// for all resources types in the region.
        /// </para>
        /// </summary>
        public bool UseLongIdsAggregated
        {
            get { return this._useLongIdsAggregated.GetValueOrDefault(); }
            set { this._useLongIdsAggregated = value; }
        }

        // Check to see if UseLongIdsAggregated property is set
        internal bool IsSetUseLongIdsAggregated()
        {
            return this._useLongIdsAggregated.HasValue; 
        }

    }
}