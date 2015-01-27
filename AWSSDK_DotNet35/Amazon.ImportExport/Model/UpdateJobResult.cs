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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Output structure for the UpateJob operation.
    /// </summary>
    public partial class UpdateJobResult : AmazonWebServiceResponse
    {
        private List<Artifact> _artifactList = new List<Artifact>();
        private bool? _success;
        private string _warningMessage;

        /// <summary>
        /// Gets and sets the property ArtifactList.
        /// </summary>
        public List<Artifact> ArtifactList
        {
            get { return this._artifactList; }
            set { this._artifactList = value; }
        }

        // Check to see if ArtifactList property is set
        internal bool IsSetArtifactList()
        {
            return this._artifactList != null && this._artifactList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Success.
        /// </summary>
        public bool Success
        {
            get { return this._success.GetValueOrDefault(); }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarningMessage.
        /// </summary>
        public string WarningMessage
        {
            get { return this._warningMessage; }
            set { this._warningMessage = value; }
        }

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this._warningMessage != null;
        }

    }
}