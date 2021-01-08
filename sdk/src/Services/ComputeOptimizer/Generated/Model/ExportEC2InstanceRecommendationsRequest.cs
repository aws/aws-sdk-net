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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the ExportEC2InstanceRecommendations operation.
    /// Exports optimization recommendations for Amazon EC2 instances.
    /// 
    ///  
    /// <para>
    /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
    /// in a JavaScript Object Notation (.json) file, to an existing Amazon Simple Storage
    /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
    /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can have only one Amazon EC2 instance export job in progress per AWS Region.
    /// </para>
    /// </summary>
    public partial class ExportEC2InstanceRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = new List<string>();
        private List<string> _fieldsToExport = new List<string>();
        private FileFormat _fileFormat;
        private List<Filter> _filters = new List<Filter>();
        private bool? _includeMemberAccounts;
        private S3DestinationConfig _s3DestinationConfig;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The IDs of the AWS accounts for which to export instance recommendations.
        /// </para>
        ///  
        /// <para>
        /// If your account is the management account of an organization, use this parameter to
        /// specify the member accounts for which you want to export recommendations.
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
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
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
            return this._fieldsToExport != null && this._fieldsToExport.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The format of the export file.
        /// </para>
        ///  
        /// <para>
        /// The only export file format currently supported is <code>Csv</code>.
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
        /// An array of objects that describe a filter to export a more specific set of instance
        /// recommendations.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// Indicates whether to include recommendations for resources in all member accounts
        /// of the organization if your account is the management account of an organization.
        /// </para>
        ///  
        /// <para>
        /// The member accounts must also be opted in to Compute Optimizer.
        /// </para>
        ///  
        /// <para>
        /// Recommendations for member accounts of the organization are not included in the export
        /// file if this parameter is omitted.
        /// </para>
        ///  
        /// <para>
        /// Recommendations for member accounts are not included in the export if this parameter,
        /// or the account IDs parameter, is omitted.
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
        /// <para>
        /// An object to specify the destination Amazon Simple Storage Service (Amazon S3) bucket
        /// name and key prefix for the export job.
        /// </para>
        ///  
        /// <para>
        /// You must create the destination Amazon S3 bucket for your recommendations export before
        /// you create the export job. Compute Optimizer does not create the S3 bucket for you.
        /// After you create the S3 bucket, ensure that it has the required permission policy
        /// to allow Compute Optimizer to write the export file to it. If you plan to specify
        /// an object prefix when you create the export job, you must include the object prefix
        /// in the policy that you add to the S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/create-s3-bucket-policy-for-compute-optimizer.html">Amazon
        /// S3 Bucket Policy for Compute Optimizer</a> in the <i>Compute Optimizer user guide</i>.
        /// </para>
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