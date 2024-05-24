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
    /// Container for the parameters to the DeleteQualificationType operation.
    /// The <c>DeleteQualificationType</c> deletes a Qualification type and deletes any HIT
    /// types that are associated with the Qualification type. 
    /// 
    ///  
    /// <para>
    /// This operation does not revoke Qualifications already assigned to Workers because
    /// the Qualifications might be needed for active HITs. If there are any pending requests
    /// for the Qualification type, Amazon Mechanical Turk rejects those requests. After you
    /// delete a Qualification type, you can no longer use it to create HITs or HIT types.
    /// </para>
    ///  <note> 
    /// <para>
    /// DeleteQualificationType must wait for all the HITs that use the deleted Qualification
    /// type to be deleted before completing. It may take up to 48 hours before DeleteQualificationType
    /// completes and the unique name of the Qualification type is available for reuse with
    /// CreateQualificationType.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteQualificationTypeRequest : AmazonMTurkRequest
    {
        private string _qualificationTypeId;

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        /// The ID of the QualificationType to dispose.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string QualificationTypeId
        {
            get { return this._qualificationTypeId; }
            set { this._qualificationTypeId = value; }
        }

        // Check to see if QualificationTypeId property is set
        internal bool IsSetQualificationTypeId()
        {
            return this._qualificationTypeId != null;
        }

    }
}