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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// A set of filters by which to return Recovery Snapshots.
    /// </summary>
    public partial class DescribeRecoverySnapshotsRequestFilters
    {
        private string _fromDateTime;
        private string _toDateTime;

        /// <summary>
        /// Gets and sets the property FromDateTime. 
        /// <para>
        /// The start date in a date range query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string FromDateTime
        {
            get { return this._fromDateTime; }
            set { this._fromDateTime = value; }
        }

        // Check to see if FromDateTime property is set
        internal bool IsSetFromDateTime()
        {
            return this._fromDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ToDateTime. 
        /// <para>
        /// The end date in a date range query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ToDateTime
        {
            get { return this._toDateTime; }
            set { this._toDateTime = value; }
        }

        // Check to see if ToDateTime property is set
        internal bool IsSetToDateTime()
        {
            return this._toDateTime != null;
        }

    }
}