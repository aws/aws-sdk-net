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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateAnalysisPermissions operation.
    /// </summary>
    public partial class UpdateAnalysisPermissionsResponse : AmazonWebServiceResponse
    {
        private string _analysisArn;
        private string _analysisId;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property AnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the analysis that you updated.
        /// </para>
        /// </summary>
        public string AnalysisArn
        {
            get { return this._analysisArn; }
            set { this._analysisArn = value; }
        }

        // Check to see if AnalysisArn property is set
        internal bool IsSetAnalysisArn()
        {
            return this._analysisArn != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID of the analysis that you updated permissions for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A structure that describes the principals and the resource-level permissions on an
        /// analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The AWS request ID for this operation.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}