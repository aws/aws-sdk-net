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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The combination of user name and password that are used as credentials.
    /// </summary>
    public partial class CredentialPair
    {
        private List<DataSourceParameters> _alternateDataSourceParameters = AWSConfigs.InitializeCollections ? new List<DataSourceParameters>() : null;
        private string _password;
        private string _username;

        /// <summary>
        /// Gets and sets the property AlternateDataSourceParameters. 
        /// <para>
        /// A set of alternate data source parameters that you want to share for these credentials.
        /// The credentials are applied in tandem with the data source parameters when you copy
        /// a data source by using a create or update request. The API operation compares the
        /// <c>DataSourceParameters</c> structure that's in the request with the structures in
        /// the <c>AlternateDataSourceParameters</c> allow list. If the structures are an exact
        /// match, the request is allowed to use the new data source with the existing credentials.
        /// If the <c>AlternateDataSourceParameters</c> list is null, the <c>DataSourceParameters</c>
        /// originally used with these <c>Credentials</c> is automatically allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<DataSourceParameters> AlternateDataSourceParameters
        {
            get { return this._alternateDataSourceParameters; }
            set { this._alternateDataSourceParameters = value; }
        }

        // Check to see if AlternateDataSourceParameters property is set
        internal bool IsSetAlternateDataSourceParameters()
        {
            return this._alternateDataSourceParameters != null && (this._alternateDataSourceParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// User name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}