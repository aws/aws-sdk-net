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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the ExportEBSVolumeRecommendations operation. Exports
    /// optimization recommendations for Amazon EBS volumes. <para> Recommendations are exported
    /// in a comma-separated values (.csv) file, and its metadata in a JavaScript Object Notation
    /// (JSON) (.json) file, to an existing Amazon Simple Storage Service (Amazon S3) bucket
    /// that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
    /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>. </para> <para> You
    /// can have only one Amazon EBS volume export job in progress per Amazon Web Services
    /// Region. </para>
    /// </summary>
    public partial class ExportEBSVolumeRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The IDs of the Amazon Web Services accounts for which to export Amazon EBS volume
        /// recommendations.
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account of an organization, use this parameter to
        /// specify the member account for which you want to export recommendations.
        /// </para>
        ///  
        /// <para>
        /// This parameter cannot be specified together with the include member accounts parameter.
        /// The parameters are mutually exclusive.
        /// </para>
        ///  
        /// <para>
        /// Recommendations for member accounts are not included in the export if this parameter,
        /// or the include member accounts parameter, is omitted.
        /// </para>
        ///  
        /// <para>
        /// You can specify multiple account IDs per request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldsToExport. 
        /// <para>
        /// The recommendations data to include in the export file. For more information about
        /// the fields that can be exported, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html#exported-files">Exported
        /// files</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FieldsToExport { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FieldsToExport property is set.
        /// </summary>
        internal bool IsSetFieldsToExport() => this.FieldsToExport != null && (this.FieldsToExport.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The format of the export file.
        /// </para>
        ///  
        /// <para>
        /// The only export file format currently supported is <c>Csv</c>.
        /// </para>
        /// </summary>
        public FileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of objects to specify a filter that exports a more specific set of Amazon
        /// EBS volume recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EBSFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<EBSFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// Indicates whether to include recommendations for resources in all member accounts
        /// of the organization if your account is the management account of an organization.
        /// </para>
        ///  
        /// <para>
        /// The member accounts must also be opted in to Compute Optimizer, and trusted access
        /// for Compute Optimizer must be enabled in the organization account. For more information,
        /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/security-iam.html#trusted-service-access">Compute
        /// Optimizer and Amazon Web Services Organizations trusted access</a> in the <i>Compute
        /// Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Recommendations for member accounts of the organization are not included in the export
        /// file if this parameter is omitted.
        /// </para>
        ///  
        /// <para>
        /// This parameter cannot be specified together with the account IDs parameter. The parameters
        /// are mutually exclusive.
        /// </para>
        ///  
        /// <para>
        /// Recommendations for member accounts are not included in the export if this parameter,
        /// or the account IDs parameter, is omitted.
        /// </para>
        /// </summary>
        public bool? IncludeMemberAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMemberAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeMemberAccounts() => this.IncludeMemberAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property S3DestinationConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public S3DestinationConfig S3DestinationConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationConfig property is set.
        /// </summary>
        internal bool IsSetS3DestinationConfig() => this.S3DestinationConfig != null;
    }
}
