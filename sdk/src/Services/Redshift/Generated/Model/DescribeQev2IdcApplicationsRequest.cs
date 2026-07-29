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
    /// Container for the parameters to the DescribeQev2IdcApplications operation.
    /// Lists the Amazon Redshift Query Editor (QEV2) IAM Identity Center applications. To
    /// retrieve additional results, use the MaxRecords and Marker parameters.
    /// </summary>
    public partial class DescribeQev2IdcApplicationsRequest : AmazonRedshiftRequest
    {
        private string _marker;
        private int? _maxRecords;
        private string _qev2IdcApplicationArn;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned marker value in the Marker parameter and
        /// retrying the command. If the Marker field is empty, all response records have been
        /// retrieved for the request. 
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
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified MaxRecords value, a value is returned in a
        /// marker field of the response. You can retrieve the next set of records by retrying
        /// the command with the returned marker value.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Qev2IdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Amazon Redshift Query Editor (QEV2) application
        /// that integrates with IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Qev2IdcApplicationArn
        {
            get { return this._qev2IdcApplicationArn; }
            set { this._qev2IdcApplicationArn = value; }
        }

        // Check to see if Qev2IdcApplicationArn property is set
        internal bool IsSetQev2IdcApplicationArn()
        {
            return this._qev2IdcApplicationArn != null;
        }

    }
}