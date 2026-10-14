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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The structure used to create or update a database.
    /// </summary>
    public partial class DatabaseInput
    {
        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// Creates a set of default permissions on the table for principals. Used by Lake Formation.
        /// Not used in the normal course of Glue operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;

        /// <summary>
        /// Checks to see if the CreateTableDefaultPermissions property is set.
        /// </summary>
        internal bool IsSetCreateTableDefaultPermissions() => this.CreateTableDefaultPermissions != null && (this.CreateTableDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FederatedDatabase. 
        /// <para>
        /// A <c>FederatedDatabase</c> structure that references an entity outside the Glue Data
        /// Catalog.
        /// </para>
        /// </summary>
        public FederatedDatabase FederatedDatabase { get; set; }

        /// <summary>
        /// Checks to see if the FederatedDatabase property is set.
        /// </summary>
        internal bool IsSetFederatedDatabase() => this.FederatedDatabase != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The location of the database (for example, an HDFS path). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the database. For Hive compatibility, this is folded to lowercase when
        /// it is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// These key-value pairs define parameters and properties of the database.
        /// </para>
        ///  
        /// <para>
        /// These key-value pairs define parameters and properties of the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDatabase. 
        /// <para>
        /// A <c>DatabaseIdentifier</c> structure that describes a target database for resource
        /// linking.
        /// </para>
        /// </summary>
        public DatabaseIdentifier TargetDatabase { get; set; }

        /// <summary>
        /// Checks to see if the TargetDatabase property is set.
        /// </summary>
        internal bool IsSetTargetDatabase() => this.TargetDatabase != null;
    }
}
