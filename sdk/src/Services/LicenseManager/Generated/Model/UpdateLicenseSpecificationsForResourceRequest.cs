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
    /// Container for the parameters to the UpdateLicenseSpecificationsForResource operation.
    /// Adds or removes the specified license configurations for the specified AWS resource.
    /// 
    ///  
    /// <para>
    /// You can update the license specifications of AMIs, instances, and hosts. You cannot
    /// update the license specifications for launch templates and AWS CloudFormation templates,
    /// as they send license configurations to the operation that creates the resource.
    /// </para>
    /// </summary>
    public partial class UpdateLicenseSpecificationsForResourceRequest : AmazonLicenseManagerRequest
    {
        private List<LicenseSpecification> _addLicenseSpecifications = new List<LicenseSpecification>();
        private List<LicenseSpecification> _removeLicenseSpecifications = new List<LicenseSpecification>();
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AddLicenseSpecifications. 
        /// <para>
        /// ARNs of the license configurations to add.
        /// </para>
        /// </summary>
        public List<LicenseSpecification> AddLicenseSpecifications
        {
            get { return this._addLicenseSpecifications; }
            set { this._addLicenseSpecifications = value; }
        }

        // Check to see if AddLicenseSpecifications property is set
        internal bool IsSetAddLicenseSpecifications()
        {
            return this._addLicenseSpecifications != null && this._addLicenseSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveLicenseSpecifications. 
        /// <para>
        /// ARNs of the license configurations to remove.
        /// </para>
        /// </summary>
        public List<LicenseSpecification> RemoveLicenseSpecifications
        {
            get { return this._removeLicenseSpecifications; }
            set { this._removeLicenseSpecifications = value; }
        }

        // Check to see if RemoveLicenseSpecifications property is set
        internal bool IsSetRemoveLicenseSpecifications()
        {
            return this._removeLicenseSpecifications != null && this._removeLicenseSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the AWS resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}