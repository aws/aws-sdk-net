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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
    /// Container for the parameters to the ExportIdleRecommendations operation.
    /// Export optimization recommendations for your idle resources. 
    /// 
    ///  
    /// <para>
    /// Recommendations are exported in a comma-separated values (CSV) file, and its metadata
    /// in a JavaScript Object Notation (JSON) file, to an existing Amazon Simple Storage
    /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
    /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can have only one idle resource export job in progress per Amazon Web Services
    /// Region.
    /// </para>
    /// </summary>
    public partial class ExportIdleRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _fieldsToExport = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FileFormat _fileFormat;
        private List<IdleRecommendationFilter> _filters = AWSConfigs.InitializeCollections ? new List<IdleRecommendationFilter>() : null;
        private bool? _includeMemberAccounts;
        private S3DestinationConfig _s3DestinationConfig;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  The Amazon Web Services account IDs for the export idle resource recommendations.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account or the delegated administrator of an organization,
        /// use this parameter to specify the member account you want to export recommendations
        /// to.
        /// </para>
        ///  
        /// <para>
        /// This parameter can't be specified together with the include member accounts parameter.
        /// The parameters are mutually exclusive.
        /// </para>
        ///  
        /// <para>
        /// If this parameter or the include member accounts parameter is omitted, the recommendations
        /// for member accounts aren't included in the export.
        /// </para>
        ///  
        /// <para>
        /// You can specify multiple account IDs per request.
        /// </para>
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldsToExport. 
        /// <para>
        /// The recommendations data to include in the export file. For more information about
        /// the fields that can be exported, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html#exported-files">Exported
        /// files</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> FieldsToExport
        {
            get { return this._fieldsToExport; }
            set { this._fieldsToExport = value; }
        }

        // Check to see if FieldsToExport property is set
        internal bool IsSetFieldsToExport()
        {
            return this._fieldsToExport != null && (this._fieldsToExport.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The format of the export file. The CSV file is the only export file format currently
        /// supported.
        /// </para>
        /// </summary>
        public FileFormat FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of objects to specify a filter that exports a more specific set of idle resource
        /// recommendations.
        /// </para>
        /// </summary>
        public List<IdleRecommendationFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// If your account is the management account or the delegated administrator of an organization,
        /// this parameter indicates whether to include recommendations for resources in all member
        /// accounts of the organization.
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
        /// If this parameter is omitted, recommendations for member accounts of the organization
        /// aren't included in the export file.
        /// </para>
        ///  
        /// <para>
        /// If this parameter or the account ID parameter is omitted, recommendations for member
        /// accounts aren't included in the export.
        /// </para>
        /// </summary>
        public bool IncludeMemberAccounts
        {
            get { return this._includeMemberAccounts.GetValueOrDefault(); }
            set { this._includeMemberAccounts = value; }
        }

        // Check to see if IncludeMemberAccounts property is set
        internal bool IsSetIncludeMemberAccounts()
        {
            return this._includeMemberAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3DestinationConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public S3DestinationConfig S3DestinationConfig
        {
            get { return this._s3DestinationConfig; }
            set { this._s3DestinationConfig = value; }
        }

        // Check to see if S3DestinationConfig property is set
        internal bool IsSetS3DestinationConfig()
        {
            return this._s3DestinationConfig != null;
        }

    }
}