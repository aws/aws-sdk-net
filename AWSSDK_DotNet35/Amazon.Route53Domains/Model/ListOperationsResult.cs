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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// The ListOperations response includes the following elements.
    /// </summary>
    public partial class ListOperationsResult : AmazonWebServiceResponse
    {
        private string _nextPageMarker;
        private List<OperationSummary> _operations = new List<OperationSummary>();


        /// <summary>
        /// Gets and sets the property NextPageMarker. 
        /// <para>
        /// If there are more operations than you specified for <code>MaxItems</code> in the request,
        /// submit another request and include the value of <code>NextPageMarker</code> in the
        /// value of <code>Marker</code>.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Parent: <code>Operations</code>
        /// </para>
        /// </summary>
        public string NextPageMarker
        {
            get { return this._nextPageMarker; }
            set { this._nextPageMarker = value; }
        }

        // Check to see if NextPageMarker property is set
        internal bool IsSetNextPageMarker()
        {
            return this._nextPageMarker != null;
        }


        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// Lists summaries of the operations.
        /// </para>
        ///  
        /// <para>
        /// Type: Complex type containing a list of operation summaries
        /// </para>
        ///  
        /// <para>
        /// Children: <code>OperationId</code>, <code>Status</code>, <code>SubmittedDate</code>,
        /// <code>Type</code>
        /// </para>
        /// </summary>
        public List<OperationSummary> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && this._operations.Count > 0; 
        }

    }
}