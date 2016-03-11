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
    /// 
    /// </summary>
    public partial class DescribeSnapshotCopyGrantsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<SnapshotCopyGrant> _snapshotCopyGrants = new List<SnapshotCopyGrant>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <code>DescribeSnapshotCopyGrant</code> request exceed
        /// the value specified in <code>MaxRecords</code>, AWS returns a value in the <code>Marker</code>
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned marker value in the <code>Marker</code> parameter and retrying the request.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: You can specify either the <b>SnapshotCopyGrantName</b> parameter or
        /// the <b>Marker</b> parameter, but not both. 
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
        /// Gets and sets the property SnapshotCopyGrants. 
        /// <para>
        /// The list of <code>SnapshotCopyGrant</code> objects.
        /// </para>
        /// </summary>
        public List<SnapshotCopyGrant> SnapshotCopyGrants
        {
            get { return this._snapshotCopyGrants; }
            set { this._snapshotCopyGrants = value; }
        }

        // Check to see if SnapshotCopyGrants property is set
        internal bool IsSetSnapshotCopyGrants()
        {
            return this._snapshotCopyGrants != null && this._snapshotCopyGrants.Count > 0; 
        }

    }
}