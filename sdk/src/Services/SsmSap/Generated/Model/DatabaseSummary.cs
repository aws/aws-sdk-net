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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// The summary of the database.
    /// </summary>
    public partial class DatabaseSummary
    {
        private string _applicationId;
        private string _arn;
        private string _componentId;
        private string _databaseId;
        private DatabaseType _databaseType;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The ID of the database.
        /// </para>
        /// </summary>
        public string DatabaseId
        {
            get { return this._databaseId; }
            set { this._databaseId = value; }
        }

        // Check to see if DatabaseId property is set
        internal bool IsSetDatabaseId()
        {
            return this._databaseId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseType. 
        /// <para>
        /// The type of the database.
        /// </para>
        /// </summary>
        public DatabaseType DatabaseType
        {
            get { return this._databaseType; }
            set { this._databaseType = value; }
        }

        // Check to see if DatabaseType property is set
        internal bool IsSetDatabaseType()
        {
            return this._databaseType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the database.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}