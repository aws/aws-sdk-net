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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation. Creates a new DataBrew
    /// project.
    /// </summary>
    public partial class CreateProjectRequest : AmazonGlueDataBrewRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of an existing dataset to associate this project with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the new project. Valid characters are alphanumeric (A-Z, a-z, 0-9),
        /// hyphen (-), period (.), and space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecipeName. 
        /// <para>
        /// The name of an existing recipe to associate with the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RecipeName { get; set; }

        /// <summary>
        /// Checks to see if the RecipeName property is set.
        /// </summary>
        internal bool IsSetRecipeName() => this.RecipeName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role to
        /// be assumed for this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Sample.
        /// </summary>
        public Sample Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags to apply to this project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
