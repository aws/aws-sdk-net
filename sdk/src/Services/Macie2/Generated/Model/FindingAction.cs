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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an action that occurred for a resource and produced a policy
    /// finding.
    /// </summary>
    public partial class FindingAction
    {
        private FindingActionType _actionType;
        private ApiCallDetails _apiCallDetails;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action that occurred for the affected resource. This value is typically
        /// AWS_API_CALL, which indicates that an entity invoked an API operation for the resource.
        /// </para>
        /// </summary>
        public FindingActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ApiCallDetails. 
        /// <para>
        /// The invocation details of the API operation that an entity invoked for the affected
        /// resource, if the value for the actionType property is AWS_API_CALL.
        /// </para>
        /// </summary>
        public ApiCallDetails ApiCallDetails
        {
            get { return this._apiCallDetails; }
            set { this._apiCallDetails = value; }
        }

        // Check to see if ApiCallDetails property is set
        internal bool IsSetApiCallDetails()
        {
            return this._apiCallDetails != null;
        }

    }
}