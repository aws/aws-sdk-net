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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the GetTemporaryDataLocationCredentials operation.
    /// </summary>
    public partial class GetTemporaryDataLocationCredentialsResponse : AmazonWebServiceResponse
    {
        private List<string> _accessibleDataLocations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TemporaryCredentials _credentials;
        private CredentialsScope _credentialsScope;

        /// <summary>
        /// Gets and sets the property AccessibleDataLocations. 
        /// <para>
        /// Refers to the Amazon S3 locations that can be accessed through the <c>GetTemporaryCredentialsForLocation</c>
        /// API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccessibleDataLocations
        {
            get { return this._accessibleDataLocations; }
            set { this._accessibleDataLocations = value; }
        }

        // Check to see if AccessibleDataLocations property is set
        internal bool IsSetAccessibleDataLocations()
        {
            return this._accessibleDataLocations != null && (this._accessibleDataLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Credentials.
        /// </summary>
        public TemporaryCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsScope. 
        /// <para>
        /// The credential scope is determined by the caller's Lake Formation permission on the
        /// associated table. Credential scope can be either:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// READ - Provides read-only access to the data location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// READ_WRITE - Provides both read and write access to the data location.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CredentialsScope CredentialsScope
        {
            get { return this._credentialsScope; }
            set { this._credentialsScope = value; }
        }

        // Check to see if CredentialsScope property is set
        internal bool IsSetCredentialsScope()
        {
            return this._credentialsScope != null;
        }

    }
}