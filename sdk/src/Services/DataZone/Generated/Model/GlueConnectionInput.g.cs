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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon Web Services Glue connecton input.
    /// </summary>
    public partial class GlueConnectionInput
    {
        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// The Amazon Athena properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AthenaProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AthenaProperties property is set.
        /// </summary>
        internal bool IsSetAthenaProperties() => this.AthenaProperties != null && (this.AthenaProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public AuthenticationConfigurationInput AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfiguration() => this.AuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// The connection properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ConnectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionProperties property is set.
        /// </summary>
        internal bool IsSetConnectionProperties() => this.ConnectionProperties != null && (this.ConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The connection type of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public GlueConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// The match criteria of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public string MatchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the MatchCriteria property is set.
        /// </summary>
        internal bool IsSetMatchCriteria() => this.MatchCriteria != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// The physical connection requirements for the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public PhysicalConnectionRequirements PhysicalConnectionRequirements { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalConnectionRequirements property is set.
        /// </summary>
        internal bool IsSetPhysicalConnectionRequirements() => this.PhysicalConnectionRequirements != null;

        /// <summary>
        /// Gets and sets the property PythonProperties. 
        /// <para>
        /// The Python properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PythonProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the PythonProperties property is set.
        /// </summary>
        internal bool IsSetPythonProperties() => this.PythonProperties != null && (this.PythonProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparkProperties. 
        /// <para>
        /// The Spark properties of the Amazon Web Services Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparkProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SparkProperties property is set.
        /// </summary>
        internal bool IsSetSparkProperties() => this.SparkProperties != null && (this.SparkProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidateCredentials. 
        /// <para>
        /// Speciefies whether to validate credentials of the Amazon Web Services Glue connection.
        /// </para>
        /// </summary>
        public bool? ValidateCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ValidateCredentials property is set.
        /// </summary>
        internal bool IsSetValidateCredentials() => this.ValidateCredentials.HasValue;

        /// <summary>
        /// Gets and sets the property ValidateForComputeEnvironments. 
        /// <para>
        /// Speciefies whether to validate for compute environments of the Amazon Web Services
        /// Glue connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> ValidateForComputeEnvironments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidateForComputeEnvironments property is set.
        /// </summary>
        internal bool IsSetValidateForComputeEnvironments() => this.ValidateForComputeEnvironments != null && (this.ValidateForComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
