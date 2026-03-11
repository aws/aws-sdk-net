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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeclarativePoliciesReport operation.
    /// Generates an account status report. The report is generated asynchronously, and can
    /// take several hours to complete.
    /// 
    ///  
    /// <para>
    /// The report provides the current status of all attributes supported by declarative
    /// policies for the accounts within the specified scope. The scope is determined by the
    /// specified <c>TargetId</c>, which can represent an individual account, or all the accounts
    /// that fall under the specified organizational unit (OU) or root (the entire Amazon
    /// Web Services Organization).
    /// </para>
    ///  
    /// <para>
    /// The report is saved to your specified S3 bucket, using the following path structure
    /// (with the capitalized placeholders representing your specific values):
    /// </para>
    ///  
    /// <para>
    ///  <c>s3://AMZN-S3-DEMO-BUCKET/YOUR-OPTIONAL-S3-PREFIX/ec2_TARGETID_REPORTID_YYYYMMDDTHHMMZ.csv</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Prerequisites for generating a report</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>StartDeclarativePoliciesReport</c> API can only be called by the management
    /// account or delegated administrators for the organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An S3 bucket must be available before generating the report (you can create a new
    /// one or use an existing one), it must be in the same Region where the report generation
    /// request is made, and it must have an appropriate bucket policy. For a sample S3 policy,
    /// see <i>Sample Amazon S3 policy</i> under <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_StartDeclarativePoliciesReport.html#API_StartDeclarativePoliciesReport_Examples">Examples</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Trusted access must be enabled for the service for which the declarative policy will
    /// enforce a baseline configuration. If you use the Amazon Web Services Organizations
    /// console, this is done automatically when you enable declarative policies. The API
    /// uses the following service principal to identify the EC2 service: <c>ec2.amazonaws.com</c>.
    /// For more information on how to enable trusted access with the Amazon Web Services
    /// CLI and Amazon Web Services SDKs, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Using
    /// Organizations with other Amazon Web Services services</a> in the <i>Amazon Web Services
    /// Organizations User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only one report per organization can be generated at a time. Attempting to generate
    /// a report while another is in progress will result in an error.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, including the required IAM permissions to run this API, see
    /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_declarative_status-report.html">Generating
    /// the account status report for declarative policies</a> in the <i>Amazon Web Services
    /// Organizations User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartDeclarativePoliciesReportRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _s3Bucket;
        private string _s3Prefix;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the S3 bucket where the report will be saved. The bucket must be in the
        /// same Region where the report generation request is made.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The prefix for your S3 object.
        /// </para>
        /// </summary>
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The root ID, organizational unit ID, or account ID.
        /// </para>
        ///  
        /// <para>
        /// Format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For root: <c>r-ab12</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For OU: <c>ou-ab12-cdef1234</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For account: <c>123456789012</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}