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
    /// Container for the parameters to the AcceptQualificationRequest operation.
    /// The <c>AcceptQualificationRequest</c> operation approves a Worker's request for a
    /// Qualification. 
    /// 
    ///  
    /// <para>
    ///  Only the owner of the Qualification type can grant a Qualification request for that
    /// type. 
    /// </para>
    ///  
    /// <para>
    ///  A successful request for the <c>AcceptQualificationRequest</c> operation returns
    /// with no errors and an empty body. 
    /// </para>
    /// </summary>
    public partial class AcceptQualificationRequestRequest : AmazonMTurkRequest
    {
        private int? _integerValue;
        private string _qualificationRequestId;

        /// <summary>
        /// Gets and sets the property IntegerValue. 
        /// <para>
        ///  The value of the Qualification. You can omit this value if you are using the presence
        /// or absence of the Qualification as the basis for a HIT requirement. 
        /// </para>
        /// </summary>
        public int? IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualificationRequestId. 
        /// <para>
        /// The ID of the Qualification request, as returned by the <c>GetQualificationRequests</c>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QualificationRequestId
        {
            get { return this._qualificationRequestId; }
            set { this._qualificationRequestId = value; }
        }

        // Check to see if QualificationRequestId property is set
        internal bool IsSetQualificationRequestId()
        {
            return this._qualificationRequestId != null;
        }

    }
}