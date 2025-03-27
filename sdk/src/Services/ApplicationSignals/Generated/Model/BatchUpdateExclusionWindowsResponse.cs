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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateExclusionWindows operation.
    /// </summary>
    public partial class BatchUpdateExclusionWindowsResponse : AmazonWebServiceResponse
    {
        private List<BatchUpdateExclusionWindowsError> _errors = AWSConfigs.InitializeCollections ? new List<BatchUpdateExclusionWindowsError>() : null;
        private List<string> _sloIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors that occurred while processing the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<BatchUpdateExclusionWindowsError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SloIds. 
        /// <para>
        /// The list of SLO IDs that were successfully processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> SloIds
        {
            get { return this._sloIds; }
            set { this._sloIds = value; }
        }

        // Check to see if SloIds property is set
        internal bool IsSetSloIds()
        {
            return this._sloIds != null && (this._sloIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}