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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// This is the response object from the CreateIndex operation.
    /// </summary>
    public partial class CreateIndexResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private IndexState _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the new local index for the Region. You can reference this ARN in IAM permission
        /// policies to authorize the following operations: <a>DeleteIndex</a> | <a>GetIndex</a>
        /// | <a>UpdateIndexType</a> | <a>CreateView</a> 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and timestamp when the index was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates the current state of the index. You can check for changes to the state for
        /// asynchronous operations by calling the <a>GetIndex</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The state can remain in the <c>CREATING</c> or <c>UPDATING</c> state for several hours
        /// as Resource Explorer discovers the information about your resources and populates
        /// the index.
        /// </para>
        ///  </note>
        /// </summary>
        public IndexState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}