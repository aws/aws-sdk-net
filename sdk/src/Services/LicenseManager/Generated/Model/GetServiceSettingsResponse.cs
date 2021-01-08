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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the GetServiceSettings operation.
    /// </summary>
    public partial class GetServiceSettingsResponse : AmazonWebServiceResponse
    {
        private bool? _enableCrossAccountsDiscovery;
        private string _licenseManagerResourceShareArn;
        private OrganizationConfiguration _organizationConfiguration;
        private string _s3BucketArn;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property EnableCrossAccountsDiscovery. 
        /// <para>
        /// Indicates whether cross-account discovery is enabled.
        /// </para>
        /// </summary>
        public bool EnableCrossAccountsDiscovery
        {
            get { return this._enableCrossAccountsDiscovery.GetValueOrDefault(); }
            set { this._enableCrossAccountsDiscovery = value; }
        }

        // Check to see if EnableCrossAccountsDiscovery property is set
        internal bool IsSetEnableCrossAccountsDiscovery()
        {
            return this._enableCrossAccountsDiscovery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseManagerResourceShareArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the AWS resource share. The License Manager master account
        /// will provide member accounts with access to this share.
        /// </para>
        /// </summary>
        public string LicenseManagerResourceShareArn
        {
            get { return this._licenseManagerResourceShareArn; }
            set { this._licenseManagerResourceShareArn = value; }
        }

        // Check to see if LicenseManagerResourceShareArn property is set
        internal bool IsSetLicenseManagerResourceShareArn()
        {
            return this._licenseManagerResourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration. 
        /// <para>
        /// Indicates whether AWS Organizations is integrated with License Manager for cross-account
        /// discovery.
        /// </para>
        /// </summary>
        public OrganizationConfiguration OrganizationConfiguration
        {
            get { return this._organizationConfiguration; }
            set { this._organizationConfiguration = value; }
        }

        // Check to see if OrganizationConfiguration property is set
        internal bool IsSetOrganizationConfiguration()
        {
            return this._organizationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Regional S3 bucket path for storing reports, license trail event data, discovery data,
        /// and so on.
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// SNS topic configured to receive notifications from License Manager.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}