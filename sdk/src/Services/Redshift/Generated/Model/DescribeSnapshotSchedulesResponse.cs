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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeSnapshotSchedules operation.
    /// </summary>
    public partial class DescribeSnapshotSchedulesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<SnapshotSchedule> _snapshotSchedules = AWSConfigs.InitializeCollections ? new List<SnapshotSchedule>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned marker value in the <c>marker</c> parameter
        /// and retrying the command. If the <c>marker</c> field is empty, all response records
        /// have been retrieved for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property SnapshotSchedules. 
        /// <para>
        /// A list of SnapshotSchedules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SnapshotSchedule> SnapshotSchedules
        {
            get { return this._snapshotSchedules; }
            set { this._snapshotSchedules = value; }
        }

        // Check to see if SnapshotSchedules property is set
        internal bool IsSetSnapshotSchedules()
        {
            return this._snapshotSchedules != null && (this._snapshotSchedules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}