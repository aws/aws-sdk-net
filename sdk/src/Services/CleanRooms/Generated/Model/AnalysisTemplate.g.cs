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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The analysis template.
    /// </summary>
    public partial class AnalysisTemplate
    {
        /// <summary>
        /// Gets and sets the property AnalysisParameters. 
        /// <para>
        /// The parameters of the analysis template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<AnalysisParameter> AnalysisParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisParameter>() : null;

        /// <summary>
        /// Checks to see if the AnalysisParameters property is set.
        /// </summary>
        internal bool IsSetAnalysisParameters() => this.AnalysisParameters != null && (this.AnalysisParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The unique ARN for the analysis template’s associated collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string CollaborationArn { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationArn property is set.
        /// </summary>
        internal bool IsSetCollaborationArn() => this.CollaborationArn != null;

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique ID for the associated collaboration of the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the analysis template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorMessageConfiguration. 
        /// <para>
        /// The configuration that specifies the level of detail in error messages returned by
        /// analyses using this template. When set to <c>DETAILED</c>, error messages include
        /// more information to help troubleshoot issues with PySpark jobs. Detailed error messages
        /// may expose underlying data, including sensitive information. Recommended for faster
        /// troubleshooting in development and testing environments.
        /// </para>
        /// </summary>
        public ErrorMessageConfiguration ErrorMessageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessageConfiguration property is set.
        /// </summary>
        internal bool IsSetErrorMessageConfiguration() => this.ErrorMessageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the member who created the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The identifier of a member who created the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The entire schema object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisSchema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the analysis template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceMetadata. 
        /// <para>
        ///  The source metadata for the analysis template.
        /// </para>
        /// </summary>
        public AnalysisSourceMetadata SourceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SourceMetadata property is set.
        /// </summary>
        internal bool IsSetSourceMetadata() => this.SourceMetadata != null;

        /// <summary>
        /// Gets and sets the property SyntheticDataParameters. 
        /// <para>
        /// The parameters used to generate synthetic data for this analysis template.
        /// </para>
        /// </summary>
        public SyntheticDataParameters SyntheticDataParameters { get; set; }

        /// <summary>
        /// Checks to see if the SyntheticDataParameters property is set.
        /// </summary>
        internal bool IsSetSyntheticDataParameters() => this.SyntheticDataParameters != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time that the analysis template was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Validations. 
        /// <para>
        /// Information about the validations performed on the analysis template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisTemplateValidationStatusDetail> Validations { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisTemplateValidationStatusDetail>() : null;

        /// <summary>
        /// Checks to see if the Validations property is set.
        /// </summary>
        internal bool IsSetValidations() => this.Validations != null && (this.Validations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
