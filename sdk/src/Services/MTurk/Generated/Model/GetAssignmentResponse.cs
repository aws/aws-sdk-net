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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the GetAssignment operation.
    /// </summary>
    public partial class GetAssignmentResponse : AmazonWebServiceResponse
    {
        private Assignment _assignment;
        private HIT _hit;

        /// <summary>
        /// Gets and sets the property Assignment. 
        /// <para>
        ///  The assignment. The response includes one Assignment element. 
        /// </para>
        /// </summary>
        public Assignment Assignment
        {
            get { return this._assignment; }
            set { this._assignment = value; }
        }

        // Check to see if Assignment property is set
        internal bool IsSetAssignment()
        {
            return this._assignment != null;
        }

        /// <summary>
        /// Gets and sets the property HIT. 
        /// <para>
        ///  The HIT associated with this assignment. The response includes one HIT element.
        /// </para>
        /// </summary>
        public HIT HIT
        {
            get { return this._hit; }
            set { this._hit = value; }
        }

        // Check to see if HIT property is set
        internal bool IsSetHIT()
        {
            return this._hit != null;
        }

    }
}