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
    /// Container for the parameters to the CreateAnalysis operation.
    /// Creates an analysis in Amazon QuickSight. Analyses can be created either from a template
    /// or from an <c>AnalysisDefinition</c>.
    /// </summary>
    public partial class CreateAnalysisRequest : AmazonQuickSightRequest
    {
        private string _analysisId;
        private string _awsAccountId;
        private AnalysisDefinition _definition;
        private List<string> _folderArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private Parameters _parameters;
        private List<ResourcePermission> _permissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private AnalysisSourceEntity _sourceEntity;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _themeArn;
        private ValidationStrategy _validationStrategy;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID for the analysis that you're creating. This ID displays in the URL of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you are creating an analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

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
        public AnalysisDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property FolderArns. 
        /// <para>
        /// When you create the analysis, QuickSight adds the analysis to these folders.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> FolderArns
        {
            get { return this._folderArns; }
            set { this._folderArns = value; }
        }

        // Check to see if FolderArns property is set
        internal bool IsSetFolderArns()
        {
            return this._folderArns != null && (this._folderArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the analysis that you're creating. This name displays for the
        /// analysis in the QuickSight console. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter names and override values that you want to use. An analysis can have
        /// any parameter type, and some parameters might accept multiple values. 
        /// </para>
        /// </summary>
        public Parameters Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// A source entity to use for the analysis that you're creating. This metadata structure
        /// contains details that describe a source template and one or more datasets.
        /// </para>
        ///  
        /// <para>
        /// Either a <c>SourceEntity</c> or a <c>Definition</c> must be provided in order for
        /// the request to be valid.
        /// </para>
        /// </summary>
        public AnalysisSourceEntity SourceEntity
        {
            get { return this._sourceEntity; }
            set { this._sourceEntity = value; }
        }

        // Check to see if SourceEntity property is set
        internal bool IsSetSourceEntity()
        {
            return this._sourceEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN for the theme to apply to the analysis that you're creating. To see the theme
        /// in the QuickSight console, make sure that you have access to it.
        /// </para>
        /// </summary>
        public string ThemeArn
        {
            get { return this._themeArn; }
            set { this._themeArn = value; }
        }

        // Check to see if ThemeArn property is set
        internal bool IsSetThemeArn()
        {
            return this._themeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStrategy. 
        /// <para>
        /// The option to relax the validation needed to create an analysis with definition objects.
        /// This skips the validation step for specific errors.
        /// </para>
        /// </summary>
        public ValidationStrategy ValidationStrategy
        {
            get { return this._validationStrategy; }
            set { this._validationStrategy = value; }
        }

        // Check to see if ValidationStrategy property is set
        internal bool IsSetValidationStrategy()
        {
            return this._validationStrategy != null;
        }

    }
}