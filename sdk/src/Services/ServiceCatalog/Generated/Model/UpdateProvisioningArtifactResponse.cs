/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the UpdateProvisioningArtifact operation.
    /// </summary>
    public partial class UpdateProvisioningArtifactResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _info = new Dictionary<string, string>();
        private ProvisioningArtifactDetail _provisioningArtifactDetail;
        private Status _status;

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// The URL of the CloudFormation template in Amazon S3.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Info
        {
            get { return this._info; }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info != null && this._info.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactDetail. 
        /// <para>
        /// Information about the provisioning artifact.
        /// </para>
        /// </summary>
        public ProvisioningArtifactDetail ProvisioningArtifactDetail
        {
            get { return this._provisioningArtifactDetail; }
            set { this._provisioningArtifactDetail = value; }
        }

        // Check to see if ProvisioningArtifactDetail property is set
        internal bool IsSetProvisioningArtifactDetail()
        {
            return this._provisioningArtifactDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the current request.
        /// </para>
        /// </summary>
        public Status Status
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