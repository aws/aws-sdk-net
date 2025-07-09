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
    /// Details about a failed attempt to associate or disassociate a code repository with
    /// a scan configuration.
    /// </summary>
    public partial class FailedAssociationResult
    {
        private CodeSecurityResource _resource;
        private string _scanConfigurationArn;
        private AssociationResultStatusCode _statusCode;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Resource.
        /// </summary>
        public CodeSecurityResource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scan configuration that failed to be associated
        /// or disassociated.
        /// </para>
        /// </summary>
        public string ScanConfigurationArn
        {
            get { return this._scanConfigurationArn; }
            set { this._scanConfigurationArn = value; }
        }

        // Check to see if ScanConfigurationArn property is set
        internal bool IsSetScanConfigurationArn()
        {
            return this._scanConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code indicating why the association or disassociation failed.
        /// </para>
        /// </summary>
        public AssociationResultStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining why the association or disassociation failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}