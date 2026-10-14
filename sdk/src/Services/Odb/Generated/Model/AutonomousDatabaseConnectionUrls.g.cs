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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApexUrl. 
        /// <para>
        /// The URL for accessing Oracle Application Express (APEX) for the Autonomous Database.
        /// </para>
        /// </summary>
        public string ApexUrl { get; set; }

        /// <summary>
        /// Checks to see if the ApexUrl property is set.
        /// </summary>
        internal bool IsSetApexUrl() => this.ApexUrl != null;

        /// <summary>
        /// Gets and sets the property DatabaseTransformsUrl. 
        /// <para>
        /// The URL for accessing Oracle Database Transforms for the Autonomous Database.
        /// </para>
        /// </summary>
        public string DatabaseTransformsUrl { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseTransformsUrl property is set.
        /// </summary>
        internal bool IsSetDatabaseTransformsUrl() => this.DatabaseTransformsUrl != null;

        /// <summary>
        /// Gets and sets the property GraphStudioUrl. 
        /// <para>
        /// The URL for accessing Oracle Graph Studio for the Autonomous Database.
        /// </para>
        /// </summary>
        public string GraphStudioUrl { get; set; }

        /// <summary>
        /// Checks to see if the GraphStudioUrl property is set.
        /// </summary>
        internal bool IsSetGraphStudioUrl() => this.GraphStudioUrl != null;

        /// <summary>
        /// Gets and sets the property MachineLearningNotebookUrl. 
        /// <para>
        /// The URL for accessing the Oracle Machine Learning notebook for the Autonomous Database.
        /// </para>
        /// </summary>
        public string MachineLearningNotebookUrl { get; set; }

        /// <summary>
        /// Checks to see if the MachineLearningNotebookUrl property is set.
        /// </summary>
        internal bool IsSetMachineLearningNotebookUrl() => this.MachineLearningNotebookUrl != null;

        /// <summary>
        /// Gets and sets the property MachineLearningUserManagementUrl. 
        /// <para>
        /// The URL for accessing Oracle Machine Learning user management for the Autonomous Database.
        /// </para>
        /// </summary>
        public string MachineLearningUserManagementUrl { get; set; }

        /// <summary>
        /// Checks to see if the MachineLearningUserManagementUrl property is set.
        /// </summary>
        internal bool IsSetMachineLearningUserManagementUrl() => this.MachineLearningUserManagementUrl != null;

        /// <summary>
        /// Gets and sets the property MongoDbUrl. 
        /// <para>
        /// The URL for accessing the MongoDB API for the Autonomous Database.
        /// </para>
        /// </summary>
        public string MongoDbUrl { get; set; }

        /// <summary>
        /// Checks to see if the MongoDbUrl property is set.
        /// </summary>
        internal bool IsSetMongoDbUrl() => this.MongoDbUrl != null;

        /// <summary>
        /// Gets and sets the property OrdsUrl. 
        /// <para>
        /// The URL for accessing Oracle REST Data Services (ORDS) for the Autonomous Database.
        /// </para>
        /// </summary>
        public string OrdsUrl { get; set; }

        /// <summary>
        /// Checks to see if the OrdsUrl property is set.
        /// </summary>
        internal bool IsSetOrdsUrl() => this.OrdsUrl != null;

        /// <summary>
        /// Gets and sets the property SpatialStudioUrl. 
        /// <para>
        /// The URL for accessing Oracle Spatial Studio for the Autonomous Database.
        /// </para>
        /// </summary>
        public string SpatialStudioUrl { get; set; }

        /// <summary>
        /// Checks to see if the SpatialStudioUrl property is set.
        /// </summary>
        internal bool IsSetSpatialStudioUrl() => this.SpatialStudioUrl != null;

        /// <summary>
        /// Gets and sets the property SqlDevWebUrl. 
        /// <para>
        /// The URL for accessing Oracle SQL Developer Web for the Autonomous Database.
        /// </para>
        /// </summary>
        public string SqlDevWebUrl { get; set; }

        /// <summary>
        /// Checks to see if the SqlDevWebUrl property is set.
        /// </summary>
        internal bool IsSetSqlDevWebUrl() => this.SqlDevWebUrl != null;
    }
}
