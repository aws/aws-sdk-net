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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the DescribeNotebookExecution operation.
    /// </summary>
    public partial class DescribeNotebookExecutionResponse : AmazonWebServiceResponse
    {
        private NotebookExecution _notebookExecution;

        /// <summary>
        /// Gets and sets the property NotebookExecution. 
        /// <para>
        /// Properties of the notebook execution.
        /// </para>
        /// </summary>
        public NotebookExecution NotebookExecution
        {
            get { return this._notebookExecution; }
            set { this._notebookExecution = value; }
        }

        // Check to see if NotebookExecution property is set
        internal bool IsSetNotebookExecution()
        {
            return this._notebookExecution != null;
        }

    }
}