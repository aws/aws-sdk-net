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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkGroup operation.
    /// Deletes the workgroup with the specified name. The primary workgroup cannot be deleted.
    /// </summary>
    public partial class DeleteWorkGroupRequest : AmazonAthenaRequest
    {
        private bool? _recursiveDeleteOption;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property RecursiveDeleteOption. 
        /// <para>
        /// The option to delete the workgroup and its contents even if the workgroup contains
        /// any named queries, query executions, or notebooks.
        /// </para>
        /// </summary>
        public bool RecursiveDeleteOption
        {
            get { return this._recursiveDeleteOption.GetValueOrDefault(); }
            set { this._recursiveDeleteOption = value; }
        }

        // Check to see if RecursiveDeleteOption property is set
        internal bool IsSetRecursiveDeleteOption()
        {
            return this._recursiveDeleteOption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The unique name of the workgroup to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}