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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssociationExecutions operation.
    /// </summary>
    public partial class DescribeAssociationExecutionsResponse : AmazonWebServiceResponse
    {
        private List<AssociationExecution> _associationExecutions = new List<AssociationExecution>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssociationExecutions. 
        /// <para>
        /// A list of the executions for the specified association ID.
        /// </para>
        /// </summary>
        public List<AssociationExecution> AssociationExecutions
        {
            get { return this._associationExecutions; }
            set { this._associationExecutions = value; }
        }

        // Check to see if AssociationExecutions property is set
        internal bool IsSetAssociationExecutions()
        {
            return this._associationExecutions != null && this._associationExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. Use this token to get the next set
        /// of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}