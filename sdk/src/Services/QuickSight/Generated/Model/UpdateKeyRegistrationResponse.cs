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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateKeyRegistration operation.
    /// </summary>
    public partial class UpdateKeyRegistrationResponse : AmazonWebServiceResponse
    {
        private List<FailedKeyRegistrationEntry> _failedKeyRegistration = AWSConfigs.InitializeCollections ? new List<FailedKeyRegistrationEntry>() : null;
        private string _requestId;
        private List<SuccessfulKeyRegistrationEntry> _successfulKeyRegistration = AWSConfigs.InitializeCollections ? new List<SuccessfulKeyRegistrationEntry>() : null;

        /// <summary>
        /// Gets and sets the property FailedKeyRegistration. 
        /// <para>
        /// A list of all customer managed key registrations that failed to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedKeyRegistrationEntry> FailedKeyRegistration
        {
            get { return this._failedKeyRegistration; }
            set { this._failedKeyRegistration = value; }
        }

        // Check to see if FailedKeyRegistration property is set
        internal bool IsSetFailedKeyRegistration()
        {
            return this._failedKeyRegistration != null && (this._failedKeyRegistration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessfulKeyRegistration. 
        /// <para>
        /// A list of all customer managed key registrations that were successfully updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuccessfulKeyRegistrationEntry> SuccessfulKeyRegistration
        {
            get { return this._successfulKeyRegistration; }
            set { this._successfulKeyRegistration = value; }
        }

        // Check to see if SuccessfulKeyRegistration property is set
        internal bool IsSetSuccessfulKeyRegistration()
        {
            return this._successfulKeyRegistration != null && (this._successfulKeyRegistration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}