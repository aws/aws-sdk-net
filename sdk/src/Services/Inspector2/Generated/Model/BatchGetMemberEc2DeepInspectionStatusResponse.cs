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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the BatchGetMemberEc2DeepInspectionStatus operation.
    /// </summary>
    public partial class BatchGetMemberEc2DeepInspectionStatusResponse : AmazonWebServiceResponse
    {
        private List<MemberAccountEc2DeepInspectionStatusState> _accountIds = AWSConfigs.InitializeCollections ? new List<MemberAccountEc2DeepInspectionStatusState>() : null;
        private List<FailedMemberAccountEc2DeepInspectionStatusState> _failedAccountIds = AWSConfigs.InitializeCollections ? new List<FailedMemberAccountEc2DeepInspectionStatusState>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// An array of objects that provide details on the activation status of Amazon Inspector
        /// deep inspection for each of the requested accounts. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<MemberAccountEc2DeepInspectionStatusState> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedAccountIds. 
        /// <para>
        /// An array of objects that provide details on any accounts that failed to activate Amazon
        /// Inspector deep inspection and why. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<FailedMemberAccountEc2DeepInspectionStatusState> FailedAccountIds
        {
            get { return this._failedAccountIds; }
            set { this._failedAccountIds = value; }
        }

        // Check to see if FailedAccountIds property is set
        internal bool IsSetFailedAccountIds()
        {
            return this._failedAccountIds != null && (this._failedAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}