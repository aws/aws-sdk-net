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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure for the output.
    /// </summary>
    public partial class GetQueryStateResponse : AmazonWebServiceResponse
    {
        private string _error;
        private QueryStateString _state;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error message when the operation fails.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of a query previously submitted. The possible states are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING: the query is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WORKUNITS_AVAILABLE: some work units are ready for retrieval and execution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FINISHED: the query planning finished successfully, and all work units are ready for
        /// retrieval and execution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR: an error occurred with the query, such as an invalid query ID or a backend
        /// error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryStateString State
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