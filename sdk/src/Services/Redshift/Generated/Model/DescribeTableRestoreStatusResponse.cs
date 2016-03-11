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
    /// This is the response object from the DescribeTableRestoreStatus operation.
    /// </summary>
    public partial class DescribeTableRestoreStatusResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<TableRestoreStatus> _tableRestoreStatusDetails = new List<TableRestoreStatus>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that can be used in a subsequent <a>DescribeTableRestoreStatus</a>
        /// request.
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
        /// Gets and sets the property TableRestoreStatusDetails. 
        /// <para>
        /// A list of status details for one or more table restore requests. 
        /// </para>
        /// </summary>
        public List<TableRestoreStatus> TableRestoreStatusDetails
        {
            get { return this._tableRestoreStatusDetails; }
            set { this._tableRestoreStatusDetails = value; }
        }

        // Check to see if TableRestoreStatusDetails property is set
        internal bool IsSetTableRestoreStatusDetails()
        {
            return this._tableRestoreStatusDetails != null && this._tableRestoreStatusDetails.Count > 0; 
        }

    }
}