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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// This is the response object from the BatchGetFindings operation.
    /// </summary>
    public partial class BatchGetFindingsResponse : AmazonWebServiceResponse
    {
        private List<BatchGetFindingsError> _failedFindings = AWSConfigs.InitializeCollections ? new List<BatchGetFindingsError>() : null;
        private List<Finding> _findings = AWSConfigs.InitializeCollections ? new List<Finding>() : null;

        /// <summary>
        /// Gets and sets the property FailedFindings. 
        /// <para>
        /// A list of errors for individual findings which were not fetched. Each BatchGetFindingsError
        /// contains the <c>scanName</c>, <c>findingId</c>, <c>errorCode</c> and error <c>message</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetFindingsError> FailedFindings
        {
            get { return this._failedFindings; }
            set { this._failedFindings = value; }
        }

        // Check to see if FailedFindings property is set
        internal bool IsSetFailedFindings()
        {
            return this._failedFindings != null && (this._failedFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        ///  A list of all findings which were successfully fetched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Finding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && (this._findings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}