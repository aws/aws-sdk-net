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
    /// This is the response object from the GetSensitiveDataOccurrences operation.
    /// </summary>
    public partial class GetSensitiveDataOccurrencesResponse : AmazonWebServiceResponse
    {
        private string _error;
        private Dictionary<string, List<DetectedDataDetails>> _sensitiveDataOccurrences = AWSConfigs.InitializeCollections ? new Dictionary<string, List<DetectedDataDetails>>() : null;
        private RevealRequestStatus _status;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If an error occurred when Amazon Macie attempted to retrieve occurrences of sensitive
        /// data reported by the finding, a description of the error that occurred. This value
        /// is null if the status (status) of the request is PROCESSING or SUCCESS.
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
        /// Gets and sets the property SensitiveDataOccurrences. 
        /// <para>
        /// A map that specifies 1-100 types of sensitive data reported by the finding and, for
        /// each type, 1-10 occurrences of sensitive data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<DetectedDataDetails>> SensitiveDataOccurrences
        {
            get { return this._sensitiveDataOccurrences; }
            set { this._sensitiveDataOccurrences = value; }
        }

        // Check to see if SensitiveDataOccurrences property is set
        internal bool IsSetSensitiveDataOccurrences()
        {
            return this._sensitiveDataOccurrences != null && (this._sensitiveDataOccurrences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request to retrieve occurrences of sensitive data reported by the
        /// finding. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ERROR - An error occurred when Amazon Macie attempted to locate, retrieve, or encrypt
        /// the sensitive data. The error value indicates the nature of the error that occurred.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PROCESSING - Macie is processing the request.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SUCCESS - Macie successfully located, retrieved, and encrypted the sensitive data.
        /// </para>
        /// </li></ul>
        /// </summary>
        public RevealRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}