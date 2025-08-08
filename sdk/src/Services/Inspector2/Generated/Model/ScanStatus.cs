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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The status of the scan.
    /// </summary>
    public partial class ScanStatus
    {
        private ScanStatusReason _reason;
        private ScanStatusCode _statusCode;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The scan status. Possible return values and descriptions are: 
        /// </para>
        ///  
        /// <para>
        ///  <c>ACCESS_DENIED</c> - Resource access policy restricting Amazon Inspector access.
        /// Please update the IAM policy.
        /// </para>
        ///  
        /// <para>
        ///  <c>ACCESS_DENIED_TO_ENCRYPTION_KEY</c> - The KMS key policy doesn't allow Amazon
        /// Inspector access. Update the key policy.
        /// </para>
        ///  
        /// <para>
        ///  <c>DEEP_INSPECTION_COLLECTION_TIME_LIMIT_EXCEEDED</c> - Amazon Inspector failed to
        /// extract the package inventory because the package collection time exceeding the maximum
        /// threshold of 15 minutes.
        /// </para>
        ///  
        /// <para>
        ///  <c>DEEP_INSPECTION_DAILY_SSM_INVENTORY_LIMIT_EXCEEDED</c> - The SSM agent couldn't
        /// send inventory to Amazon Inspector because the SSM quota for Inventory data collected
        /// per instance per day has already been reached for this instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>DEEP_INSPECTION_NO_INVENTORY</c> - The Amazon Inspector plugin hasn't yet been
        /// able to collect an inventory of packages for this instance. This is usually the result
        /// of a pending scan, however, if this status persists after 6 hours, use SSM to ensure
        /// that the required Amazon Inspector associations exist and are running for the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>DEEP_INSPECTION_PACKAGE_COLLECTION_LIMIT_EXCEEDED</c> - The instance has exceeded
        /// the 5000 package limit for Amazon Inspector Deep inspection. To resume Deep inspection
        /// for this instance you can try to adjust the custom paths associated with the account.
        /// </para>
        ///  
        /// <para>
        ///  <c>EC2_INSTANCE_STOPPED</c> - This EC2 instance is in a stopped state, therefore,
        /// Amazon Inspector will pause scanning. The existing findings will continue to exist
        /// until the instance is terminated. Once the instance is re-started, Inspector will
        /// automatically start scanning the instance again. Please note that you will not be
        /// charged for this instance while it's in a stopped state.
        /// </para>
        ///  
        /// <para>
        ///  <c>EXCLUDED_BY_TAG</c> - This resource was not scanned because it has been excluded
        /// by a tag.
        /// </para>
        ///  
        /// <para>
        ///  <c>IMAGE_SIZE_EXCEEDED</c> - Reserved for future use.
        /// </para>
        ///  
        /// <para>
        ///  <c>INTEGRATION_CONNNECTION_LOST</c> - Amazon Inspector couldn't communicate with
        /// the source code management platform.
        /// </para>
        ///  
        /// <para>
        ///  <c>INTERNAL_ERROR</c> - Amazon Inspector has encountered an internal error for this
        /// resource. Amazon Inspector service will automatically resolve the issue and resume
        /// the scanning. No action required from the user.
        /// </para>
        ///  
        /// <para>
        ///  <c>NO_INVENTORY</c> - Amazon Inspector couldn't find software application inventory
        /// to scan for vulnerabilities. This might be caused due to required Amazon Inspector
        /// associations being deleted or failing to run on your resource. Please verify the status
        /// of <c>InspectorInventoryCollection-do-not-delete</c> association in the SSM console
        /// for the resource. Additionally, you can verify the instance's inventory in the SSM
        /// Fleet Manager console.
        /// </para>
        ///  
        /// <para>
        ///  <c>NO_RESOURCES_FOUND</c> - Reserved for future use.
        /// </para>
        ///  
        /// <para>
        ///  <c>NO_SCAN_CONFIGURATION_ASSOCIATED</c> - The code repository resource doesn't have
        /// an associated scan configuration.
        /// </para>
        ///  
        /// <para>
        ///  <c>PENDING_DISABLE</c> - This resource is pending cleanup during disablement. The
        /// customer will not be billed while a resource is in the pending disable status.
        /// </para>
        ///  
        /// <para>
        ///  <c>PENDING_INITIAL_SCAN</c> - This resource has been identified for scanning, results
        /// will be available soon.
        /// </para>
        ///  
        /// <para>
        ///  <c>RESOURCE_TERMINATED</c> - This resource has been terminated. The findings and
        /// coverage associated with this resource are in the process of being cleaned up.
        /// </para>
        ///  
        /// <para>
        ///  <c>SCAN_ELIGIBILITY_EXPIRED</c> - The configured scan duration has lapsed for this
        /// image.
        /// </para>
        ///  
        /// <para>
        ///  <c>SCAN_FREQUENCY_MANUAL</c> - This image will not be covered by Amazon Inspector
        /// due to the repository scan frequency configuration.
        /// </para>
        ///  
        /// <para>
        ///  <c>SCAN_FREQUENCY_SCAN_ON_PUSH</c> - This image will be scanned one time and will
        /// not new findings because of the scan frequency configuration.
        /// </para>
        ///  
        /// <para>
        ///  <c>SCAN_IN_PROGRESS</c> - The resource is currently being scanned.
        /// </para>
        ///  
        /// <para>
        ///  <c>STALE_INVENTORY</c> - Amazon Inspector wasn't able to collect an updated software
        /// application inventory in the last 7 days. Please confirm the required Amazon Inspector
        /// associations still exist and you can still see an updated inventory in the SSM console.
        /// </para>
        ///  
        /// <para>
        ///  <c>SUCCESSFUL</c> - The scan was successful.
        /// </para>
        ///  
        /// <para>
        ///  <c>UNMANAGED_EC2_INSTANCE</c> - The EC2 instance is not managed by SSM, please use
        /// the following SSM automation to remediate the issue: <a href="https://docs.aws.amazon.com/systems-manager-automation-runbooks/latest/userguide/automation-awssupport-troubleshoot-managed-instance.html">https://docs.aws.amazon.com/systems-manager-automation-runbooks/latest/userguide/automation-awssupport-troubleshoot-managed-instance.html</a>.
        /// Once the instance becomes managed by SSM, Inspector will automatically begin scanning
        /// this instance. 
        /// </para>
        ///  
        /// <para>
        ///  <c>UNSUPPORTED_CONFIG_FILE</c> - Reserved for future use.
        /// </para>
        ///  
        /// <para>
        ///  <c>UNSUPPORTED_LANGUAGE</c> - The scan was unsuccessful because the repository contains
        /// files in an unsupported programming language.
        /// </para>
        ///  
        /// <para>
        ///  <c>UNSUPPORTED_MEDIA_TYPE </c>- The ECR image has an unsupported media type.
        /// </para>
        ///  
        /// <para>
        ///  <c>UNSUPPORTED_OS</c> - Amazon Inspector does not support this OS, architecture,
        /// or image manifest type at this time. To see a complete list of supported operating
        /// systems see: <a href=" https://docs.aws.amazon.com/inspector/latest/user/supported.html">https://docs.aws.amazon.com/inspector/latest/user/supported.html</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>UNSUPPORTED_RUNTIME</c> - The function was not scanned because it has an unsupported
        /// runtime. To see a complete list of supported runtimes see: <a href=" https://docs.aws.amazon.com/inspector/latest/user/supported.html">https://docs.aws.amazon.com/inspector/latest/user/supported.html</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanStatusReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code of the scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScanStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}