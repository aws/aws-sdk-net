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
    /// This is the response object from the GetQualificationScore operation.
    /// </summary>
    public partial class GetQualificationScoreResponse : AmazonWebServiceResponse
    {
        private Qualification _qualification;

        /// <summary>
        /// Gets and sets the property Qualification. 
        /// <para>
        ///  The Qualification data structure of the Qualification assigned to a user, including
        /// the Qualification type and the value (score). 
        /// </para>
        /// </summary>
        public Qualification Qualification
        {
            get { return this._qualification; }
            set { this._qualification = value; }
        }

        // Check to see if Qualification property is set
        internal bool IsSetQualification()
        {
            return this._qualification != null;
        }

    }
}