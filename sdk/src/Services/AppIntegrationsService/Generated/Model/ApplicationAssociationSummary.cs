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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Summary information about the Application Association.
    /// </summary>
    public partial class ApplicationAssociationSummary
    {
        private string _applicationArn;
        private string _applicationAssociationArn;
        private string _clientId;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application Association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationAssociationArn
        {
            get { return this._applicationAssociationArn; }
            set { this._applicationAssociationArn = value; }
        }

        // Check to see if ApplicationAssociationArn property is set
        internal bool IsSetApplicationAssociationArn()
        {
            return this._applicationAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the Application Association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

    }
}