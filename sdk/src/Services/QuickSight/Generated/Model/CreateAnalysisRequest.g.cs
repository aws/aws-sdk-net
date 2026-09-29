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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnalysis operation. Creates an analysis
    /// in Amazon Quick Sight. Analyses can be created either from a template or from an <c>AnalysisDefinition</c>.
    /// </summary>
    public partial class CreateAnalysisRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID for the analysis that you're creating. This ID displays in the URL of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you are creating an analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of an analysis.
        /// </para>
        ///  
        /// <para>
        /// A definition is the data model of all features in a Dashboard, Template, or Analysis.
        /// </para>
        ///  
        /// <para>
        /// Either a <c>SourceEntity</c> or a <c>Definition</c> must be provided in order for
        /// the request to be valid.
        /// </para>
        /// </summary>
        public AnalysisDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property FolderArns. 
        /// <para>
        /// When you create the analysis, Amazon Quick Sight adds the analysis to these folders.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> FolderArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FolderArns property is set.
        /// </summary>
        internal bool IsSetFolderArns() => this.FolderArns != null && (this.FolderArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the analysis that you're creating. This name displays for the
        /// analysis in the Amazon Quick Sight console. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter names and override values that you want to use. An analysis can have
        /// any parameter type, and some parameters might accept multiple values. 
        /// </para>
        /// </summary>
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A structure that describes the principals and the resource-level permissions on an
        /// analysis. You can use the <c>Permissions</c> structure to grant permissions by providing
        /// a list of Identity and Access Management (IAM) action information for each principal
        /// listed by Amazon Resource Name (ARN). 
        /// </para>
        ///  
        /// <para>
        /// To specify no permissions, omit <c>Permissions</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public List<ResourcePermission> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// A source entity to use for the analysis that you're creating. This metadata structure
        /// contains details that describe a source template and one or more datasets or topics.
        /// </para>
        ///  
        /// <para>
        /// Either a <c>SourceEntity</c> or a <c>Definition</c> must be provided in order for
        /// the request to be valid.
        /// </para>
        /// </summary>
        public AnalysisSourceEntity SourceEntity { get; set; }

        /// <summary>
        /// Checks to see if the SourceEntity property is set.
        /// </summary>
        internal bool IsSetSourceEntity() => this.SourceEntity != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN for the theme to apply to the analysis that you're creating. To see the theme
        /// in the Amazon Quick Sight console, make sure that you have access to it.
        /// </para>
        /// </summary>
        public string ThemeArn { get; set; }

        /// <summary>
        /// Checks to see if the ThemeArn property is set.
        /// </summary>
        internal bool IsSetThemeArn() => this.ThemeArn != null;

        /// <summary>
        /// Gets and sets the property ValidationStrategy. 
        /// <para>
        /// The option to relax the validation needed to create an analysis with definition objects.
        /// This skips the validation step for specific errors.
        /// </para>
        /// </summary>
        public ValidationStrategy ValidationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStrategy property is set.
        /// </summary>
        internal bool IsSetValidationStrategy() => this.ValidationStrategy != null;
    }
}
