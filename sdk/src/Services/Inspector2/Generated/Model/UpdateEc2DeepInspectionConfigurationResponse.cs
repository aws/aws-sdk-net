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
    /// This is the response object from the UpdateEc2DeepInspectionConfiguration operation.
    /// </summary>
    public partial class UpdateEc2DeepInspectionConfigurationResponse : AmazonWebServiceResponse
    {
        private string _errorMessage;
        private List<string> _orgPackagePaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _packagePaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Ec2DeepInspectionStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message explaining why new Amazon Inspector deep inspection custom paths
        /// could not be added.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property OrgPackagePaths. 
        /// <para>
        /// The current Amazon Inspector deep inspection custom paths for the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> OrgPackagePaths
        {
            get { return this._orgPackagePaths; }
            set { this._orgPackagePaths = value; }
        }

        // Check to see if OrgPackagePaths property is set
        internal bool IsSetOrgPackagePaths()
        {
            return this._orgPackagePaths != null && (this._orgPackagePaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PackagePaths. 
        /// <para>
        /// The current Amazon Inspector deep inspection custom paths for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> PackagePaths
        {
            get { return this._packagePaths; }
            set { this._packagePaths = value; }
        }

        // Check to see if PackagePaths property is set
        internal bool IsSetPackagePaths()
        {
            return this._packagePaths != null && (this._packagePaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of Amazon Inspector deep inspection in your account.
        /// </para>
        /// </summary>
        public Ec2DeepInspectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}