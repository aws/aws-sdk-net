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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a specified environment.
    /// </summary>
    public partial class EnvironmentDetailsEntity
    {
        /// <summary>
        /// Gets and sets the property EnvironmentId. The environment ID.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Extensions. The Open Job Description extensions that the
        /// environment uses. This value is used by the worker agent.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public List<string> Extensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null && (this.Extensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobId. The job ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property ResolvedSymbolTable. The resolved symbol table for the
        /// environment's expressions, serialized as JSON. This value is used by the worker agent.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000000)]
        public string ResolvedSymbolTable { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedSymbolTable property is set.
        /// </summary>
        internal bool IsSetResolvedSymbolTable() => this.ResolvedSymbolTable != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. The schema version in the environment.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property Template. The template used for the environment.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document Template { get; set; }

        /// <summary>
        /// Checks to see if the Template property is set.
        /// </summary>
        internal bool IsSetTemplate() => !this.Template.IsNull();
    }
}
