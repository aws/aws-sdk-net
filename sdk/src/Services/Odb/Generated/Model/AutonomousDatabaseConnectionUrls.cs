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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The connection URLs for accessing tools and services for an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabaseConnectionUrls
    {
        private string _apexUrl;
        private string _databaseTransformsUrl;
        private string _graphStudioUrl;
        private string _machineLearningNotebookUrl;
        private string _machineLearningUserManagementUrl;
        private string _mongoDbUrl;
        private string _ordsUrl;
        private string _spatialStudioUrl;
        private string _sqlDevWebUrl;

        /// <summary>
        /// Gets and sets the property ApexUrl. 
        /// <para>
        /// The URL for accessing Oracle Application Express (APEX) for the Autonomous Database.
        /// </para>
        /// </summary>
        public string ApexUrl
        {
            get { return this._apexUrl; }
            set { this._apexUrl = value; }
        }

        // Check to see if ApexUrl property is set
        internal bool IsSetApexUrl()
        {
            return this._apexUrl != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseTransformsUrl. 
        /// <para>
        /// The URL for accessing Oracle Database Transforms for the Autonomous Database.
        /// </para>
        /// </summary>
        public string DatabaseTransformsUrl
        {
            get { return this._databaseTransformsUrl; }
            set { this._databaseTransformsUrl = value; }
        }

        // Check to see if DatabaseTransformsUrl property is set
        internal bool IsSetDatabaseTransformsUrl()
        {
            return this._databaseTransformsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property GraphStudioUrl. 
        /// <para>
        /// The URL for accessing Oracle Graph Studio for the Autonomous Database.
        /// </para>
        /// </summary>
        public string GraphStudioUrl
        {
            get { return this._graphStudioUrl; }
            set { this._graphStudioUrl = value; }
        }

        // Check to see if GraphStudioUrl property is set
        internal bool IsSetGraphStudioUrl()
        {
            return this._graphStudioUrl != null;
        }

        /// <summary>
        /// Gets and sets the property MachineLearningNotebookUrl. 
        /// <para>
        /// The URL for accessing the Oracle Machine Learning notebook for the Autonomous Database.
        /// </para>
        /// </summary>
        public string MachineLearningNotebookUrl
        {
            get { return this._machineLearningNotebookUrl; }
            set { this._machineLearningNotebookUrl = value; }
        }

        // Check to see if MachineLearningNotebookUrl property is set
        internal bool IsSetMachineLearningNotebookUrl()
        {
            return this._machineLearningNotebookUrl != null;
        }

        /// <summary>
        /// Gets and sets the property MachineLearningUserManagementUrl. 
        /// <para>
        /// The URL for accessing Oracle Machine Learning user management for the Autonomous Database.
        /// </para>
        /// </summary>
        public string MachineLearningUserManagementUrl
        {
            get { return this._machineLearningUserManagementUrl; }
            set { this._machineLearningUserManagementUrl = value; }
        }

        // Check to see if MachineLearningUserManagementUrl property is set
        internal bool IsSetMachineLearningUserManagementUrl()
        {
            return this._machineLearningUserManagementUrl != null;
        }

        /// <summary>
        /// Gets and sets the property MongoDbUrl. 
        /// <para>
        /// The URL for accessing the MongoDB API for the Autonomous Database.
        /// </para>
        /// </summary>
        public string MongoDbUrl
        {
            get { return this._mongoDbUrl; }
            set { this._mongoDbUrl = value; }
        }

        // Check to see if MongoDbUrl property is set
        internal bool IsSetMongoDbUrl()
        {
            return this._mongoDbUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OrdsUrl. 
        /// <para>
        /// The URL for accessing Oracle REST Data Services (ORDS) for the Autonomous Database.
        /// </para>
        /// </summary>
        public string OrdsUrl
        {
            get { return this._ordsUrl; }
            set { this._ordsUrl = value; }
        }

        // Check to see if OrdsUrl property is set
        internal bool IsSetOrdsUrl()
        {
            return this._ordsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SpatialStudioUrl. 
        /// <para>
        /// The URL for accessing Oracle Spatial Studio for the Autonomous Database.
        /// </para>
        /// </summary>
        public string SpatialStudioUrl
        {
            get { return this._spatialStudioUrl; }
            set { this._spatialStudioUrl = value; }
        }

        // Check to see if SpatialStudioUrl property is set
        internal bool IsSetSpatialStudioUrl()
        {
            return this._spatialStudioUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SqlDevWebUrl. 
        /// <para>
        /// The URL for accessing Oracle SQL Developer Web for the Autonomous Database.
        /// </para>
        /// </summary>
        public string SqlDevWebUrl
        {
            get { return this._sqlDevWebUrl; }
            set { this._sqlDevWebUrl = value; }
        }

        // Check to see if SqlDevWebUrl property is set
        internal bool IsSetSqlDevWebUrl()
        {
            return this._sqlDevWebUrl != null;
        }

    }
}