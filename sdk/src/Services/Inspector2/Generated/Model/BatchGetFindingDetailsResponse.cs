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
    /// This is the response object from the BatchGetFindingDetails operation.
    /// </summary>
    public partial class BatchGetFindingDetailsResponse : AmazonWebServiceResponse
    {
        private List<FindingDetailsError> _errors = AWSConfigs.InitializeCollections ? new List<FindingDetailsError>() : null;
        private List<FindingDetail> _findingDetails = AWSConfigs.InitializeCollections ? new List<FindingDetail>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Error information for findings that details could not be returned for.
        /// </para>
        /// </summary>
        public List<FindingDetailsError> Errors
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
        /// Gets and sets the property FindingDetails. 
        /// <para>
        /// A finding's vulnerability details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<FindingDetail> FindingDetails
        {
            get { return this._findingDetails; }
            set { this._findingDetails = value; }
        }

        // Check to see if FindingDetails property is set
        internal bool IsSetFindingDetails()
        {
            return this._findingDetails != null && (this._findingDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}